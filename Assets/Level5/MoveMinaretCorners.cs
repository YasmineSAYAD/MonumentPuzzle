using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMinaretCorners : MonoBehaviour
{
    public GameObject gobj;
    public AudioSource source;
    public AudioClip clip;
    Plane objPlane;
    Vector3 m0;

    Ray GenerateMouseRay(Vector3 touchPos)
    {
        Vector3 mousePosFar = new Vector3(touchPos.x, touchPos.y, Camera.main.farClipPlane);
        Vector3 mousePosNear = new Vector3(touchPos.x, touchPos.y, Camera.main.nearClipPlane);
        Vector3 mousePosF = Camera.main.ScreenToWorldPoint(mousePosFar);
        Vector3 mousePosN = Camera.main.ScreenToWorldPoint(mousePosNear);
        Ray mr = new Ray(mousePosN, mousePosF - mousePosN);
        return mr;

    }

    void Start()
    {

    }

    void Update()
    {
        if (Input.touchCount > 0)


        {

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
            else if (Input.GetTouch(0).phase == TouchPhase.Moved && gobj)
            {

                Ray mRay = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                float rayDistance;
                if (gobj.transform.localPosition != new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702))
                {
                    if (objPlane.Raycast(mRay, out rayDistance))
                        source.PlayOneShot(clip);
                    gobj.transform.position = mRay.GetPoint(rayDistance) + m0;

                }
            }

            else if (Input.GetTouch(0).phase == TouchPhase.Ended && gobj)
            {
                gobj = null;
            }


        }



    }
}
