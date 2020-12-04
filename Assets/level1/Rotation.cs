using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Rotation : MonoBehaviour
{
    public GameObject gobj;
    public AudioSource source;
    public AudioClip clip;
    Plane objPlane;
    int counter= 0, y=90;
    float clickTimer ;
    Ray GenerateMouseRay(Vector3 touchPos)
    {
        Vector3 mousePosFar = new Vector3(touchPos.x, touchPos.y, Camera.main.farClipPlane);
        Vector3 mousePosNear = new Vector3(touchPos.x, touchPos.y, Camera.main.nearClipPlane);
        Vector3 mousePosF = Camera.main.ScreenToWorldPoint(mousePosFar);
        Vector3 mousePosN = Camera.main.ScreenToWorldPoint(mousePosNear);
        Ray mr = new Ray(mousePosN, mousePosF - mousePosN);
        return mr;

    }



     void Update()
     {
        if (Input.touchCount == 1)

        {
            //détecter un toucher
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {

                Ray mouseRay = GenerateMouseRay(Input.GetTouch(0).position);
                RaycastHit hit;
                if (Physics.Raycast(mouseRay.origin, mouseRay.direction, out hit))
                {
                    gobj = hit.transform.gameObject;
                    Ray mRay = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                    float rayDistance;
                    objPlane.Raycast(mRay, out rayDistance);
                    //initialiser un timer pour calculer le temps entre le premier toucher et le deuxième
                    clickTimer = 3;
                    //compter le nombre de toucher 
                    counter++;

                }



            }
            // si le nombre de clique sur la pièce est impaire lancer le timer 
            if (counter % 2 != 0)
            {
                StartCoroutine(timer());
            }
        }

    }
    IEnumerator timer()
    {

        yield return new WaitForSeconds(0.1f);
        clickTimer = clickTimer - 0.1f;
        //si le nombre de clique sur la pièce est paire
        if (counter % 2 == 0)
        {
            //si le temps n'est pas fini
            if (clickTimer >= 0)

            {
                //si la pièce n'est pas dans la rotation correcte
                if (gobj.transform.localRotation != Quaternion.Euler((float)-89.98, 180, 0))

                {
                    //pivoter la pièce sur l'axe y de 90°
                    gobj.transform.localRotation = Quaternion.Euler((float)-89.98, (float)y, 0);
                    //activer le son
                    source.PlayOneShot(clip);
                    y = y + 90;
                }
            }
        }

    }
}
