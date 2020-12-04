using UnityEngine;

public class Move : MonoBehaviour
{

    public GameObject gobj;
    public AudioSource source;
    public AudioClip clip;
    Plane objPlane;
    Vector3 m0;
    public Vector3 rightPosition;

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
        //Si un contact avec l'écran a été détecté
        if (Input.touchCount > 0)
        {
            // Si un doigt a touché l'écran
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {

                Ray mouseRay = GenerateMouseRay(Input.GetTouch(0).position);
                RaycastHit hit;
                if (Physics.Raycast(mouseRay.origin, mouseRay.direction, out hit))
                {
                    gobj = hit.transform.gameObject;
                    objPlane = new Plane(Camera.main.transform.forward * -1, gobj.transform.position);
                    Ray mRay = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                    float rayDistance;
                    objPlane.Raycast(mRay, out rayDistance);
                    m0 = gobj.transform.position - mRay.GetPoint(rayDistance);
                }
            }

            //si un doigt a déplacé sur l'écran
            else if (Input.GetTouch(0).phase == TouchPhase.Moved && gobj)
            {

                Ray mRay = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                float rayDistance;

                //Si la pièce n'est pas dans la bonne position déplacer la pièce
                if (gobj.transform.localPosition != rightPosition )
                {
                    if (objPlane.Raycast(mRay, out rayDistance))
                    {
                        //activer le son
                        source.PlayOneShot(clip);
                        //déplacer la pièce
                        gobj.transform.position = mRay.GetPoint(rayDistance) + m0;
                    }
                }
            }

            //si un doigt a été levé de l'écran
            else if (Input.GetTouch(0).phase == TouchPhase.Ended && gobj)
            {
                gobj = null;
            }  
    }



    }
}
