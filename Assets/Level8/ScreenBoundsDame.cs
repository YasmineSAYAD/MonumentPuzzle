using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenBoundsDame : MonoBehaviour
{
    public GameObject gobj, gobj1, gobj2, gobj3, gobj4, gobj5, gobj6, gobj7, gobj8, gobj9, gobj10, gobj11, gobj12, gobj13, gobj14,
                       gobj15, gobj16, gobj17, gobj18, gobj19, gobj20, gobj21, gobj22, gobj23, gobj24, gobj25, gobj26, gobj27,
                       gobj28, gobj29, gobj30, gobj31, gobj32, gobj33, gobj34, gobj35, gobj36, gobj37, gobj38, gobj39, gobj40,
                       gobj41, gobj42, gobj43, gobj44, gobj45, gobj46, gobj47, gobj48, gobj49, gobj50, gobj51, gobj52, gobj53,
                       gobj54, gobj55, gobj56, gobj57, gobj58, gobj59, gobj60, gobj61, gobj62, gobj63, gobj64, gobj65, gobj66,
                       gobj67, gobj68;

    void Update()
    {
        //pièce 1
        if ((gobj.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj.transform.localPosition = new Vector3(Mathf.Clamp(gobj.transform.localPosition.x, -480, 111), gobj.transform.localPosition.y,
            Mathf.Clamp(gobj.transform.localPosition.z, 0, 73));
        }
        else
        {
            if ((gobj.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj.transform.localPosition = new Vector3(Mathf.Clamp(gobj.transform.localPosition.x, -204, 74), gobj.transform.localPosition.y,
                Mathf.Clamp(gobj.transform.localPosition.z, -5, 198));
            }
            else
            {
                if ((gobj.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj.transform.localPosition = new Vector3(Mathf.Clamp(gobj.transform.localPosition.x, -195, 230), gobj.transform.localPosition.y,
                    Mathf.Clamp(gobj.transform.localPosition.z, -5, 170));
                }
                else
                {
                    if ((gobj.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj.transform.localPosition = new Vector3(Mathf.Clamp(gobj.transform.localPosition.x, -202, 257), gobj.transform.localPosition.y,
                        Mathf.Clamp(gobj.transform.localPosition.z, -5, 198));
                    }
                }


            }

        }
    }
    }
