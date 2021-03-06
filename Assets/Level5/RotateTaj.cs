﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTaj: MonoBehaviour
{
    public GameObject gobj;
    public AudioSource source;
    public AudioClip clip;
    Plane objPlane;
    int counter = 0, y = 90;
    public float clickTimer = 3;
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
                    clickTimer = 3;
                    counter++;

                }



            }

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
        if (counter % 2 == 0)
        {
            if (clickTimer >= 0)

            {
                if (gobj.transform.localRotation != Quaternion.Euler((float)-90.00001, 0, (float)90.00001))

                {
                    gobj.transform.localRotation = Quaternion.Euler((float)-90.00001, (float)y, (float)90.00001);
                    source.PlayOneShot(clip);
                    y = y + 90;
                }
            }
        }

    }
}
