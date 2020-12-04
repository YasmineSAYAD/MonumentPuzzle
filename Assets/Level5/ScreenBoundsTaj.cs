using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenBoundsTaj : MonoBehaviour
{
    public GameObject gobj, gobj1, gobj2, gobj3, gobj4, gobj5, gobj6, gobj7, gobj8, gobj9, gobj10, gobj11, gobj12, gobj13, gobj14,
                     gobj15, gobj16, gobj17, gobj18, gobj19, gobj20, gobj21, gobj22, gobj23, gobj24, gobj25, gobj26;

    void Update()
    {
        //pièce 1
         gobj.transform.localPosition = new Vector3(Mathf.Clamp(gobj.transform.localPosition.x,(float)-23.7, 7),
         Mathf.Clamp(gobj.transform.localPosition.y, -8,(float) 3.5), gobj.transform.localPosition.z);

        //pièce 2
        if ((gobj1.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)))
        {
            gobj1.transform.localPosition = new Vector3(Mathf.Clamp(gobj1.transform.localPosition.x, (float)-22.7, (float)-2.6),
            Mathf.Clamp(gobj1.transform.localPosition.y, (float)-2.5, (float)2.26), gobj1.transform.localPosition.z);
        }
        else
        {
            if ((gobj1.transform.localRotation == Quaternion.Euler((float)-89.98, 90, 0)))
            {
                gobj1.transform.localPosition = new Vector3(Mathf.Clamp(gobj1.transform.localPosition.x, (float)-39.2, (float)10.7),
                Mathf.Clamp(gobj1.transform.localPosition.y, (float)-2.5, (float)6.55), gobj1.transform.localPosition.z);
            }
            else
            {
                if ((gobj1.transform.localRotation == Quaternion.Euler((float)-89.98, 180, 0)))
                {
                    gobj1.transform.localPosition = new Vector3(Mathf.Clamp(gobj1.transform.localPosition.x, (float)-6.5, (float)13.85),
                    Mathf.Clamp(gobj1.transform.localPosition.y, (float)-2.5, (float)2.3), gobj1.transform.localPosition.z);
                }
                else
                {
                    if ((gobj1.transform.localRotation == Quaternion.Euler((float)-89.98, 270, 0)))
                    {
                        gobj1.transform.localRotation = Quaternion.Euler((float)-89.98,0, 0);
                    }
                }
            }
        }


        //pièce 3
        if ((gobj2.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)))
        {
            gobj2.transform.localPosition = new Vector3(Mathf.Clamp(gobj2.transform.localPosition.x, (float)-47.5, (float)2.4),
            Mathf.Clamp(gobj2.transform.localPosition.y, (float)-2.527007, (float)6.5), gobj2.transform.localPosition.z);
        }
        else
        {
            if ((gobj2.transform.localRotation == Quaternion.Euler((float)-89.98, 90, 0)))
            {
                gobj2.transform.localPosition = new Vector3(Mathf.Clamp(gobj2.transform.localPosition.x,-31, (float)18.9),
                Mathf.Clamp(gobj2.transform.localPosition.y, (float)-2.527007, (float)6.5), gobj2.transform.localPosition.z);
            }
            else
            {
                if ((gobj2.transform.localRotation == Quaternion.Euler((float)-89.98, 180, 0)))
                {
                    gobj2.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                }
                else
                {
                    if ((gobj2.transform.localRotation == Quaternion.Euler((float)-89.98, 270, 0)))
                    {
                        gobj2.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                    }
                }
            }
        }

        //pièce 4
        if ((gobj3.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)))
        {
            gobj3.transform.localPosition = new Vector3(Mathf.Clamp(gobj3.transform.localPosition.x, (float)-39, (float)10.6),
            Mathf.Clamp(gobj3.transform.localPosition.y, (float)-2.527007, (float)6.5), gobj3.transform.localPosition.z);
        }
        else
        {
            if ((gobj3.transform.localRotation == Quaternion.Euler((float)-89.98, 90, 0)))
            {
                gobj3.transform.localPosition = new Vector3(Mathf.Clamp(gobj3.transform.localPosition.x,(float) -6.4, (float)13.85),
                Mathf.Clamp(gobj3.transform.localPosition.y, (float)-2.527007, (float)2.25), gobj3.transform.localPosition.z);
            }
            else
            {
                if ((gobj3.transform.localRotation == Quaternion.Euler((float)-89.98, 180, 0)))
                {
                     gobj3.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                }
                else
                {
                    if ((gobj3.transform.localRotation == Quaternion.Euler((float)-89.98, 270, 0)))
                    {
                         gobj3.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                    }
                }
            }
        }


        //pièce 5
        if ((gobj4.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)))
        {
            gobj4.transform.localPosition = new Vector3(Mathf.Clamp(gobj4.transform.localPosition.x, (float)-14.7, (float)5.65),
            Mathf.Clamp(gobj4.transform.localPosition.y, (float)-2.527007, (float)2.35), gobj4.transform.localPosition.z);
        }
        else
        {
            if ((gobj4.transform.localRotation == Quaternion.Euler((float)-89.98, 90, 0)))
            {
                gobj4.transform.localPosition = new Vector3(Mathf.Clamp(gobj4.transform.localPosition.x, (float)-6.4, (float)13.85),
                Mathf.Clamp(gobj4.transform.localPosition.y, (float)-2.527007, (float)2.25), gobj4.transform.localPosition.z);
            }
            else
            {
                if ((gobj4.transform.localRotation == Quaternion.Euler((float)-89.98, 180, 0)))
                {
                    gobj4.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                }
                else
                {
                    if ((gobj4.transform.localRotation == Quaternion.Euler((float)-89.98, 270, 0)))
                    {
                        gobj4.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                    }
                }
            }
        }

        //pièce 6
          gobj5.transform.localPosition = new Vector3(Mathf.Clamp(gobj5.transform.localPosition.x, -15, (float)5.7),
          Mathf.Clamp(gobj5.transform.localPosition.y, (float)-5.5, (float)-0.3), gobj5.transform.localPosition.z);

        //pièce 7
        gobj6.transform.localPosition = new Vector3(Mathf.Clamp(gobj6.transform.localPosition.x,(float) -14.8, (float)5.7),
        Mathf.Clamp(gobj6.transform.localPosition.y, (float)-4.4, (float)0.38), gobj6.transform.localPosition.z);

        //pièce 8
        gobj7.transform.localPosition = new Vector3(Mathf.Clamp(gobj7.transform.localPosition.x, (float)-14.8, (float)5.65),
        Mathf.Clamp(gobj7.transform.localPosition.y, (float)-3, (float)1.5), gobj7.transform.localPosition.z);

        //pièce 9
        if ((gobj8.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)))
        {
            gobj8.transform.localPosition = new Vector3(Mathf.Clamp(gobj8.transform.localPosition.x, -23, (float)-2.55),
            Mathf.Clamp(gobj8.transform.localPosition.y, (float)-5.5, (float)-0.3), gobj8.transform.localPosition.z);
        }
        else
        {
            if ((gobj8.transform.localRotation == Quaternion.Euler((float)-89.98, 90, 0)))
            {
               
                gobj8.transform.localRotation = Quaternion.Euler((float)-89.98, 180, 0);
            }
            else
            {
                if ((gobj8.transform.localRotation == Quaternion.Euler((float)-89.98, 180, 0)))
                {
                    gobj8.transform.localPosition = new Vector3(Mathf.Clamp(gobj8.transform.localPosition.x, (float)-6.7, (float)13.9),
                    Mathf.Clamp(gobj8.transform.localPosition.y, (float)-5.5, (float)-0.25), gobj8.transform.localPosition.z);
                }
                else
                {
                    if ((gobj8.transform.localRotation == Quaternion.Euler((float)-89.98, 270, 0)))
                    {
                        gobj8.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                    }
                }
            }
        }


        //pièce 10
        if ((gobj9.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)))
        {
            gobj9.transform.localPosition = new Vector3(Mathf.Clamp(gobj9.transform.localPosition.x,-23, (float)-2.6),
            Mathf.Clamp(gobj9.transform.localPosition.y, (float)-4.4, (float)0.35), gobj9.transform.localPosition.z);
        }
        else
        {
            if ((gobj9.transform.localRotation == Quaternion.Euler((float)-89.98, 90, 0)))
            {
                gobj9.transform.localPosition = new Vector3(Mathf.Clamp(gobj9.transform.localPosition.x, (float)-39.5, (float)10.7),
                Mathf.Clamp(gobj9.transform.localPosition.y, (float)-4.4, (float)4.6), gobj9.transform.localPosition.z);
            }
            else
            {
                if ((gobj9.transform.localRotation == Quaternion.Euler((float)-89.98, 180, 0)))
                {
                    gobj9.transform.localPosition = new Vector3(Mathf.Clamp(gobj9.transform.localPosition.x, (float)-6.6, (float)13.9),
                    Mathf.Clamp(gobj9.transform.localPosition.y, (float)-4.4, (float)0.4), gobj9.transform.localPosition.z);
                }
           
                else
                {
                    if ((gobj9.transform.localRotation == Quaternion.Euler((float)-89.98, 270, 0)))
                    {
                        gobj9.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                    }
                }
            }
        }

        //pièce 11
        if ((gobj10.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)))
        {
            gobj10.transform.localPosition = new Vector3(Mathf.Clamp(gobj10.transform.localPosition.x, (float)-22.9, (float)-2.58),
            Mathf.Clamp(gobj10.transform.localPosition.y, (float)-3.52, (float)1.5), gobj10.transform.localPosition.z);
        }
        else
        {
            if ((gobj10.transform.localRotation == Quaternion.Euler((float)-89.98, 90, 0)))
            {
                gobj10.transform.localPosition = new Vector3(Mathf.Clamp(gobj10.transform.localPosition.x, (float)-39.5, (float)10.7),
                Mathf.Clamp(gobj10.transform.localPosition.y, (float)-3.52, (float)5.7), gobj10.transform.localPosition.z);
            }
            else
            {
                if ((gobj10.transform.localRotation == Quaternion.Euler((float)-89.98, 180, 0)))
                {
                    gobj10.transform.localPosition = new Vector3(Mathf.Clamp(gobj10.transform.localPosition.x, (float)-6.6, (float)13.92),
                    Mathf.Clamp(gobj10.transform.localPosition.y, (float)-3.52, (float)1.5), gobj10.transform.localPosition.z);
                }

                else
                {
                    if ((gobj10.transform.localRotation == Quaternion.Euler((float)-89.98, 270, 0)))
                    {
                        gobj10.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                    }
                }
            }
        }

        //pièce 12
        if ((gobj11.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)))
        {
            gobj11.transform.localPosition = new Vector3(Mathf.Clamp(gobj11.transform.localPosition.x, (float)-47.5, (float)2.55),
            Mathf.Clamp(gobj11.transform.localPosition.y, (float)-5.5, 4), gobj11.transform.localPosition.z);
        }
        else
        {
            if ((gobj11.transform.localRotation == Quaternion.Euler((float)-89.98, 90, 0)))
            {
                gobj11.transform.localPosition = new Vector3(Mathf.Clamp(gobj11.transform.localPosition.x, -31, (float)19.1),
                Mathf.Clamp(gobj11.transform.localPosition.y, (float)-5.5, (float)3.8), gobj11.transform.localPosition.z);
            }
            else
            {
                if ((gobj11.transform.localRotation == Quaternion.Euler((float)-89.98, 180, 0)))
                {
                    gobj11.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                }

                else
                {
                    if ((gobj11.transform.localRotation == Quaternion.Euler((float)-89.98, 270, 0)))
                    {
                        gobj11.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                    }
                }
            }
        }

        //pièce 13
        if ((gobj12.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)))
        {
            gobj12.transform.localPosition = new Vector3(Mathf.Clamp(gobj12.transform.localPosition.x, (float)-47.5, (float)2.55),
            Mathf.Clamp(gobj12.transform.localPosition.y, (float)-4.4,(float) 4.7), gobj12.transform.localPosition.z);
        }
        else
        {
            if ((gobj12.transform.localRotation == Quaternion.Euler((float)-89.98, 90, 0)))
            {
                gobj12.transform.localPosition = new Vector3(Mathf.Clamp(gobj12.transform.localPosition.x, -31, 19),
                Mathf.Clamp(gobj12.transform.localPosition.y, (float)-4.4, (float)4.6), gobj12.transform.localPosition.z);
            }
            else
            {
                if ((gobj12.transform.localRotation == Quaternion.Euler((float)-89.98, 180, 0)))
                {
                    gobj12.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                }

                else
                {
                    if ((gobj12.transform.localRotation == Quaternion.Euler((float)-89.98, 270, 0)))
                    {
                        gobj12.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                    }
                }
            }
        }


        //pièce 14
        if ((gobj13.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)))
        {
            gobj13.transform.localPosition = new Vector3(Mathf.Clamp(gobj13.transform.localPosition.x, (float)-47.5, (float)2.5),
            Mathf.Clamp(gobj13.transform.localPosition.y, (float)-3.5, (float)5.7), gobj13.transform.localPosition.z);
        }
        else
        {
            if ((gobj13.transform.localRotation == Quaternion.Euler((float)-89.98, 90, 0)))
            {
                gobj13.transform.localPosition = new Vector3(Mathf.Clamp(gobj13.transform.localPosition.x, -31, 19),
                Mathf.Clamp(gobj13.transform.localPosition.y, (float)-3.5, (float)5.7), gobj13.transform.localPosition.z);
            }
            else
            {
                if ((gobj13.transform.localRotation == Quaternion.Euler((float)-89.98, 180, 0)))
                {
                    gobj13.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                }

                else
                {
                    if ((gobj13.transform.localRotation == Quaternion.Euler((float)-89.98, 270, 0)))
                    {
                        gobj13.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                    }
                }
            }
        }

        //pièce 15
        if ((gobj14.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)))
        {
            gobj14.transform.localPosition = new Vector3(Mathf.Clamp(gobj14.transform.localPosition.x, (float)-39.5, (float)10.8),
            Mathf.Clamp(gobj14.transform.localPosition.y, (float)-5.4, 4), gobj14.transform.localPosition.z);
        }
        else
        {
            if ((gobj14.transform.localRotation == Quaternion.Euler((float)-89.98, 90, 0)))
            {
                gobj14.transform.localPosition = new Vector3(Mathf.Clamp(gobj14.transform.localPosition.x, (float)13.9,(float)-6.7),
                Mathf.Clamp(gobj14.transform.localPosition.y, (float)-5.4, (float)-0.3), gobj14.transform.localPosition.z);
            }
            else
            {
                if ((gobj14.transform.localRotation == Quaternion.Euler((float)-89.98, 180, 0)))
                {
                    gobj14.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                }

                else
                {
                    if ((gobj14.transform.localRotation == Quaternion.Euler((float)-89.98, 270, 0)))
                    {
                        gobj14.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                    }
                }
            }
        }


        //pièce 16
        if ((gobj15.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)))
        {
            gobj15.transform.localPosition = new Vector3(Mathf.Clamp(gobj15.transform.localPosition.x, (float)-39.5, (float)10.7),
            Mathf.Clamp(gobj15.transform.localPosition.y, (float)-4.4,(float) 4.65), gobj15.transform.localPosition.z);
        }
        else
        {
            if ((gobj15.transform.localRotation == Quaternion.Euler((float)-89.98, 90, 0)))
            {
                gobj15.transform.localPosition = new Vector3(Mathf.Clamp(gobj15.transform.localPosition.x,(float)-6.7,(float)13.9),
                Mathf.Clamp(gobj15.transform.localPosition.y, (float)-4.4, (float)0.4), gobj15.transform.localPosition.z);
            }
            else
            {
                if ((gobj15.transform.localRotation == Quaternion.Euler((float)-89.98, 180, 0)))
                {
                    gobj15.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                }

                else
                {
                    if ((gobj15.transform.localRotation == Quaternion.Euler((float)-89.98, 270, 0)))
                    {
                        gobj15.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                    }
                }
            }
        }

        //pièce 17
        if ((gobj16.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)))
        {
            gobj16.transform.localPosition = new Vector3(Mathf.Clamp(gobj16.transform.localPosition.x, (float)-39.3, (float)10.74),
            Mathf.Clamp(gobj16.transform.localPosition.y, (float)-3.5, (float)5.7), gobj16.transform.localPosition.z);
        }
        else
        {
            if ((gobj16.transform.localRotation == Quaternion.Euler((float)-89.98, 90, 0)))
            {
                gobj16.transform.localPosition = new Vector3(Mathf.Clamp(gobj16.transform.localPosition.x,(float)-6.7, (float)13.9),
                Mathf.Clamp(gobj16.transform.localPosition.y, (float)-3.5, (float)1.5), gobj16.transform.localPosition.z);
            }
            else
            {
                if ((gobj16.transform.localRotation == Quaternion.Euler((float)-89.98, 180, 0)))
                {
                    gobj16.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                }

                else
                {
                    if ((gobj16.transform.localRotation == Quaternion.Euler((float)-89.98, 270, 0)))
                    {
                        gobj16.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                    }
                }
            }
        }

        //pièce 18
        if ((gobj17.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)))
        {
            gobj17.transform.localPosition = new Vector3(Mathf.Clamp(gobj17.transform.localPosition.x, (float)-27.9, (float)11.5),
            Mathf.Clamp(gobj17.transform.localPosition.y, -3, (float)5.45), gobj17.transform.localPosition.z);
        }
        else
        {
            if ((gobj17.transform.localRotation == Quaternion.Euler((float)-89.98, 90, 0)))
            {
                gobj17.transform.localPosition = new Vector3(Mathf.Clamp(gobj17.transform.localPosition.x, (float)-11.8, (float)8.28),
                Mathf.Clamp(gobj17.transform.localPosition.y, -3, (float)2.65), gobj17.transform.localPosition.z);
            }
            else
            {
                if ((gobj17.transform.localRotation == Quaternion.Euler((float)-89.98, 180, 0)))
                {
                    gobj17.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                }

                else
                {
                    if ((gobj17.transform.localRotation == Quaternion.Euler((float)-89.98, 270, 0)))
                    {
                        gobj17.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                    }
                }
            }
        }

        //pièce 19
        if ((gobj18.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)))
        {
            gobj18.transform.localPosition = new Vector3(Mathf.Clamp(gobj18.transform.localPosition.x, (float)-30.7, (float)8.8),
            Mathf.Clamp(gobj18.transform.localPosition.y, -3, (float)5.4), gobj18.transform.localPosition.z);
        }
        else
        {
            if ((gobj18.transform.localRotation == Quaternion.Euler((float)-89.98, 90, 0)))
            {
                gobj18.transform.localPosition = new Vector3(Mathf.Clamp(gobj18.transform.localPosition.x, (float)-19.9, (float)9.9),
                Mathf.Clamp(gobj18.transform.localPosition.y, -3, 4), gobj18.transform.localPosition.z);
            }
            else
            {
                if ((gobj18.transform.localRotation == Quaternion.Euler((float)-89.98, 180, 0)))
                {
                    gobj18.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                }

                else
                {
                    if ((gobj18.transform.localRotation == Quaternion.Euler((float)-89.98, 270, 0)))
                    {
                        gobj18.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                    }
                }
            }
        }

        //pièce 20
        if ((gobj19.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)))
        {
            gobj19.transform.localPosition = new Vector3(Mathf.Clamp(gobj19.transform.localPosition.x, (float)-20.25, (float)9.95),
            Mathf.Clamp(gobj19.transform.localPosition.y, -1, (float)4.15), gobj19.transform.localPosition.z);
        }
        else
        {
            if ((gobj19.transform.localRotation == Quaternion.Euler((float)-89.98, 90, 0)))
            {
                gobj19.transform.localPosition = new Vector3(Mathf.Clamp(gobj19.transform.localPosition.x, (float)-14.3, (float)5.7),
                Mathf.Clamp(gobj19.transform.localPosition.y, -1,(float) 2.68), gobj19.transform.localPosition.z);
            }
            else
            {
                if ((gobj19.transform.localRotation == Quaternion.Euler((float)-89.98, 180, 0)))
                {
                    gobj19.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                }

                else
                {
                    if ((gobj19.transform.localRotation == Quaternion.Euler((float)-89.98, 270, 0)))
                    {
                        gobj19.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                    }
                }
            }
        }


        //pièce 21
        gobj20.transform.localPosition = new Vector3(Mathf.Clamp(gobj20.transform.localPosition.x, (float)-22.45, (float)7.2),
        Mathf.Clamp(gobj20.transform.localPosition.y, -3, (float)4.05), gobj20.transform.localPosition.z);

        //pièce 22
        if ((gobj21.transform.localRotation == Quaternion.Euler((float)-90.00001, 0, (float)-90.00001)))
        {
            gobj21.transform.localPosition = new Vector3(Mathf.Clamp(gobj21.transform.localPosition.x,-20, (float)8.17),
            Mathf.Clamp(gobj21.transform.localPosition.y,(float) -1.551666, (float)3.8), gobj21.transform.localPosition.z);
        }
        else
        {
            if ((gobj21.transform.localRotation == Quaternion.Euler((float)-90.00001, 90, (float)-90.00001)))
            {
                gobj21.transform.localPosition = new Vector3(Mathf.Clamp(gobj21.transform.localPosition.x, (float)-15.1, (float)4.83),
                Mathf.Clamp(gobj21.transform.localPosition.y, (float)-1.551666, (float)2.68), gobj21.transform.localPosition.z);
            }
            else
            {
                if ((gobj21.transform.localRotation == Quaternion.Euler((float)-90.00001, 180, (float)-90.00001)))
                {
                    gobj21.transform.localPosition = new Vector3(Mathf.Clamp(gobj21.transform.localPosition.x, (float)-23.4, 4),
                    Mathf.Clamp(gobj21.transform.localPosition.y, (float)-1.551666, (float)3.7), gobj21.transform.localPosition.z);
                }

                else
                {
                    if ((gobj21.transform.localRotation == Quaternion.Euler((float)-90.00001, 270, (float)-90.00001)))
                    {
                        gobj21.transform.localPosition = new Vector3(Mathf.Clamp(gobj21.transform.localPosition.x, -28, (float)7.3),
                        Mathf.Clamp(gobj21.transform.localPosition.y, (float)-1.551666, (float)4.8), gobj21.transform.localPosition.z);
                    }
                }
            }
        }

        //pièce 23
        if ((gobj22.transform.localRotation == Quaternion.Euler((float)-90.00001, 0, (float)-90.00001)))
        {
            gobj22.transform.localPosition = new Vector3(Mathf.Clamp(gobj22.transform.localPosition.x,(float)-17.7, 10),
            Mathf.Clamp(gobj22.transform.localPosition.y, (float)-1.551666,(float) 2.9), gobj22.transform.localPosition.z);
        }
        else
        {
            if ((gobj22.transform.localRotation == Quaternion.Euler((float)-90.00001, 90, (float)-90.00001)))
            {
                gobj22.transform.localPosition = new Vector3(Mathf.Clamp(gobj22.transform.localPosition.x,-13, (float)4.15),
                Mathf.Clamp(gobj22.transform.localPosition.y, (float)-1.551666, (float)1.96), gobj22.transform.localPosition.z);
            }
            else
            {
                if ((gobj22.transform.localRotation == Quaternion.Euler((float)-90.00001, 180, (float)-90.00001)))
                {
                    gobj22.transform.localPosition = new Vector3(Mathf.Clamp(gobj22.transform.localPosition.x, (float)-23.2,(float) 3.29),
                    Mathf.Clamp(gobj22.transform.localPosition.y, (float)-1.551666, (float)3.49), gobj22.transform.localPosition.z);
                }

                else
                {
                    if ((gobj22.transform.localRotation == Quaternion.Euler((float)-90.00001, 270, (float)-90.00001)))
                    {
                         gobj22.transform.localRotation = Quaternion.Euler((float)-90.00001, 0, (float)-90.00001);
                    }
                }
            }
        }


        //pièce 24
        if ((gobj23.transform.localRotation == Quaternion.Euler((float)-90.00001, 0, (float)-90.00001)))
        {
            gobj23.transform.localPosition = new Vector3(Mathf.Clamp(gobj23.transform.localPosition.x, -20, (float) 7.47),
            Mathf.Clamp(gobj23.transform.localPosition.y, (float)-1.551666, (float)3.55), gobj23.transform.localPosition.z);
        }
        else
        {
            if ((gobj23.transform.localRotation == Quaternion.Euler((float)-90.00001, 90, (float)-90.00001)))
            {
                gobj23.transform.localRotation = Quaternion.Euler((float)-90.00001, 180, (float)-90.00001);
            }
            else
            {
                if ((gobj23.transform.localRotation == Quaternion.Euler((float)-90.00001, 180, (float)-90.00001)))
                {
                    gobj23.transform.localPosition = new Vector3(Mathf.Clamp(gobj23.transform.localPosition.x, (float)-21.7, (float)5.78),
                    Mathf.Clamp(gobj23.transform.localPosition.y, (float)-1.551666, (float)2.9), gobj23.transform.localPosition.z);
                }

                else
                {
                    if ((gobj23.transform.localRotation == Quaternion.Euler((float)-90.00001, 270, (float)-90.00001)))
                    {
                        gobj23.transform.localRotation = Quaternion.Euler((float)-90.00001, 0, (float)-90.00001);
                    }
                }
            }
        }

        //pièce 25
        if ((gobj24.transform.localRotation == Quaternion.Euler((float)-90.00001, 0, (float)-90.00001)))
        {
            gobj24.transform.localPosition = new Vector3(Mathf.Clamp(gobj24.transform.localPosition.x, -27, 10),
            Mathf.Clamp(gobj24.transform.localPosition.y, (float)-1.551666, 5), gobj24.transform.localPosition.z);
        }
        else
        {
            if ((gobj24.transform.localRotation == Quaternion.Euler((float)-90.00001, 90, (float)-90.00001)))
            {
                gobj24.transform.localPosition = new Vector3(Mathf.Clamp(gobj24.transform.localPosition.x, (float)-15.7, (float)7.4),
                Mathf.Clamp(gobj24.transform.localPosition.y, (float)-1.551666, (float)2.87), gobj24.transform.localPosition.z);
            }
            else
            {
                if ((gobj24.transform.localRotation == Quaternion.Euler((float)-90.00001, 180, (float)-90.00001)))
                {
                    gobj24.transform.localPosition = new Vector3(Mathf.Clamp(gobj24.transform.localPosition.x, (float)-21.2, (float)3.92),
                    Mathf.Clamp(gobj24.transform.localPosition.y, (float)-1.551666, (float)2.8), gobj24.transform.localPosition.z);
                }

                else
                {
                    if ((gobj24.transform.localRotation == Quaternion.Euler((float)-90.00001, 270, (float)-90.00001)))
                    {
                        gobj24.transform.localRotation = Quaternion.Euler((float)-90.00001, 0, (float)-90.00001);
                    }
                }
            }
        }


        //pièce 26
        if ((gobj25.transform.localRotation == Quaternion.Euler((float)-90.00001, 0, (float)-90.00001)))
        {
            gobj25.transform.localPosition = new Vector3(Mathf.Clamp(gobj25.transform.localPosition.x,(float)-17.3,(float) 8.1),
            Mathf.Clamp(gobj25.transform.localPosition.y, (float)-1.551666,(float) 3.05), gobj25.transform.localPosition.z);
        }
        else
        {
            if ((gobj25.transform.localRotation == Quaternion.Euler((float)-90.00001, 90, (float)-90.00001)))
            {
                gobj25.transform.localRotation = Quaternion.Euler((float)-90.00001, 180, (float)-90.00001);
            }
            else
            {
                if ((gobj25.transform.localRotation == Quaternion.Euler((float)-90.00001, 180, (float)-90.00001)))
                {
                    gobj25.transform.localPosition = new Vector3(Mathf.Clamp(gobj25.transform.localPosition.x, -31, (float)6.05),
                    Mathf.Clamp(gobj25.transform.localPosition.y, (float)-1.551666, (float)5.1), gobj25.transform.localPosition.z);
                }

                else
                {
                    if ((gobj25.transform.localRotation == Quaternion.Euler((float)-90.00001, 270, (float)-90.00001)))
                    {
                        gobj25.transform.localRotation = Quaternion.Euler((float)-90.00001, 0, (float)-90.00001);
                    }
                }
            }
        }

        gobj26.transform.localPosition = new Vector3(Mathf.Clamp(gobj26.transform.localPosition.x, -27, (float)8.3),
        Mathf.Clamp(gobj26.transform.localPosition.y, -2, (float)5.2), gobj26.transform.localPosition.z);
    }
}
