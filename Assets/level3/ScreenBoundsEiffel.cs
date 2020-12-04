using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenBoundsEiffel : MonoBehaviour
{
    public GameObject gobj, gobj1, gobj2, gobj3, gobj4, gobj5, gobj6, gobj7, gobj8, gobj9, gobj10;
    void Update()
    {
        //pièce 1
        if ((gobj.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0))){ 
        gobj.transform.localPosition = new Vector3(Mathf.Clamp(gobj.transform.localPosition.x, (float)-2.17, (float)2.72),
        Mathf.Clamp(gobj.transform.localPosition.y, (float)-1.4, (float)0.9), gobj.transform.localPosition.z);
        }
        else
        {
            if ((gobj.transform.localRotation == Quaternion.Euler((float)-89.98, 90, 0))){
                gobj.transform.localPosition = new Vector3(Mathf.Clamp(gobj.transform.localPosition.x, (float)-2.75, (float)3.84),
                Mathf.Clamp(gobj.transform.localPosition.y, (float)-1.4, (float)1.42), gobj.transform.localPosition.z);
            }
            else
            {
                if ((gobj.transform.localRotation == Quaternion.Euler((float)-89.98, 180, 0))){
                    gobj.transform.localPosition = new Vector3(Mathf.Clamp(gobj.transform.localPosition.x, (float)-3.86, (float)3.27),
                    Mathf.Clamp(gobj.transform.localPosition.y, (float)-1.4, (float)1.62), gobj.transform.localPosition.z);
                }
                else
                {
                    if ((gobj.transform.localRotation == Quaternion.Euler((float)-89.98, 270, 0))){
                        gobj.transform.localPosition = new Vector3(Mathf.Clamp(gobj.transform.localPosition.x, (float)-3.27, (float)2.16),
                        Mathf.Clamp(gobj.transform.localPosition.y, (float)-1.4, (float)1.03), gobj.transform.localPosition.z);
                    }
                }
            }
        }


        //pièce 2
        if ((gobj1.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)))
        {
            gobj1.transform.localPosition = new Vector3(Mathf.Clamp(gobj1.transform.localPosition.x, (float)-2.15, (float)2.71),
            Mathf.Clamp(gobj1.transform.localPosition.y, (float)-1.74, (float)0.58), gobj1.transform.localPosition.z);
        }
        else {
            if ((gobj1.transform.localRotation == Quaternion.Euler((float)-89.98, 90, 0)))
            {
                gobj1.transform.localPosition = new Vector3(Mathf.Clamp(gobj1.transform.localPosition.x, (float)-2.74, (float)3.84),
                Mathf.Clamp(gobj1.transform.localPosition.y, (float)-1.74, (float)1.14), gobj1.transform.localPosition.z);
            }
            else
            {
                if ((gobj1.transform.localRotation == Quaternion.Euler((float)-89.98, 180, 0)))
                {
                    gobj1.transform.localPosition = new Vector3(Mathf.Clamp(gobj1.transform.localPosition.x, (float)-3.85, (float)3.26),
                    Mathf.Clamp(gobj1.transform.localPosition.y, (float)-1.74, (float)1.32), gobj1.transform.localPosition.z);
                }
                else
                {
                    if ((gobj1.transform.localRotation == Quaternion.Euler((float)-89.98, 270, 0)))
                    {
                        gobj1.transform.localPosition = new Vector3(Mathf.Clamp(gobj1.transform.localPosition.x, (float)-3.25, (float)2.15),
                        Mathf.Clamp(gobj1.transform.localPosition.y, (float)-1.74, (float)0.76), gobj1.transform.localPosition.z);
                    }
                }
            }
        }


        //pièce 3
        if ((gobj2.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)))
        {
            gobj2.transform.localPosition = new Vector3(Mathf.Clamp(gobj2.transform.localPosition.x, (float)-2.05, (float)3.35),
            Mathf.Clamp(gobj2.transform.localPosition.y, (float)0.4781862,3), gobj2.transform.localPosition.z);
        }
        else
        {
            if ((gobj2.transform.localRotation == Quaternion.Euler((float)-89.98, 90, 0)))
            {
                gobj2.transform.localPosition = new Vector3(Mathf.Clamp(gobj2.transform.localPosition.x,(float)-3.38, (float)3.75),
                Mathf.Clamp(gobj2.transform.localPosition.y, (float)0.4781862, (float)3.6), gobj2.transform.localPosition.z);
            }
            else
            {
                if ((gobj2.transform.localRotation == Quaternion.Euler((float)-89.98,180, 0)))
                {
                    gobj2.transform.localPosition = new Vector3(Mathf.Clamp(gobj2.transform.localPosition.x,(float)-3.74, (float)2.33),
                    Mathf.Clamp(gobj2.transform.localPosition.y, (float)0.4781862, (float)3.4), gobj2.transform.localPosition.z);
                }
                else
                {
                    if ((gobj2.transform.localRotation == Quaternion.Euler((float)-89.98, 270, 0)))
                    {
                        gobj2.transform.localPosition = new Vector3(Mathf.Clamp(gobj2.transform.localPosition.x,(float)-2.33, (float)2.01),
                        Mathf.Clamp(gobj2.transform.localPosition.y, (float)0.4781862, (float)2.82), gobj2.transform.localPosition.z);
                    }
                }
            }
        }


        //pièce 4
        if ((gobj3.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)))
        {
            gobj3.transform.localPosition = new Vector3(Mathf.Clamp(gobj3.transform.localPosition.x, (float)-2.1, (float)2.66),
            Mathf.Clamp(gobj3.transform.localPosition.y, (float)-0.9,(float)1.3), gobj3.transform.localPosition.z);
        }
        else
        {
            if ((gobj3.transform.localRotation == Quaternion.Euler((float)-89.98, 90, 0)))
            {
                gobj3.transform.localPosition = new Vector3(Mathf.Clamp(gobj3.transform.localPosition.x,(float)-2.71, (float)3.8),
                Mathf.Clamp(gobj3.transform.localPosition.y, (float)-0.9,(float) 1.91), gobj3.transform.localPosition.z);
            }
            else
            {
                if ((gobj3.transform.localRotation == Quaternion.Euler((float)-89.98, 180, 0)))
                {
                    gobj3.transform.localPosition = new Vector3(Mathf.Clamp(gobj3.transform.localPosition.x,(float)-3.8, (float)3.23),
                    Mathf.Clamp(gobj3.transform.localPosition.y, (float)-0.95, (float)2.1), gobj3.transform.localPosition.z);
                }
                else
                {
                    if ((gobj3.transform.localRotation == Quaternion.Euler((float)-89.98, 270, 0)))
                    {
                        gobj3.transform.localPosition = new Vector3(Mathf.Clamp(gobj3.transform.localPosition.x,(float)-3.21, (float)2.09),
                        Mathf.Clamp(gobj3.transform.localPosition.y, (float)-0.95, (float)1.5), gobj3.transform.localPosition.z);
                    }
                }
            }
        }


        //pièce 5
        if ((gobj4.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)))
        {
            gobj4.transform.localPosition = new Vector3(Mathf.Clamp(gobj4.transform.localPosition.x, (float)-1.99, (float)2.55),
            Mathf.Clamp(gobj4.transform.localPosition.y, (float)-0.45,(float)1.68), gobj4.transform.localPosition.z);
        }
        else
        {
            if ((gobj4.transform.localRotation == Quaternion.Euler((float)-89.98, 90, 0)))
            {
                gobj4.transform.localPosition = new Vector3(Mathf.Clamp(gobj4.transform.localPosition.x,(float)-2.59, (float)3.72),
                Mathf.Clamp(gobj4.transform.localPosition.y, (float)-0.45,(float)2.25), gobj4.transform.localPosition.z);
            }
            else
            {
                if ((gobj4.transform.localRotation == Quaternion.Euler((float)-89.98, 180, 0)))
                {
                    gobj4.transform.localPosition = new Vector3(Mathf.Clamp(gobj4.transform.localPosition.x,(float)-3.75, (float)3.15),
                    Mathf.Clamp(gobj4.transform.localPosition.y, (float)-0.45,(float) 2.4), gobj4.transform.localPosition.z);
                }
                else
                {
                    if ((gobj4.transform.localRotation == Quaternion.Euler((float)-89.98, 270, 0)))
                    {
                        gobj4.transform.localPosition = new Vector3(Mathf.Clamp(gobj4.transform.localPosition.x, (float)-3.13, 2),
                        Mathf.Clamp(gobj4.transform.localPosition.y, (float)-0.45, (float)1.85), gobj4.transform.localPosition.z);
                    }
                }
            }
        }


        //pièce 6
        if ((gobj5.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)))
        {
            gobj5.transform.localPosition = new Vector3(Mathf.Clamp(gobj5.transform.localPosition.x,(float) -1.2, (float)2.59),
            Mathf.Clamp(gobj5.transform.localPosition.y, (float)0.4781862,(float)2.65), gobj5.transform.localPosition.z);
        }
        else
        {
            if ((gobj5.transform.localRotation == Quaternion.Euler((float)-89.98, 90, 0)))
            {
                gobj5.transform.localPosition = new Vector3(Mathf.Clamp(gobj5.transform.localPosition.x, (float)-2.65, (float)4.49),
                Mathf.Clamp(gobj5.transform.localPosition.y, (float)0.4781862,(float)3.6), gobj5.transform.localPosition.z);
            }
            else
            {
                if ((gobj5.transform.localRotation == Quaternion.Euler((float)-89.98, 180, 0)))
                {
                    gobj5.transform.localPosition = new Vector3(Mathf.Clamp(gobj5.transform.localPosition.x,(float)-4.55, (float)3.18),
                    Mathf.Clamp(gobj5.transform.localPosition.y, (float)0.4781862,(float) 3.8), gobj5.transform.localPosition.z);
                }
                else
                {
                    if ((gobj5.transform.localRotation == Quaternion.Euler((float)-89.98, 270, 0)))
                    {
                        gobj5.transform.localPosition = new Vector3(Mathf.Clamp(gobj5.transform.localPosition.x,(float)-3.15, (float)1.19),
                        Mathf.Clamp(gobj5.transform.localPosition.y, (float)0.4781862, (float)2.82), gobj5.transform.localPosition.z);
                    }
                }
            }
        }


        //pièce 7
        if ((gobj6.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)))
        {
            gobj6.transform.localPosition = new Vector3(Mathf.Clamp(gobj6.transform.localPosition.x,(float)-1.63, (float)2.2),
            Mathf.Clamp(gobj6.transform.localPosition.y, (float)0.2,(float) 2.44), gobj6.transform.localPosition.z);
        }
        else
        {
            if ((gobj6.transform.localRotation == Quaternion.Euler((float)-89.98, 90, 0)))
            {
                gobj6.transform.localPosition = new Vector3(Mathf.Clamp(gobj6.transform.localPosition.x,(float)-2.24, (float)3.36),
                Mathf.Clamp(gobj6.transform.localPosition.y, (float)0.2,(float)3.04), gobj6.transform.localPosition.z);
            }
            else
            {
                if ((gobj6.transform.localRotation == Quaternion.Euler((float)-89.98, 180, 0)))
                {
                    gobj6.transform.localPosition = new Vector3(Mathf.Clamp(gobj6.transform.localPosition.x,(float)-3.37, (float)2.69),
                    Mathf.Clamp(gobj6.transform.localPosition.y, (float)0.2,(float)3.24), gobj6.transform.localPosition.z);
                }
                else
                {
                    if ((gobj6.transform.localRotation == Quaternion.Euler((float)-89.98, 270, 0)))
                    {
                        gobj6.transform.localPosition = new Vector3(Mathf.Clamp(gobj6.transform.localPosition.x,(float)-2.7, (float)1.61),
                        Mathf.Clamp(gobj6.transform.localPosition.y, (float)0.2,(float)2.63), gobj6.transform.localPosition.z);
                    }
                }
            }
        }


        //pièce8
        if ((gobj7.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)))
        {
            gobj7.transform.localPosition = new Vector3(Mathf.Clamp(gobj7.transform.localPosition.x,(float)-2.13, (float)2.66),
            Mathf.Clamp(gobj7.transform.localPosition.y, (float)-1.2, (float)1.2), gobj7.transform.localPosition.z);
        }
        else
        {
            if ((gobj7.transform.localRotation == Quaternion.Euler((float)-89.98, 90, 0)))
            {
                gobj7.transform.localPosition = new Vector3(Mathf.Clamp(gobj7.transform.localPosition.x, (float)-2.73, (float)3.83),
                Mathf.Clamp(gobj7.transform.localPosition.y, (float)-1.2, (float)1.76), gobj7.transform.localPosition.z);
            }
            else
            {
                if ((gobj7.transform.localRotation == Quaternion.Euler((float)-89.98,180, 0)))
                {
                    gobj7.transform.localPosition = new Vector3(Mathf.Clamp(gobj7.transform.localPosition.x,(float)-3.84, (float)3.25),
                    Mathf.Clamp(gobj7.transform.localPosition.y, (float)-1.2,(float)1.95), gobj7.transform.localPosition.z);
                }
                else
                {
                    if ((gobj7.transform.localRotation == Quaternion.Euler((float)-89.98,270, 0)))
                    {
                        gobj7.transform.localPosition = new Vector3(Mathf.Clamp(gobj7.transform.localPosition.x,(float)-3.23, (float)2.1),
                        Mathf.Clamp(gobj7.transform.localPosition.y, (float)-1.2,(float)1.38), gobj7.transform.localPosition.z);
                    }
                }
            }

        }

        //pièce9
        if ((gobj8.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)))
        {
            gobj8.transform.localPosition = new Vector3(Mathf.Clamp(gobj8.transform.localPosition.x,(float)-1.79, (float)2.31),
            Mathf.Clamp(gobj8.transform.localPosition.y, (float)0.1,(float) 2.12), gobj8.transform.localPosition.z);
        }
        else
        {
            if ((gobj8.transform.localRotation == Quaternion.Euler((float)-89.98, 90, 0)))
            {
                gobj8.transform.localPosition = new Vector3(Mathf.Clamp(gobj8.transform.localPosition.x,(float)-2.36, (float)3.48),
                Mathf.Clamp(gobj8.transform.localPosition.y, (float)0.1,(float) 2.65), gobj8.transform.localPosition.z);
            }
            else
            {
                if ((gobj8.transform.localRotation == Quaternion.Euler((float)-89.98, 180, 0)))
                {
                    gobj8.transform.localPosition = new Vector3(Mathf.Clamp(gobj8.transform.localPosition.x,(float)-3.48, (float)2.9),
                    Mathf.Clamp(gobj8.transform.localPosition.y, (float)0.1, (float)2.83), gobj8.transform.localPosition.z);
                }
                else
                {
                    if ((gobj8.transform.localRotation == Quaternion.Euler((float)-89.98, 270, 0)))
                    {
                        gobj8.transform.localPosition = new Vector3(Mathf.Clamp(gobj8.transform.localPosition.x,(float)-2.9, (float)1.77),
                        Mathf.Clamp(gobj8.transform.localPosition.y, (float)0.1,(float)2.24), gobj8.transform.localPosition.z);
                    }
                }
            }
        }

        //pièce10
        if ((gobj9.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)))
        {
            gobj9.transform.localPosition = new Vector3(Mathf.Clamp(gobj9.transform.localPosition.x,(float)-1.54, (float)2.1),
            Mathf.Clamp(gobj9.transform.localPosition.y, (float)0.2, (float)2.58), gobj9.transform.localPosition.z);
        }
        else
        {
            if ((gobj9.transform.localRotation == Quaternion.Euler((float)-89.98, 90, 0)))
            {
                gobj9.transform.localPosition = new Vector3(Mathf.Clamp(gobj9.transform.localPosition.x,(float) -2.15, (float)3.24),
                Mathf.Clamp(gobj9.transform.localPosition.y, (float)0.2, (float)3.15), gobj9.transform.localPosition.z);
            }
            else
            {
                if ((gobj9.transform.localRotation == Quaternion.Euler((float)-89.98, 180, 0)))
                {
                    gobj9.transform.localPosition = new Vector3(Mathf.Clamp(gobj9.transform.localPosition.x,(float)-3.26, (float)2.7),
                    Mathf.Clamp(gobj9.transform.localPosition.y, (float)0.2,(float) 3.34), gobj9.transform.localPosition.z);
                }
                else
                {
                    if ((gobj9.transform.localRotation == Quaternion.Euler((float)-89.98, 270, 0)))
                    {
                        gobj9.transform.localPosition = new Vector3(Mathf.Clamp(gobj9.transform.localPosition.x,(float)-2.7, (float)1.52),
                        Mathf.Clamp(gobj9.transform.localPosition.y, (float)0.2,(float)2.76), gobj9.transform.localPosition.z);
                    }
                }
            }
        }


        //pièce11
        if ((gobj10.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)))
        {
            gobj10.transform.localPosition = new Vector3(Mathf.Clamp(gobj10.transform.localPosition.x,(float)-2.02, (float)1.77),
            Mathf.Clamp(gobj10.transform.localPosition.y, (float)0.4781862, (float)2.63), gobj10.transform.localPosition.z);
        }
        else
        {
            if ((gobj10.transform.localRotation == Quaternion.Euler((float)-89.98, 90, 0)))
            {
                gobj10.transform.localPosition = new Vector3(Mathf.Clamp(gobj10.transform.localPosition.x,(float)-1.81, (float)3.73),
                Mathf.Clamp(gobj10.transform.localPosition.y, (float)0.4781862,(float)3.22), gobj10.transform.localPosition.z);
            }
            else
            {
                if ((gobj10.transform.localRotation == Quaternion.Euler((float)-89.98, 180, 0)))
                {
                    gobj10.transform.localPosition = new Vector3(Mathf.Clamp(gobj10.transform.localPosition.x,(float)-3.78, (float)3.89),
                    Mathf.Clamp(gobj10.transform.localPosition.y, (float)0.4781862,(float)3.75), gobj10.transform.localPosition.z);
                }
                else
                {
                    if ((gobj10.transform.localRotation == Quaternion.Euler((float)-89.98, 270, 0)))
                    {
                        gobj10.transform.localPosition = new Vector3(Mathf.Clamp(gobj10.transform.localPosition.x,(float)-3.85, (float)2.03),
                        Mathf.Clamp(gobj10.transform.localPosition.y, (float)0.4781862,(float) 3.2), gobj10.transform.localPosition.z);
                    }
                }
            }
        }
    }
}
