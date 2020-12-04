using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenBoundsFiacre : MonoBehaviour
{
    public GameObject gobj, gobj1, gobj2, gobj3, gobj4, gobj5, gobj6, gobj7, gobj8, gobj9, gobj10, gobj11, gobj12, gobj13, gobj14,
                     gobj15, gobj16, gobj17, gobj18, gobj19, gobj20, gobj21, gobj22, gobj23;


    void Update()
    {
        //pièce 1
        if ((gobj.transform.localRotation == Quaternion.Euler(0, 0, 0)))
          
        {
            gobj.transform.localPosition = new Vector3(Mathf.Clamp(gobj.transform.localPosition.x,-110, 86), gobj.transform.localPosition.y,
            Mathf.Clamp(gobj.transform.localPosition.z, 0, 100));
        }
        else
        {
            if ((gobj.transform.localRotation == Quaternion.Euler(0, 0, 90)) )
                
            {
                gobj.transform.localPosition = new Vector3(Mathf.Clamp(gobj.transform.localPosition.x, -77, 136), gobj.transform.localPosition.y,
                Mathf.Clamp(gobj.transform.localPosition.z, 0, 86));
            }
            else
            {
                if ((gobj.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj.transform.localPosition = new Vector3(Mathf.Clamp(gobj.transform.localPosition.x, -100, 85), gobj.transform.localPosition.y,
                    Mathf.Clamp(gobj.transform.localPosition.z, 0, 98));
                }
                else
                {
                    if ((gobj.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj.transform.localPosition = new Vector3(Mathf.Clamp(gobj.transform.localPosition.x, -77,140), gobj.transform.localPosition.y,
                        Mathf.Clamp(gobj.transform.localPosition.z, 0, 90));
                    }
                }


            }
          
        }

        //pièce 2
        if ((gobj1.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj1.transform.localPosition = new Vector3(Mathf.Clamp(gobj1.transform.localPosition.x, -124, 89), gobj1.transform.localPosition.y,
            Mathf.Clamp(gobj1.transform.localPosition.z, -5, 100));
        }
        else
        {
            if ((gobj1.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj1.transform.localPosition = new Vector3(Mathf.Clamp(gobj1.transform.localPosition.x, -83, 136), gobj1.transform.localPosition.y,
                Mathf.Clamp(gobj1.transform.localPosition.z, -5, 88));
            }
            else
            {
                if ((gobj1.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj1.transform.localPosition = new Vector3(Mathf.Clamp(gobj1.transform.localPosition.x, -102, 120), gobj1.transform.localPosition.y,
                    Mathf.Clamp(gobj1.transform.localPosition.z, -5, 105));
                }
                else
                {
                    if ((gobj1.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj1.transform.localPosition = new Vector3(Mathf.Clamp(gobj1.transform.localPosition.x, -108, 154), gobj1.transform.localPosition.y,
                        Mathf.Clamp(gobj1.transform.localPosition.z, -5, 97));
                    }
                }


            }

        }

        //pièce 3
        if ((gobj2.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj2.transform.localPosition = new Vector3(Mathf.Clamp(gobj2.transform.localPosition.x, -124, 89), gobj2.transform.localPosition.y,
            Mathf.Clamp(gobj2.transform.localPosition.z, -15, 90));
        }
        else
        {
            if ((gobj2.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj2.transform.localPosition = new Vector3(Mathf.Clamp(gobj2.transform.localPosition.x, -83, 136), gobj2.transform.localPosition.y,
                Mathf.Clamp(gobj2.transform.localPosition.z, -15, 76));
            }
            else
            {
                if ((gobj2.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj2.transform.localPosition = new Vector3(Mathf.Clamp(gobj2.transform.localPosition.x, -102, 121), gobj2.transform.localPosition.y,
                    Mathf.Clamp(gobj2.transform.localPosition.z, -15, 98));
                }
                else
                {
                    if ((gobj2.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj2.transform.localPosition = new Vector3(Mathf.Clamp(gobj2.transform.localPosition.x, -112, 155), gobj2.transform.localPosition.y,
                        Mathf.Clamp(gobj2.transform.localPosition.z, -15, 88));
                    }
                }


            }

        }

        //pièce 4
        if ((gobj3.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj3.transform.localPosition = new Vector3(Mathf.Clamp(gobj3.transform.localPosition.x, -124, 89), gobj3.transform.localPosition.y,
            Mathf.Clamp(gobj3.transform.localPosition.z, -20, 90));
        }
        else
        {
            if ((gobj3.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj3.transform.localPosition = new Vector3(Mathf.Clamp(gobj3.transform.localPosition.x, -90, 136), gobj3.transform.localPosition.y,
                Mathf.Clamp(gobj3.transform.localPosition.z, -20, 78));
            }
            else
            {
                if ((gobj3.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj3.transform.localPosition = new Vector3(Mathf.Clamp(gobj3.transform.localPosition.x, -102, 121), gobj3.transform.localPosition.y,
                    Mathf.Clamp(gobj3.transform.localPosition.z, -15, 96));
                }
                else
                {
                    if ((gobj3.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj3.transform.localPosition = new Vector3(Mathf.Clamp(gobj3.transform.localPosition.x, -112, 155), gobj3.transform.localPosition.y,
                        Mathf.Clamp(gobj3.transform.localPosition.z, -20, 91));
                    }
                }


            }

        }

        //pièce 5
        if ((gobj4.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj4.transform.localPosition = new Vector3(Mathf.Clamp(gobj4.transform.localPosition.x, -125, 98), gobj4.transform.localPosition.y,
            Mathf.Clamp(gobj4.transform.localPosition.z, -25, 87));
        }
        else
        {
            if ((gobj4.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj4.transform.localPosition = new Vector3(Mathf.Clamp(gobj4.transform.localPosition.x, -90, 152), gobj4.transform.localPosition.y,
                Mathf.Clamp(gobj4.transform.localPosition.z, -25, 75));
            }
            else
            {
                if ((gobj4.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj4.transform.localPosition = new Vector3(Mathf.Clamp(gobj4.transform.localPosition.x, -102, 121), gobj4.transform.localPosition.y,
                    Mathf.Clamp(gobj4.transform.localPosition.z, -15, 90));
                }
                else
                {
                    if ((gobj4.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj4.transform.localPosition = new Vector3(Mathf.Clamp(gobj4.transform.localPosition.x, -112, 155), gobj4.transform.localPosition.y,
                        Mathf.Clamp(gobj4.transform.localPosition.z, -20, 80));
                    }
                }


            }

        }

        //pièce 6
        if ((gobj5.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj5.transform.localPosition = new Vector3(Mathf.Clamp(gobj5.transform.localPosition.x, -125, 105), gobj5.transform.localPosition.y,
            Mathf.Clamp(gobj5.transform.localPosition.z, -30, 82));
        }
        else
        {
            if ((gobj5.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj5.transform.localPosition = new Vector3(Mathf.Clamp(gobj5.transform.localPosition.x, -94, 155), gobj5.transform.localPosition.y,
                Mathf.Clamp(gobj5.transform.localPosition.z, -30, 73));
            }
            else
            {
                if ((gobj5.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj5.transform.localPosition = new Vector3(Mathf.Clamp(gobj5.transform.localPosition.x, -122, 121), gobj5.transform.localPosition.y,
                    Mathf.Clamp(gobj5.transform.localPosition.z, -30, 86));
                }
                else
                {
                    if ((gobj5.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj5.transform.localPosition = new Vector3(Mathf.Clamp(gobj5.transform.localPosition.x, -112, 154), gobj5.transform.localPosition.y,
                        Mathf.Clamp(gobj5.transform.localPosition.z, -30, 75));
                    }
                }


            }

        }


        //pièce 7
        if ((gobj6.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj6.transform.localPosition = new Vector3(Mathf.Clamp(gobj6.transform.localPosition.x, -124, 108), gobj6.transform.localPosition.y,
            Mathf.Clamp(gobj6.transform.localPosition.z, -35, 77));
        }
        else
        {
            if ((gobj6.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj6.transform.localPosition = new Vector3(Mathf.Clamp(gobj6.transform.localPosition.x, -105, 162), gobj6.transform.localPosition.y,
                Mathf.Clamp(gobj6.transform.localPosition.z, -35, 69));
            }
            else
            {
                if ((gobj6.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj6.transform.localPosition = new Vector3(Mathf.Clamp(gobj6.transform.localPosition.x, -132, 121), gobj6.transform.localPosition.y,
                    Mathf.Clamp(gobj6.transform.localPosition.z, -35, 80));
                }
                else
                {
                    if ((gobj6.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj6.transform.localPosition = new Vector3(Mathf.Clamp(gobj6.transform.localPosition.x, -112, 154), gobj6.transform.localPosition.y,
                        Mathf.Clamp(gobj6.transform.localPosition.z, -35,69));
                    }
                }


            }

        }

        //pièce 8
        if ((gobj7.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj7.transform.localPosition = new Vector3(Mathf.Clamp(gobj7.transform.localPosition.x, -124, 108), gobj7.transform.localPosition.y,
            Mathf.Clamp(gobj7.transform.localPosition.z, -25, 73));
        }
        else
        {
            if ((gobj7.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj7.transform.localPosition = new Vector3(Mathf.Clamp(gobj7.transform.localPosition.x, -105, 162), gobj7.transform.localPosition.y,
                Mathf.Clamp(gobj7.transform.localPosition.z, -25, 63));
            }
            else
            {
                if ((gobj7.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj7.transform.localPosition = new Vector3(Mathf.Clamp(gobj7.transform.localPosition.x, -132, 121), gobj7.transform.localPosition.y,
                    Mathf.Clamp(gobj7.transform.localPosition.z, -25, 75));
                }
                else
                {
                    if ((gobj7.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj7.transform.localPosition = new Vector3(Mathf.Clamp(gobj7.transform.localPosition.x, -112, 154), gobj7.transform.localPosition.y,
                        Mathf.Clamp(gobj7.transform.localPosition.z, -25, 65));
                    }
                }


            }

        }


        //pièce 9
        if ((gobj8.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj8.transform.localPosition = new Vector3(Mathf.Clamp(gobj8.transform.localPosition.x, -125, 108), gobj8.transform.localPosition.y,
            Mathf.Clamp(gobj8.transform.localPosition.z, -30, 70));
        }
        else
        {
            if ((gobj8.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj8.transform.localPosition = new Vector3(Mathf.Clamp(gobj8.transform.localPosition.x, -105, 162), gobj8.transform.localPosition.y,
                Mathf.Clamp(gobj8.transform.localPosition.z, -30, 59));
            }
            else
            {
                if ((gobj8.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj8.transform.localPosition = new Vector3(Mathf.Clamp(gobj8.transform.localPosition.x, -132, 121), gobj8.transform.localPosition.y,
                    Mathf.Clamp(gobj8.transform.localPosition.z, -30, 73));
                }
                else
                {
                    if ((gobj8.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj8.transform.localPosition = new Vector3(Mathf.Clamp(gobj8.transform.localPosition.x, -113, 156), gobj8.transform.localPosition.y,
                        Mathf.Clamp(gobj8.transform.localPosition.z, -30, 60));
                    }
                }


            }

        }

        //pièce 10
        if ((gobj9.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj9.transform.localPosition = new Vector3(Mathf.Clamp(gobj9.transform.localPosition.x, -132, 108), gobj9.transform.localPosition.y,
            Mathf.Clamp(gobj9.transform.localPosition.z, -45, 65));
        }
        else
        {
            if ((gobj9.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj9.transform.localPosition = new Vector3(Mathf.Clamp(gobj9.transform.localPosition.x, -105, 162), gobj9.transform.localPosition.y,
                Mathf.Clamp(gobj9.transform.localPosition.z, -45, 55));
            }
            else
            {
                if ((gobj9.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj9.transform.localPosition = new Vector3(Mathf.Clamp(gobj9.transform.localPosition.x, -137, 121), gobj9.transform.localPosition.y,
                    Mathf.Clamp(gobj9.transform.localPosition.z, -45, 71));
                }
                else
                {
                    if ((gobj9.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj9.transform.localPosition = new Vector3(Mathf.Clamp(gobj9.transform.localPosition.x, -115, 168), gobj9.transform.localPosition.y,
                        Mathf.Clamp(gobj9.transform.localPosition.z, -45, 55));
                    }
                }


            }

        }

        //pièce 11
        if ((gobj10.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj10.transform.localPosition = new Vector3(Mathf.Clamp(gobj10.transform.localPosition.x, -136, 108), gobj10.transform.localPosition.y,
            Mathf.Clamp(gobj10.transform.localPosition.z, -45, 60));
        }
        else
        {
            if ((gobj10.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj10.transform.localPosition = new Vector3(Mathf.Clamp(gobj10.transform.localPosition.x, -105, 162), gobj10.transform.localPosition.y,
                Mathf.Clamp(gobj10.transform.localPosition.z, -45, 50));
            }
            else
            {
                if ((gobj10.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj10.transform.localPosition = new Vector3(Mathf.Clamp(gobj10.transform.localPosition.x, -137, 121), gobj10.transform.localPosition.y,
                    Mathf.Clamp(gobj10.transform.localPosition.z, -45, 70));
                }
                else
                {
                    if ((gobj10.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj10.transform.localPosition = new Vector3(Mathf.Clamp(gobj10.transform.localPosition.x, -115, 171), gobj10.transform.localPosition.y,
                        Mathf.Clamp(gobj10.transform.localPosition.z, -45, 52));
                    }
                }


            }

        }


        //pièce 12
        if ((gobj11.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj11.transform.localPosition = new Vector3(Mathf.Clamp(gobj11.transform.localPosition.x, -136, 108), gobj11.transform.localPosition.y,
            Mathf.Clamp(gobj11.transform.localPosition.z, -50, 56));
        }
        else
        {
            if ((gobj11.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj11.transform.localPosition = new Vector3(Mathf.Clamp(gobj11.transform.localPosition.x, -105, 162), gobj11.transform.localPosition.y,
                Mathf.Clamp(gobj11.transform.localPosition.z, -50, 46));
            }
            else
            {
                if ((gobj11.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj11.transform.localPosition = new Vector3(Mathf.Clamp(gobj11.transform.localPosition.x, -136, 121), gobj11.transform.localPosition.y,
                    Mathf.Clamp(gobj11.transform.localPosition.z, -50, 63));
                }
                else
                {
                    if ((gobj11.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj11.transform.localPosition = new Vector3(Mathf.Clamp(gobj11.transform.localPosition.x, -117, 171), gobj11.transform.localPosition.y,
                        Mathf.Clamp(gobj11.transform.localPosition.z, -50, 46));
                    }
                }


            }

        }

        //pièce 13
        if ((gobj12.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj12.transform.localPosition = new Vector3(Mathf.Clamp(gobj12.transform.localPosition.x, -136, 108), gobj12.transform.localPosition.y,
            Mathf.Clamp(gobj12.transform.localPosition.z, -60, 50));
        }
        else
        {
            if ((gobj12.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj12.transform.localPosition = new Vector3(Mathf.Clamp(gobj12.transform.localPosition.x, -105, 162), gobj12.transform.localPosition.y,
                Mathf.Clamp(gobj12.transform.localPosition.z, -60, 40));
            }
            else
            {
                if ((gobj12.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj12.transform.localPosition = new Vector3(Mathf.Clamp(gobj12.transform.localPosition.x, -136, 121), gobj12.transform.localPosition.y,
                    Mathf.Clamp(gobj12.transform.localPosition.z, -60, 58));
                }
                else
                {
                    if ((gobj12.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj12.transform.localPosition = new Vector3(Mathf.Clamp(gobj12.transform.localPosition.x, -117, 171), gobj12.transform.localPosition.y,
                        Mathf.Clamp(gobj12.transform.localPosition.z, -60, 42));
                    }
                }


            }

        }

        //pièce 14
        if ((gobj13.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj13.transform.localPosition = new Vector3(Mathf.Clamp(gobj13.transform.localPosition.x, -136, 108), gobj13.transform.localPosition.y,
            Mathf.Clamp(gobj13.transform.localPosition.z, -65, 46));
        }
        else
        {
            if ((gobj13.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj13.transform.localPosition = new Vector3(Mathf.Clamp(gobj13.transform.localPosition.x, -105, 162), gobj13.transform.localPosition.y,
                Mathf.Clamp(gobj13.transform.localPosition.z, -65, 38));
            }
            else
            {
                if ((gobj13.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj13.transform.localPosition = new Vector3(Mathf.Clamp(gobj13.transform.localPosition.x, -136, 121), gobj13.transform.localPosition.y,
                    Mathf.Clamp(gobj13.transform.localPosition.z, -65, 53));
                }
                else
                {
                    if ((gobj13.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj13.transform.localPosition = new Vector3(Mathf.Clamp(gobj13.transform.localPosition.x, -117, 171), gobj13.transform.localPosition.y,
                        Mathf.Clamp(gobj13.transform.localPosition.z, -65, 37));
                    }
                }


            }

        }


        //pièce 15
        if ((gobj14.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj14.transform.localPosition = new Vector3(Mathf.Clamp(gobj14.transform.localPosition.x, -136, 117), gobj14.transform.localPosition.y,
            Mathf.Clamp(gobj14.transform.localPosition.z, -70, 42));
        }
        else
        {
            if ((gobj14.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj14.transform.localPosition = new Vector3(Mathf.Clamp(gobj14.transform.localPosition.x, -113, 164), gobj14.transform.localPosition.y,
                Mathf.Clamp(gobj14.transform.localPosition.z, -70, 35));
            }
            else
            {
                if ((gobj14.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj14.transform.localPosition = new Vector3(Mathf.Clamp(gobj14.transform.localPosition.x, -140, 121), gobj14.transform.localPosition.y,
                    Mathf.Clamp(gobj14.transform.localPosition.z, -70, 49));
                }
                else
                {
                    if ((gobj14.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj14.transform.localPosition = new Vector3(Mathf.Clamp(gobj14.transform.localPosition.x, -116, 171), gobj14.transform.localPosition.y,
                        Mathf.Clamp(gobj14.transform.localPosition.z, -70, 34));
                    }
                }


            }

        }


        //pièce 16
        if ((gobj15.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj15.transform.localPosition = new Vector3(Mathf.Clamp(gobj15.transform.localPosition.x, -149, 284), gobj15.transform.localPosition.y,
            Mathf.Clamp(gobj15.transform.localPosition.z, -65, 51));
        }
        else
        {
            if ((gobj15.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj15.transform.localPosition = new Vector3(Mathf.Clamp(gobj15.transform.localPosition.x, -245, 235), gobj15.transform.localPosition.y,
                Mathf.Clamp(gobj15.transform.localPosition.z, -65, 63));
            }
            else
            {
                if ((gobj15.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj15.transform.localPosition = new Vector3(Mathf.Clamp(gobj15.transform.localPosition.x, -224, 134), gobj15.transform.localPosition.y,
                    Mathf.Clamp(gobj15.transform.localPosition.z, -65, 33));
                }
                else
                {
                    if ((gobj15.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj15.transform.localPosition = new Vector3(Mathf.Clamp(gobj15.transform.localPosition.x, -128, 183), gobj15.transform.localPosition.y,
                        Mathf.Clamp(gobj15.transform.localPosition.z, -65, 20));
                    }
                }


            }

        }

        //pièce 17
        if ((gobj16.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj16.transform.localPosition = new Vector3(Mathf.Clamp(gobj16.transform.localPosition.x, -162, 312), gobj16.transform.localPosition.y,
            Mathf.Clamp(gobj16.transform.localPosition.z, -65, 63));
        }
        else
        {
            if ((gobj16.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj16.transform.localPosition = new Vector3(Mathf.Clamp(gobj16.transform.localPosition.x, -271, 232), gobj16.transform.localPosition.y,
                Mathf.Clamp(gobj16.transform.localPosition.z, -65, 69));
            }
            else
            {
                if ((gobj16.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj16.transform.localPosition = new Vector3(Mathf.Clamp(gobj16.transform.localPosition.x, -227, 123), gobj16.transform.localPosition.y,
                    Mathf.Clamp(gobj16.transform.localPosition.z, -65, 30));
                }
                else
                {
                    if ((gobj16.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj16.transform.localPosition = new Vector3(Mathf.Clamp(gobj16.transform.localPosition.x, -118, 203), gobj16.transform.localPosition.y,
                        Mathf.Clamp(gobj16.transform.localPosition.z, -65, 23));
                    }
                }


            }

        }

        //pièce 18
        if ((gobj17.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj17.transform.localPosition = new Vector3(Mathf.Clamp(gobj17.transform.localPosition.x, -176, 282), gobj17.transform.localPosition.y,
            Mathf.Clamp(gobj17.transform.localPosition.z, -65, 57));
        }
        else
        {
            if ((gobj17.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj17.transform.localPosition = new Vector3(Mathf.Clamp(gobj17.transform.localPosition.x, -248, 224), gobj17.transform.localPosition.y,
                Mathf.Clamp(gobj17.transform.localPosition.z, -65, 62));
            }
            else
            {
                if ((gobj17.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj17.transform.localPosition = new Vector3(Mathf.Clamp(gobj17.transform.localPosition.x, -213, 154), gobj17.transform.localPosition.y,
                    Mathf.Clamp(gobj17.transform.localPosition.z, -65, 35));
                }
                else
                {
                    if ((gobj17.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj17.transform.localPosition = new Vector3(Mathf.Clamp(gobj17.transform.localPosition.x, -142, 212), gobj17.transform.localPosition.y,
                        Mathf.Clamp(gobj17.transform.localPosition.z, -65, 32));
                    }
                }


            }

        }

     

        //pièce 19
        if ((gobj18.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj18.transform.localPosition = new Vector3(Mathf.Clamp(gobj18.transform.localPosition.x, -152, 273), gobj18.transform.localPosition.y,
            Mathf.Clamp(gobj18.transform.localPosition.z, -60, 50));
        }
        else
        {
            if ((gobj18.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj18.transform.localPosition = new Vector3(Mathf.Clamp(gobj18.transform.localPosition.x, -234, 254), gobj18.transform.localPosition.y,
                Mathf.Clamp(gobj18.transform.localPosition.z, -60, 67));
            }
            else
            {
                if ((gobj18.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj18.transform.localPosition = new Vector3(Mathf.Clamp(gobj18.transform.localPosition.x, -238, 162), gobj18.transform.localPosition.y,
                    Mathf.Clamp(gobj18.transform.localPosition.z, -60, 43));
                }
                else
                {
                    if ((gobj18.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj18.transform.localPosition = new Vector3(Mathf.Clamp(gobj18.transform.localPosition.x, -132, 173), gobj18.transform.localPosition.y,
                        Mathf.Clamp(gobj18.transform.localPosition.z, -60, 20));
                    }
                }


            }

        }

        //pièce 20
        if ((gobj19.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj19.transform.localPosition = new Vector3(Mathf.Clamp(gobj19.transform.localPosition.x, -138, 304), gobj19.transform.localPosition.y,
            Mathf.Clamp(gobj19.transform.localPosition.z, -60, 54));
        }
        else
        {
            if ((gobj19.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj19.transform.localPosition = new Vector3(Mathf.Clamp(gobj19.transform.localPosition.x, -258, 263), gobj19.transform.localPosition.y,
                Mathf.Clamp(gobj19.transform.localPosition.z, -60, 74));
            }
            else
            {
                if ((gobj19.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj19.transform.localPosition = new Vector3(Mathf.Clamp(gobj19.transform.localPosition.x, -251, 132), gobj19.transform.localPosition.y,
                    Mathf.Clamp(gobj19.transform.localPosition.z, -60, 39));
                }
                else
                {
                    if ((gobj19.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj19.transform.localPosition = new Vector3(Mathf.Clamp(gobj19.transform.localPosition.x, -155, 181), gobj19.transform.localPosition.y,
                        Mathf.Clamp(gobj19.transform.localPosition.z, -60, 27));
                    }
                }


            }

        }


        //pièce 21
        if ((gobj20.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj20.transform.localPosition = new Vector3(Mathf.Clamp(gobj20.transform.localPosition.x, -169, 123), gobj20.transform.localPosition.y,
            Mathf.Clamp(gobj20.transform.localPosition.z, -70, 40));
        }
        else
        {
            if ((gobj20.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj20.transform.localPosition = new Vector3(Mathf.Clamp(gobj20.transform.localPosition.x, -119, 166), gobj20.transform.localPosition.y,
                Mathf.Clamp(gobj20.transform.localPosition.z, -70, 35));
            }
            else
            {
                if ((gobj20.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj20.transform.localPosition = new Vector3(Mathf.Clamp(gobj20.transform.localPosition.x, -144, 168), gobj20.transform.localPosition.y,
                    Mathf.Clamp(gobj20.transform.localPosition.z, -70, 54));
                }
                else
                {
                    if ((gobj20.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj20.transform.localPosition = new Vector3(Mathf.Clamp(gobj20.transform.localPosition.x, -156, 180), gobj20.transform.localPosition.y,
                        Mathf.Clamp(gobj20.transform.localPosition.z, -70, 46));
                    }
                }


            }

        }

        //pièce 22
        if ((gobj21.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj21.transform.localPosition = new Vector3(Mathf.Clamp(gobj21.transform.localPosition.x, -148, 284), gobj21.transform.localPosition.y,
            Mathf.Clamp(gobj21.transform.localPosition.z, -80, 46));
        }
        else
        {
            if ((gobj21.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj21.transform.localPosition = new Vector3(Mathf.Clamp(gobj21.transform.localPosition.x, -244, 234), gobj21.transform.localPosition.y,
                Mathf.Clamp(gobj21.transform.localPosition.z, -80, 58));
            }
            else
            {
                if ((gobj21.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj21.transform.localPosition = new Vector3(Mathf.Clamp(gobj21.transform.localPosition.x, -224, 133), gobj21.transform.localPosition.y,
                    Mathf.Clamp(gobj21.transform.localPosition.z, -80, 27));
                }
                else
                {
                    if ((gobj21.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj21.transform.localPosition = new Vector3(Mathf.Clamp(gobj21.transform.localPosition.x, -129, 183), gobj21.transform.localPosition.y,
                        Mathf.Clamp(gobj21.transform.localPosition.z, -80, 15));
                    }
                }


            }

        }

        //pièce 23
        if ((gobj22.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj22.transform.localPosition = new Vector3(Mathf.Clamp(gobj22.transform.localPosition.x, -148, 284), gobj22.transform.localPosition.y,
            Mathf.Clamp(gobj22.transform.localPosition.z, -85, 39));
        }
        else
        {
            if ((gobj22.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj22.transform.localPosition = new Vector3(Mathf.Clamp(gobj22.transform.localPosition.x, -244, 234), gobj22.transform.localPosition.y,
                Mathf.Clamp(gobj22.transform.localPosition.z, -85, 50));
            }
            else
            {
                if ((gobj22.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj22.transform.localPosition = new Vector3(Mathf.Clamp(gobj22.transform.localPosition.x, -224, 133), gobj22.transform.localPosition.y,
                    Mathf.Clamp(gobj22.transform.localPosition.z, -85, 20));
                }
                else
                {
                    if ((gobj22.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj22.transform.localPosition = new Vector3(Mathf.Clamp(gobj22.transform.localPosition.x, -129, 183), gobj22.transform.localPosition.y,
                        Mathf.Clamp(gobj22.transform.localPosition.z, -85, 8));
                    }
                }


            }

        }


        //pièce 24
        if ((gobj23.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj23.transform.localPosition = new Vector3(Mathf.Clamp(gobj23.transform.localPosition.x, -153, 288), gobj23.transform.localPosition.y,
            Mathf.Clamp(gobj23.transform.localPosition.z, -95, 1));
        }
        else
        {
            if ((gobj23.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj23.transform.localPosition = new Vector3(Mathf.Clamp(gobj23.transform.localPosition.x, -248, 240), gobj23.transform.localPosition.y,
                Mathf.Clamp(gobj23.transform.localPosition.z, -95, 7));
            }
            else
            {
                if ((gobj23.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj23.transform.localPosition = new Vector3(Mathf.Clamp(gobj23.transform.localPosition.x, -229, 139), gobj23.transform.localPosition.y,
                    Mathf.Clamp(gobj23.transform.localPosition.z, -95, -20));
                }
                else
                {
                    if ((gobj23.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj23.transform.localPosition = new Vector3(Mathf.Clamp(gobj23.transform.localPosition.x, -133, 188), gobj23.transform.localPosition.y,
                        Mathf.Clamp(gobj23.transform.localPosition.z, -95, -36));
                    }
                }


            }

        }


    }
}
