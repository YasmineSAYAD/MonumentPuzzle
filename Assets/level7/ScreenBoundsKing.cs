using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenBoundsKing : MonoBehaviour
{
    public GameObject gobj, gobj1, gobj2, gobj3, gobj4, gobj5, gobj6, gobj7, gobj8, gobj9, gobj10, gobj11, gobj12, gobj13, gobj14,
                       gobj15, gobj16, gobj17, gobj18, gobj19, gobj20, gobj21, gobj22, gobj23, gobj24, gobj25, gobj26, gobj27,
                       gobj28, gobj29, gobj30, gobj31, gobj32, gobj33, gobj34, gobj35, gobj36, gobj37, gobj38, gobj39, gobj40,
                       gobj41, gobj42, gobj43;

    void Update()
    {
        //pièce 1
        if ((gobj.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj.transform.localPosition = new Vector3(Mathf.Clamp(gobj.transform.localPosition.x, -192, 240), gobj.transform.localPosition.y,
            Mathf.Clamp(gobj.transform.localPosition.z, -5, 170));
        }
        else
        {
            if ((gobj.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj.transform.localPosition = new Vector3(Mathf.Clamp(gobj.transform.localPosition.x, -204, 254), gobj.transform.localPosition.y,
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


        //pièce 2
        if ((gobj1.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj1.transform.localPosition = new Vector3(Mathf.Clamp(gobj1.transform.localPosition.x, -192, 240), gobj1.transform.localPosition.y,
            Mathf.Clamp(gobj1.transform.localPosition.z, -10, 166));
        }
        else
        {
            if ((gobj1.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj1.transform.localPosition = new Vector3(Mathf.Clamp(gobj1.transform.localPosition.x, -206,254), gobj1.transform.localPosition.y,
                Mathf.Clamp(gobj1.transform.localPosition.z, -10, 193));
            }
            else
            {
                if ((gobj1.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj1.transform.localPosition = new Vector3(Mathf.Clamp(gobj1.transform.localPosition.x, -197, 230), gobj1.transform.localPosition.y,
                    Mathf.Clamp(gobj1.transform.localPosition.z, -10, 167));
                }
                else
                {
                    if ((gobj1.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj1.transform.localPosition = new Vector3(Mathf.Clamp(gobj1.transform.localPosition.x, -202, 257), gobj1.transform.localPosition.y,
                        Mathf.Clamp(gobj1.transform.localPosition.z, -10, 194));
                    }
                }


            }

        }


        //pièce 3
        if ((gobj2.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj2.transform.localPosition = new Vector3(Mathf.Clamp(gobj2.transform.localPosition.x, -192, 240), gobj2.transform.localPosition.y,
            Mathf.Clamp(gobj2.transform.localPosition.z, -15, 162));
        }
        else
        {
            if ((gobj2.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj2.transform.localPosition = new Vector3(Mathf.Clamp(gobj2.transform.localPosition.x, -206, 254), gobj2.transform.localPosition.y,
                Mathf.Clamp(gobj2.transform.localPosition.z, -15, 190));
            }
            else
            {
                if ((gobj2.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj2.transform.localPosition = new Vector3(Mathf.Clamp(gobj2.transform.localPosition.x, -197, 230), gobj2.transform.localPosition.y,
                    Mathf.Clamp(gobj2.transform.localPosition.z, -15, 162));
                }
                else
                {
                    if ((gobj2.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj2.transform.localPosition = new Vector3(Mathf.Clamp(gobj2.transform.localPosition.x, -202, 257), gobj2.transform.localPosition.y,
                        Mathf.Clamp(gobj2.transform.localPosition.z, -15, 190));
                    }
                }


            }

        }

        //pièce 4
        if ((gobj3.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj3.transform.localPosition = new Vector3(Mathf.Clamp(gobj3.transform.localPosition.x, -206, 240), gobj3.transform.localPosition.y,
            Mathf.Clamp(gobj3.transform.localPosition.z, -20, 158));
        }
        else
        {
            if ((gobj3.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj3.transform.localPosition = new Vector3(Mathf.Clamp(gobj3.transform.localPosition.x, -205, 262), gobj3.transform.localPosition.y,
                Mathf.Clamp(gobj3.transform.localPosition.z, -20, 185));
            }
            else
            {
                if ((gobj3.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj3.transform.localPosition = new Vector3(Mathf.Clamp(gobj3.transform.localPosition.x, -197, 230), gobj3.transform.localPosition.y,
                    Mathf.Clamp(gobj3.transform.localPosition.z, -20, 158));
                }
                else
                {
                    if ((gobj3.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj3.transform.localPosition = new Vector3(Mathf.Clamp(gobj3.transform.localPosition.x, -202, 257), gobj3.transform.localPosition.y,
                        Mathf.Clamp(gobj3.transform.localPosition.z, -20, 185));
                    }
                }


            }

        }

        //pièce 5
        if ((gobj4.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj4.transform.localPosition = new Vector3(Mathf.Clamp(gobj4.transform.localPosition.x, -210, 242), gobj4.transform.localPosition.y,
            Mathf.Clamp(gobj4.transform.localPosition.z, -25, 154));
        }
        else
        {
            if ((gobj4.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj4.transform.localPosition = new Vector3(Mathf.Clamp(gobj4.transform.localPosition.x, -205, 269), gobj4.transform.localPosition.y,
                Mathf.Clamp(gobj4.transform.localPosition.z, -25, 181));
            }
            else
            {
                if ((gobj4.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj4.transform.localPosition = new Vector3(Mathf.Clamp(gobj4.transform.localPosition.x, -199, 230), gobj4.transform.localPosition.y,
                    Mathf.Clamp(gobj4.transform.localPosition.z, -25, 154));
                }
                else
                {
                    if ((gobj4.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj4.transform.localPosition = new Vector3(Mathf.Clamp(gobj4.transform.localPosition.x, -204, 260), gobj4.transform.localPosition.y,
                        Mathf.Clamp(gobj4.transform.localPosition.z, -25, 181));
                    }
                }


            }

        }


        //pièce 6
        if ((gobj5.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj5.transform.localPosition = new Vector3(Mathf.Clamp(gobj5.transform.localPosition.x, -218, 243), gobj5.transform.localPosition.y,
            Mathf.Clamp(gobj5.transform.localPosition.z, -30, 150));
        }
        else
        {
            if ((gobj5.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj5.transform.localPosition = new Vector3(Mathf.Clamp(gobj5.transform.localPosition.x, -207, 273), gobj5.transform.localPosition.y,
                Mathf.Clamp(gobj5.transform.localPosition.z, -30, 176));
            }
            else
            {
                if ((gobj5.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj5.transform.localPosition = new Vector3(Mathf.Clamp(gobj5.transform.localPosition.x, -199, 230), gobj5.transform.localPosition.y,
                    Mathf.Clamp(gobj5.transform.localPosition.z, -30, 150));
                }
                else
                {
                    if ((gobj5.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj5.transform.localPosition = new Vector3(Mathf.Clamp(gobj5.transform.localPosition.x, -204, 260), gobj5.transform.localPosition.y,
                        Mathf.Clamp(gobj5.transform.localPosition.z, -30, 176));
                    }
                }


            }

        }


        //pièce 7
        if ((gobj6.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj6.transform.localPosition = new Vector3(Mathf.Clamp(gobj6.transform.localPosition.x, -220, 245), gobj6.transform.localPosition.y,
            Mathf.Clamp(gobj6.transform.localPosition.z, -30, 146));
        }
        else
        {
            if ((gobj6.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj6.transform.localPosition = new Vector3(Mathf.Clamp(gobj6.transform.localPosition.x, -209, 274), gobj6.transform.localPosition.y,
                Mathf.Clamp(gobj6.transform.localPosition.z, -30, 172));
            }
            else
            {
                if ((gobj6.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj6.transform.localPosition = new Vector3(Mathf.Clamp(gobj6.transform.localPosition.x, -200, 230), gobj6.transform.localPosition.y,
                    Mathf.Clamp(gobj6.transform.localPosition.z, -30, 146));
                }
                else
                {
                    if ((gobj6.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj6.transform.localPosition = new Vector3(Mathf.Clamp(gobj6.transform.localPosition.x, -205, 260), gobj6.transform.localPosition.y,
                        Mathf.Clamp(gobj6.transform.localPosition.z, -30, 172));
                    }
                }


            }

        }


        //pièce 8
        if ((gobj7.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj7.transform.localPosition = new Vector3(Mathf.Clamp(gobj7.transform.localPosition.x, -223, 243), gobj7.transform.localPosition.y,
            Mathf.Clamp(gobj7.transform.localPosition.z, -40, 142));
        }
        else
        {
            if ((gobj7.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj7.transform.localPosition = new Vector3(Mathf.Clamp(gobj7.transform.localPosition.x, -209, 276), gobj7.transform.localPosition.y,
                Mathf.Clamp(gobj7.transform.localPosition.z, -40, 167));
            }
            else
            {
                if ((gobj7.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj7.transform.localPosition = new Vector3(Mathf.Clamp(gobj7.transform.localPosition.x, -200, 230), gobj7.transform.localPosition.y,
                    Mathf.Clamp(gobj7.transform.localPosition.z, -40, 142));
                }
                else
                {
                    if ((gobj7.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj7.transform.localPosition = new Vector3(Mathf.Clamp(gobj7.transform.localPosition.x, -205, 260), gobj7.transform.localPosition.y,
                        Mathf.Clamp(gobj7.transform.localPosition.z, -40, 167));
                    }
                }


            }

        }

        //pièce 9
        if ((gobj8.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj8.transform.localPosition = new Vector3(Mathf.Clamp(gobj8.transform.localPosition.x, -226, 243), gobj8.transform.localPosition.y,
            Mathf.Clamp(gobj8.transform.localPosition.z, -45, 138));
        }
        else
        {
            if ((gobj8.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj8.transform.localPosition = new Vector3(Mathf.Clamp(gobj8.transform.localPosition.x, -210, 278), gobj8.transform.localPosition.y,
                Mathf.Clamp(gobj8.transform.localPosition.z, -45, 163));
            }
            else
            {
                if ((gobj8.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj8.transform.localPosition = new Vector3(Mathf.Clamp(gobj8.transform.localPosition.x, -200, 230), gobj8.transform.localPosition.y,
                    Mathf.Clamp(gobj8.transform.localPosition.z, -45, 138));
                }
                else
                {
                    if ((gobj8.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj8.transform.localPosition = new Vector3(Mathf.Clamp(gobj8.transform.localPosition.x, -205, 260), gobj8.transform.localPosition.y,
                        Mathf.Clamp(gobj8.transform.localPosition.z, -45, 163));
                    }
                }


            }

        }



        //pièce 10
        if ((gobj9.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj9.transform.localPosition = new Vector3(Mathf.Clamp(gobj9.transform.localPosition.x, -227, 244), gobj9.transform.localPosition.y,
            Mathf.Clamp(gobj9.transform.localPosition.z, -50, 134));
        }
        else
        {
            if ((gobj9.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj9.transform.localPosition = new Vector3(Mathf.Clamp(gobj9.transform.localPosition.x, -211, 279), gobj9.transform.localPosition.y,
                Mathf.Clamp(gobj9.transform.localPosition.z, -50, 159));
            }
            else
            {
                if ((gobj9.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj9.transform.localPosition = new Vector3(Mathf.Clamp(gobj9.transform.localPosition.x, -201, 230), gobj9.transform.localPosition.y,
                    Mathf.Clamp(gobj9.transform.localPosition.z, -50, 134));
                }
                else
                {
                    if ((gobj9.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj9.transform.localPosition = new Vector3(Mathf.Clamp(gobj9.transform.localPosition.x, -205, 261), gobj9.transform.localPosition.y,
                        Mathf.Clamp(gobj9.transform.localPosition.z, -50, 159));
                    }
                }


            }

        }


        //pièce 11
        if ((gobj10.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj10.transform.localPosition = new Vector3(Mathf.Clamp(gobj10.transform.localPosition.x, -228, 245), gobj10.transform.localPosition.y,
            Mathf.Clamp(gobj10.transform.localPosition.z, -55, 130));
        }
        else
        {
            if ((gobj10.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj10.transform.localPosition = new Vector3(Mathf.Clamp(gobj10.transform.localPosition.x, -211, 280), gobj10.transform.localPosition.y,
                Mathf.Clamp(gobj10.transform.localPosition.z, -55, 155));
            }
            else
            {
                if ((gobj10.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj10.transform.localPosition = new Vector3(Mathf.Clamp(gobj10.transform.localPosition.x, -202, 230), gobj10.transform.localPosition.y,
                    Mathf.Clamp(gobj10.transform.localPosition.z, -55, 130));
                }
                else
                {
                    if ((gobj10.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj10.transform.localPosition = new Vector3(Mathf.Clamp(gobj10.transform.localPosition.x, -205, 262), gobj10.transform.localPosition.y,
                        Mathf.Clamp(gobj10.transform.localPosition.z, -55, 155));
                    }
                }


            }

        }

        //pièce 12
        if ((gobj11.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj11.transform.localPosition = new Vector3(Mathf.Clamp(gobj11.transform.localPosition.x, -230, 248), gobj11.transform.localPosition.y,
            Mathf.Clamp(gobj11.transform.localPosition.z, -60, 126));
        }
        else
        {
            if ((gobj11.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj11.transform.localPosition = new Vector3(Mathf.Clamp(gobj11.transform.localPosition.x, -212, 282), gobj11.transform.localPosition.y,
                Mathf.Clamp(gobj11.transform.localPosition.z, -60, 151));
            }
            else
            {
                if ((gobj11.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj11.transform.localPosition = new Vector3(Mathf.Clamp(gobj11.transform.localPosition.x, -202, 230), gobj11.transform.localPosition.y,
                    Mathf.Clamp(gobj11.transform.localPosition.z, -60, 126));
                }
                else
                {
                    if ((gobj11.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj11.transform.localPosition = new Vector3(Mathf.Clamp(gobj11.transform.localPosition.x, -207, 262), gobj11.transform.localPosition.y,
                        Mathf.Clamp(gobj11.transform.localPosition.z, -60, 151));
                    }
                }


            }

        }

        //pièce 13
        if ((gobj12.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj12.transform.localPosition = new Vector3(Mathf.Clamp(gobj12.transform.localPosition.x, -232, 248), gobj12.transform.localPosition.y,
            Mathf.Clamp(gobj12.transform.localPosition.z, -65, 122));
        }
        else
        {
            if ((gobj12.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj12.transform.localPosition = new Vector3(Mathf.Clamp(gobj12.transform.localPosition.x, -212, 284), gobj12.transform.localPosition.y,
                Mathf.Clamp(gobj12.transform.localPosition.z, -65, 147));
            }
            else
            {
                if ((gobj12.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj12.transform.localPosition = new Vector3(Mathf.Clamp(gobj12.transform.localPosition.x, -203, 230), gobj12.transform.localPosition.y,
                    Mathf.Clamp(gobj12.transform.localPosition.z, -65, 122));
                }
                else
                {
                    if ((gobj12.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj12.transform.localPosition = new Vector3(Mathf.Clamp(gobj12.transform.localPosition.x, -207, 262), gobj12.transform.localPosition.y,
                        Mathf.Clamp(gobj12.transform.localPosition.z, -65, 145));
                    }
                }


            }

        }

        //pièce 14
        if ((gobj13.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj13.transform.localPosition = new Vector3(Mathf.Clamp(gobj13.transform.localPosition.x, -232, 256), gobj13.transform.localPosition.y,
            Mathf.Clamp(gobj13.transform.localPosition.z, -70, 121));
        }
        else
        {
            if ((gobj13.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj13.transform.localPosition = new Vector3(Mathf.Clamp(gobj13.transform.localPosition.x, -210, 284), gobj13.transform.localPosition.y,
                Mathf.Clamp(gobj13.transform.localPosition.z, -70, 141));
            }
            else
            {
                if ((gobj13.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj13.transform.localPosition = new Vector3(Mathf.Clamp(gobj13.transform.localPosition.x, -203, 230), gobj13.transform.localPosition.y,
                    Mathf.Clamp(gobj13.transform.localPosition.z, -70, 119));
                }
                else
                {
                    if ((gobj13.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj13.transform.localPosition = new Vector3(Mathf.Clamp(gobj13.transform.localPosition.x, -212, 262), gobj13.transform.localPosition.y,
                        Mathf.Clamp(gobj13.transform.localPosition.z, -70, 140));
                    }
                }


            }

        }


        //pièce 15
        if ((gobj14.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj14.transform.localPosition = new Vector3(Mathf.Clamp(gobj14.transform.localPosition.x, -233, 270), gobj14.transform.localPosition.y,
            Mathf.Clamp(gobj14.transform.localPosition.z, -75, 120));
        }
        else
        {
            if ((gobj14.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj14.transform.localPosition = new Vector3(Mathf.Clamp(gobj14.transform.localPosition.x, -210, 284), gobj14.transform.localPosition.y,
                Mathf.Clamp(gobj14.transform.localPosition.z, -75, 135));
            }
            else
            {
                if ((gobj14.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj14.transform.localPosition = new Vector3(Mathf.Clamp(gobj14.transform.localPosition.x, -204, 230), gobj14.transform.localPosition.y,
                    Mathf.Clamp(gobj14.transform.localPosition.z, -75, 116));
                }
                else
                {
                    if ((gobj14.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj14.transform.localPosition = new Vector3(Mathf.Clamp(gobj14.transform.localPosition.x, -219, 264), gobj14.transform.localPosition.y,
                        Mathf.Clamp(gobj14.transform.localPosition.z, -75, 136));
                    }
                }


            }

        }


        //pièce 16
        if ((gobj15.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj15.transform.localPosition = new Vector3(Mathf.Clamp(gobj15.transform.localPosition.x, -233, 272), gobj15.transform.localPosition.y,
            Mathf.Clamp(gobj15.transform.localPosition.z, -80, 116));
        }
        else
        {
            if ((gobj15.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj15.transform.localPosition = new Vector3(Mathf.Clamp(gobj15.transform.localPosition.x, -211, 284), gobj15.transform.localPosition.y,
                Mathf.Clamp(gobj15.transform.localPosition.z, -80, 131));
            }
            else
            {
                if ((gobj15.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj15.transform.localPosition = new Vector3(Mathf.Clamp(gobj15.transform.localPosition.x, -205, 254), gobj15.transform.localPosition.y,
                    Mathf.Clamp(gobj15.transform.localPosition.z, -80, 112));
                }
                else
                {
                    if ((gobj15.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj15.transform.localPosition = new Vector3(Mathf.Clamp(gobj15.transform.localPosition.x, -227, 264), gobj15.transform.localPosition.y,
                        Mathf.Clamp(gobj15.transform.localPosition.z, -80, 131));
                    }
                }


            }

        }


        //pièce 17
        if ((gobj16.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj16.transform.localPosition = new Vector3(Mathf.Clamp(gobj16.transform.localPosition.x, -232, 281), gobj16.transform.localPosition.y,
            Mathf.Clamp(gobj16.transform.localPosition.z, -85, 112));
        }
        else
        {
            if ((gobj16.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj16.transform.localPosition = new Vector3(Mathf.Clamp(gobj16.transform.localPosition.x, -211, 284), gobj16.transform.localPosition.y,
                Mathf.Clamp(gobj16.transform.localPosition.z, -85, 127));
            }
            else
            {
                if ((gobj16.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj16.transform.localPosition = new Vector3(Mathf.Clamp(gobj16.transform.localPosition.x, -206, 254), gobj16.transform.localPosition.y,
                    Mathf.Clamp(gobj16.transform.localPosition.z, -85, 108));
                }
                else
                {
                    if ((gobj16.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj16.transform.localPosition = new Vector3(Mathf.Clamp(gobj16.transform.localPosition.x, -230, 265), gobj16.transform.localPosition.y,
                        Mathf.Clamp(gobj16.transform.localPosition.z, -85, 127));
                    }
                }


            }

        }


        //pièce 18
        if ((gobj17.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj17.transform.localPosition = new Vector3(Mathf.Clamp(gobj17.transform.localPosition.x, -232, 285), gobj17.transform.localPosition.y,
            Mathf.Clamp(gobj17.transform.localPosition.z, -90, 106));
        }
        else
        {
            if ((gobj17.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj17.transform.localPosition = new Vector3(Mathf.Clamp(gobj17.transform.localPosition.x, -211, 284), gobj17.transform.localPosition.y,
                Mathf.Clamp(gobj17.transform.localPosition.z, -90, 123));
            }
            else
            {
                if ((gobj17.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj17.transform.localPosition = new Vector3(Mathf.Clamp(gobj17.transform.localPosition.x, -207, 255), gobj17.transform.localPosition.y,
                    Mathf.Clamp(gobj17.transform.localPosition.z, -90, 104));
                }
                else
                {
                    if ((gobj17.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj17.transform.localPosition = new Vector3(Mathf.Clamp(gobj17.transform.localPosition.x, -234, 266), gobj17.transform.localPosition.y,
                        Mathf.Clamp(gobj17.transform.localPosition.z, -90, 123));
                    }
                }


            }

        }

        //pièce 19
        if ((gobj18.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj18.transform.localPosition = new Vector3(Mathf.Clamp(gobj18.transform.localPosition.x, -223, 280), gobj18.transform.localPosition.y,
            Mathf.Clamp(gobj18.transform.localPosition.z, -95, 96));
        }
        else
        {
            if ((gobj18.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj18.transform.localPosition = new Vector3(Mathf.Clamp(gobj18.transform.localPosition.x, -211, 283), gobj18.transform.localPosition.y,
                Mathf.Clamp(gobj18.transform.localPosition.z, -95, 118));
            }
            else
            {
                if ((gobj18.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj18.transform.localPosition = new Vector3(Mathf.Clamp(gobj18.transform.localPosition.x, -209, 255), gobj18.transform.localPosition.y,
                    Mathf.Clamp(gobj18.transform.localPosition.z, -95, 100));
                }
                else
                {
                    if ((gobj18.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj18.transform.localPosition = new Vector3(Mathf.Clamp(gobj18.transform.localPosition.x, -235, 267), gobj18.transform.localPosition.y,
                        Mathf.Clamp(gobj18.transform.localPosition.z, -95, 119));
                    }
                }


            }

        }


        //pièce 20
        if ((gobj19.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj19.transform.localPosition = new Vector3(Mathf.Clamp(gobj19.transform.localPosition.x, -224, 281), gobj19.transform.localPosition.y,
            Mathf.Clamp(gobj19.transform.localPosition.z, -100, 92));
        }
        else
        {
            if ((gobj19.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj19.transform.localPosition = new Vector3(Mathf.Clamp(gobj19.transform.localPosition.x, -211, 285), gobj19.transform.localPosition.y,
                Mathf.Clamp(gobj19.transform.localPosition.z, -100, 114));
            }
            else
            {
                if ((gobj19.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj19.transform.localPosition = new Vector3(Mathf.Clamp(gobj19.transform.localPosition.x, -211, 255), gobj19.transform.localPosition.y,
                    Mathf.Clamp(gobj19.transform.localPosition.z, -100, 96));
                }
                else
                {
                    if ((gobj19.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj19.transform.localPosition = new Vector3(Mathf.Clamp(gobj19.transform.localPosition.x, -235, 268), gobj19.transform.localPosition.y,
                        Mathf.Clamp(gobj19.transform.localPosition.z, -100, 113));
                    }
                }


            }

        }

        //pièce 21
        if ((gobj20.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj20.transform.localPosition = new Vector3(Mathf.Clamp(gobj20.transform.localPosition.x, -225, 280), gobj20.transform.localPosition.y,
            Mathf.Clamp(gobj20.transform.localPosition.z, -105, 88));
        }
        else
        {
            if ((gobj20.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj20.transform.localPosition = new Vector3(Mathf.Clamp(gobj20.transform.localPosition.x, -212, 287), gobj20.transform.localPosition.y,
                Mathf.Clamp(gobj20.transform.localPosition.z, -105, 109));
            }
            else
            {
                if ((gobj20.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj20.transform.localPosition = new Vector3(Mathf.Clamp(gobj20.transform.localPosition.x, -213, 255), gobj20.transform.localPosition.y,
                    Mathf.Clamp(gobj20.transform.localPosition.z, -105, 91));
                }
                else
                {
                    if ((gobj20.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj20.transform.localPosition = new Vector3(Mathf.Clamp(gobj20.transform.localPosition.x, -236, 270), gobj20.transform.localPosition.y,
                        Mathf.Clamp(gobj20.transform.localPosition.z, -105, 109));
                    }
                }


            }

        }

        //pièce 22
        if ((gobj21.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj21.transform.localPosition = new Vector3(Mathf.Clamp(gobj21.transform.localPosition.x, -227, 281), gobj21.transform.localPosition.y,
            Mathf.Clamp(gobj21.transform.localPosition.z, -110, 84));
        }
        else
        {
            if ((gobj21.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj21.transform.localPosition = new Vector3(Mathf.Clamp(gobj21.transform.localPosition.x, -213, 289), gobj21.transform.localPosition.y,
                Mathf.Clamp(gobj21.transform.localPosition.z, -110, 105));
            }
            else
            {
                if ((gobj21.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj21.transform.localPosition = new Vector3(Mathf.Clamp(gobj21.transform.localPosition.x, -213, 256), gobj21.transform.localPosition.y,
                    Mathf.Clamp(gobj21.transform.localPosition.z, -110, 87));
                }
                else
                {
                    if ((gobj21.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj21.transform.localPosition = new Vector3(Mathf.Clamp(gobj21.transform.localPosition.x, -237, 270), gobj21.transform.localPosition.y,
                        Mathf.Clamp(gobj21.transform.localPosition.z, -110, 104));
                    }
                }


            }

        }


        //pièce 23
        if ((gobj22.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj22.transform.localPosition = new Vector3(Mathf.Clamp(gobj22.transform.localPosition.x, -227, 281), gobj22.transform.localPosition.y,
            Mathf.Clamp(gobj22.transform.localPosition.z, -115, 80));
        }
        else
        {
            if ((gobj22.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj22.transform.localPosition = new Vector3(Mathf.Clamp(gobj22.transform.localPosition.x, -214, 290), gobj22.transform.localPosition.y,
                Mathf.Clamp(gobj22.transform.localPosition.z, -115, 100));
            }
            else
            {
                if ((gobj22.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj22.transform.localPosition = new Vector3(Mathf.Clamp(gobj22.transform.localPosition.x, -213, 256), gobj22.transform.localPosition.y,
                    Mathf.Clamp(gobj22.transform.localPosition.z, -115, 83));
                }
                else
                {
                    if ((gobj22.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj22.transform.localPosition = new Vector3(Mathf.Clamp(gobj22.transform.localPosition.x, -237, 270), gobj22.transform.localPosition.y,
                        Mathf.Clamp(gobj22.transform.localPosition.z, -115, 100));
                    }
                }


            }

        }

        //pièce 24
        if ((gobj23.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj23.transform.localPosition = new Vector3(Mathf.Clamp(gobj23.transform.localPosition.x, -227, 281), gobj23.transform.localPosition.y,
            Mathf.Clamp(gobj23.transform.localPosition.z, -110, 75));
        }
        else
        {
            if ((gobj23.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj23.transform.localPosition = new Vector3(Mathf.Clamp(gobj23.transform.localPosition.x, -214, 291), gobj23.transform.localPosition.y,
                Mathf.Clamp(gobj23.transform.localPosition.z, -110, 96));
            }
            else
            {
                if ((gobj23.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj23.transform.localPosition = new Vector3(Mathf.Clamp(gobj23.transform.localPosition.x, -213, 258), gobj23.transform.localPosition.y,
                    Mathf.Clamp(gobj23.transform.localPosition.z, -110, 79));
                }
                else
                {
                    if ((gobj23.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj23.transform.localPosition = new Vector3(Mathf.Clamp(gobj23.transform.localPosition.x, -238, 270), gobj23.transform.localPosition.y,
                        Mathf.Clamp(gobj23.transform.localPosition.z, -110, 95));
                    }
                }


            }

        }


        //pièce 25
        if ((gobj24.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj24.transform.localPosition = new Vector3(Mathf.Clamp(gobj24.transform.localPosition.x, -228, 278), gobj24.transform.localPosition.y,
            Mathf.Clamp(gobj24.transform.localPosition.z, -115, 68));
        }
        else
        {
            if ((gobj24.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj24.transform.localPosition = new Vector3(Mathf.Clamp(gobj24.transform.localPosition.x, -215, 291), gobj24.transform.localPosition.y,
                Mathf.Clamp(gobj24.transform.localPosition.z, -115, 91));
            }
            else
            {
                if ((gobj24.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj24.transform.localPosition = new Vector3(Mathf.Clamp(gobj24.transform.localPosition.x, -214, 259), gobj24.transform.localPosition.y,
                    Mathf.Clamp(gobj24.transform.localPosition.z, -115, 76));
                }
                else
                {
                    if ((gobj24.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj24.transform.localPosition = new Vector3(Mathf.Clamp(gobj24.transform.localPosition.x, -238, 270), gobj24.transform.localPosition.y,
                        Mathf.Clamp(gobj24.transform.localPosition.z, -115, 90));
                    }
                }


            }

        }


        //pièce 26
        if ((gobj25.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj25.transform.localPosition = new Vector3(Mathf.Clamp(gobj25.transform.localPosition.x, -216, 276), gobj25.transform.localPosition.y,
            Mathf.Clamp(gobj25.transform.localPosition.z, -120, 62));
        }
        else
        {
            if ((gobj25.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj25.transform.localPosition = new Vector3(Mathf.Clamp(gobj25.transform.localPosition.x, -218, 283), gobj25.transform.localPosition.y,
                Mathf.Clamp(gobj25.transform.localPosition.z, -120, 87));
            }
            else
            {
                if ((gobj25.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj25.transform.localPosition = new Vector3(Mathf.Clamp(gobj25.transform.localPosition.x, -214, 263), gobj25.transform.localPosition.y,
                    Mathf.Clamp(gobj25.transform.localPosition.z, -120, 73));
                }
                else
                {
                    if ((gobj25.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj25.transform.localPosition = new Vector3(Mathf.Clamp(gobj25.transform.localPosition.x, -241, 271), gobj25.transform.localPosition.y,
                        Mathf.Clamp(gobj25.transform.localPosition.z, -120, 86));
                    }
                }


            }

        }

        //pièce 27
        if ((gobj26.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj26.transform.localPosition = new Vector3(Mathf.Clamp(gobj26.transform.localPosition.x, -212, 273), gobj26.transform.localPosition.y,
            Mathf.Clamp(gobj26.transform.localPosition.z, -125, 55));
        }
        else
        {
            if ((gobj26.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj26.transform.localPosition = new Vector3(Mathf.Clamp(gobj26.transform.localPosition.x, -219, 278), gobj26.transform.localPosition.y,
                Mathf.Clamp(gobj26.transform.localPosition.z, -125, 82));
            }
            else
            {
                if ((gobj26.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj26.transform.localPosition = new Vector3(Mathf.Clamp(gobj26.transform.localPosition.x, -214, 264), gobj26.transform.localPosition.y,
                    Mathf.Clamp(gobj26.transform.localPosition.z, -125, 69));
                }
                else
                {
                    if ((gobj26.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj26.transform.localPosition = new Vector3(Mathf.Clamp(gobj26.transform.localPosition.x, -240, 270), gobj26.transform.localPosition.y,
                        Mathf.Clamp(gobj26.transform.localPosition.z, -125, 82));
                    }
                }


            }

        }


        //pièce 28
        if ((gobj27.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj27.transform.localPosition = new Vector3(Mathf.Clamp(gobj27.transform.localPosition.x, -212, 269), gobj27.transform.localPosition.y,
            Mathf.Clamp(gobj27.transform.localPosition.z, -130, 50));
        }
        else
        {
            if ((gobj27.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj27.transform.localPosition = new Vector3(Mathf.Clamp(gobj27.transform.localPosition.x, -219, 278), gobj27.transform.localPosition.y,
                Mathf.Clamp(gobj27.transform.localPosition.z, -130, 78));
            }
            else
            {
                if ((gobj27.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj27.transform.localPosition = new Vector3(Mathf.Clamp(gobj27.transform.localPosition.x, -214, 266), gobj27.transform.localPosition.y,
                    Mathf.Clamp(gobj27.transform.localPosition.z, -130, 65));
                }
                else
                {
                    if ((gobj27.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj27.transform.localPosition = new Vector3(Mathf.Clamp(gobj27.transform.localPosition.x, -234, 270), gobj27.transform.localPosition.y,
                        Mathf.Clamp(gobj27.transform.localPosition.z, -130, 77));
                    }
                }


            }

        }


        //pièce 29
        if ((gobj28.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj28.transform.localPosition = new Vector3(Mathf.Clamp(gobj28.transform.localPosition.x, -218, 269), gobj28.transform.localPosition.y,
            Mathf.Clamp(gobj28.transform.localPosition.z, -135, 47));
        }
        else
        {
            if ((gobj28.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj28.transform.localPosition = new Vector3(Mathf.Clamp(gobj28.transform.localPosition.x, -220, 280), gobj28.transform.localPosition.y,
                Mathf.Clamp(gobj28.transform.localPosition.z, -135, 73));
            }
            else
            {
                if ((gobj28.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj28.transform.localPosition = new Vector3(Mathf.Clamp(gobj28.transform.localPosition.x, -214, 266), gobj28.transform.localPosition.y,
                    Mathf.Clamp(gobj28.transform.localPosition.z, -135, 61));
                }
                else
                {
                    if ((gobj28.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj28.transform.localPosition = new Vector3(Mathf.Clamp(gobj28.transform.localPosition.x, -233, 270), gobj28.transform.localPosition.y,
                        Mathf.Clamp(gobj28.transform.localPosition.z, -135, 73));
                    }
                }


            }

        }

        //pièce 30
        if ((gobj29.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj29.transform.localPosition = new Vector3(Mathf.Clamp(gobj29.transform.localPosition.x, -220, 266), gobj29.transform.localPosition.y,
            Mathf.Clamp(gobj29.transform.localPosition.z, -145, 44));
        }
        else
        {
            if ((gobj29.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj29.transform.localPosition = new Vector3(Mathf.Clamp(gobj29.transform.localPosition.x, -220, 283), gobj29.transform.localPosition.y,
                Mathf.Clamp(gobj29.transform.localPosition.z, -145,68));
            }
            else
            {
                if ((gobj29.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj29.transform.localPosition = new Vector3(Mathf.Clamp(gobj29.transform.localPosition.x, -214, 266), gobj29.transform.localPosition.y,
                    Mathf.Clamp(gobj29.transform.localPosition.z, -145, 57));
                }
                else
                {
                    if ((gobj29.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj29.transform.localPosition = new Vector3(Mathf.Clamp(gobj29.transform.localPosition.x, -233, 270), gobj29.transform.localPosition.y,
                        Mathf.Clamp(gobj29.transform.localPosition.z, -145, 68));
                    }
                }


            }

        }

        //pièce 31
        if ((gobj30.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj30.transform.localPosition = new Vector3(Mathf.Clamp(gobj30.transform.localPosition.x, -223, 269), gobj30.transform.localPosition.y,
            Mathf.Clamp(gobj30.transform.localPosition.z, -145, 44));
        }
        else
        {
            if ((gobj30.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj30.transform.localPosition = new Vector3(Mathf.Clamp(gobj30.transform.localPosition.x, -222, 285), gobj30.transform.localPosition.y,
                Mathf.Clamp(gobj30.transform.localPosition.z, -145, 64));
            }
            else
            {
                if ((gobj30.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj30.transform.localPosition = new Vector3(Mathf.Clamp(gobj30.transform.localPosition.x, -216, 269), gobj30.transform.localPosition.y,
                    Mathf.Clamp(gobj30.transform.localPosition.z, -145, 53));
                }
                else
                {
                    if ((gobj30.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj30.transform.localPosition = new Vector3(Mathf.Clamp(gobj30.transform.localPosition.x, -233, 270), gobj30.transform.localPosition.y,
                        Mathf.Clamp(gobj30.transform.localPosition.z, -145, 64));
                    }
                }


            }

        }


        //pièce 32
        if ((gobj31.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj31.transform.localPosition = new Vector3(Mathf.Clamp(gobj31.transform.localPosition.x, -229, 274), gobj31.transform.localPosition.y,
            Mathf.Clamp(gobj31.transform.localPosition.z, -150, 43));
        }
        else
        {
            if ((gobj31.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj31.transform.localPosition = new Vector3(Mathf.Clamp(gobj31.transform.localPosition.x, -222, 290), gobj31.transform.localPosition.y,
                Mathf.Clamp(gobj31.transform.localPosition.z, -150, 59));
            }
            else
            {
                if ((gobj31.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj31.transform.localPosition = new Vector3(Mathf.Clamp(gobj31.transform.localPosition.x, -216, 269), gobj31.transform.localPosition.y,
                    Mathf.Clamp(gobj31.transform.localPosition.z, -150, 50));
                }
                else
                {
                    if ((gobj31.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj31.transform.localPosition = new Vector3(Mathf.Clamp(gobj31.transform.localPosition.x, -237, 270), gobj31.transform.localPosition.y,
                        Mathf.Clamp(gobj31.transform.localPosition.z, -150, 59));
                    }
                }


            }

        }


        //pièce 33
        if ((gobj32.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj32.transform.localPosition = new Vector3(Mathf.Clamp(gobj32.transform.localPosition.x, -233, 283), gobj32.transform.localPosition.y,
            Mathf.Clamp(gobj32.transform.localPosition.z, -155, 42));
        }
        else
        {
            if ((gobj32.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj32.transform.localPosition = new Vector3(Mathf.Clamp(gobj32.transform.localPosition.x, -224, 292), gobj32.transform.localPosition.y,
                Mathf.Clamp(gobj32.transform.localPosition.z, -155, 55));
            }
            else
            {
                if ((gobj32.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj32.transform.localPosition = new Vector3(Mathf.Clamp(gobj32.transform.localPosition.x, -216, 272), gobj32.transform.localPosition.y,
                    Mathf.Clamp(gobj32.transform.localPosition.z, -155, 46));
                }
                else
                {
                    if ((gobj32.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj32.transform.localPosition = new Vector3(Mathf.Clamp(gobj32.transform.localPosition.x, -247, 272), gobj32.transform.localPosition.y,
                        Mathf.Clamp(gobj32.transform.localPosition.z, -155, 54));
                    }
                }


            }

        }


        //pièce 34
        if ((gobj33.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj33.transform.localPosition = new Vector3(Mathf.Clamp(gobj33.transform.localPosition.x, -236, 289), gobj33.transform.localPosition.y,
            Mathf.Clamp(gobj33.transform.localPosition.z, -160, 40));
        }
        else
        {
            if ((gobj33.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj33.transform.localPosition = new Vector3(Mathf.Clamp(gobj33.transform.localPosition.x, -227, 294), gobj33.transform.localPosition.y,
                Mathf.Clamp(gobj33.transform.localPosition.z, -160, 50));
            }
            else
            {
                if ((gobj33.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj33.transform.localPosition = new Vector3(Mathf.Clamp(gobj33.transform.localPosition.x, -216, 272), gobj33.transform.localPosition.y,
                    Mathf.Clamp(gobj33.transform.localPosition.z, -160, 42));
                }
                else
                {
                    if ((gobj33.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj33.transform.localPosition = new Vector3(Mathf.Clamp(gobj33.transform.localPosition.x, -247, 271), gobj33.transform.localPosition.y,
                        Mathf.Clamp(gobj33.transform.localPosition.z, -160, 50));
                    }
                }


            }

        }

        //pièce 35
        if ((gobj34.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj34.transform.localPosition = new Vector3(Mathf.Clamp(gobj34.transform.localPosition.x, -239, 292), gobj34.transform.localPosition.y,
            Mathf.Clamp(gobj34.transform.localPosition.z, -165, 37));
        }
        else
        {
            if ((gobj34.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj34.transform.localPosition = new Vector3(Mathf.Clamp(gobj34.transform.localPosition.x, -228, 294), gobj34.transform.localPosition.y,
                Mathf.Clamp(gobj34.transform.localPosition.z, -165, 46));
            }
            else
            {
                if ((gobj34.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj34.transform.localPosition = new Vector3(Mathf.Clamp(gobj34.transform.localPosition.x, -217, 276), gobj34.transform.localPosition.y,
                    Mathf.Clamp(gobj34.transform.localPosition.z, -165, 38));
                }
                else
                {
                    if ((gobj34.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj34.transform.localPosition = new Vector3(Mathf.Clamp(gobj34.transform.localPosition.x, -247, 271), gobj34.transform.localPosition.y,
                        Mathf.Clamp(gobj34.transform.localPosition.z, -165, 46));
                    }
                }


            }

        }

        //pièce 36
        if ((gobj35.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj35.transform.localPosition = new Vector3(Mathf.Clamp(gobj35.transform.localPosition.x, -250, 298), gobj35.transform.localPosition.y,
            Mathf.Clamp(gobj35.transform.localPosition.z, -165, 30));
        }
        else
        {
            if ((gobj35.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj35.transform.localPosition = new Vector3(Mathf.Clamp(gobj35.transform.localPosition.x, -231, 296), gobj35.transform.localPosition.y,
                Mathf.Clamp(gobj35.transform.localPosition.z, -165, 41));
            }
            else
            {
                if ((gobj35.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj35.transform.localPosition = new Vector3(Mathf.Clamp(gobj35.transform.localPosition.x, -219, 281), gobj35.transform.localPosition.y,
                    Mathf.Clamp(gobj35.transform.localPosition.z, -165, 34));
                }
                else
                {
                    if ((gobj35.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj35.transform.localPosition = new Vector3(Mathf.Clamp(gobj35.transform.localPosition.x,-244, 273), gobj35.transform.localPosition.y,
                        Mathf.Clamp(gobj35.transform.localPosition.z, -165, 41));
                    }
                }


            }

        }


        //pièce 37
        if ((gobj36.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj36.transform.localPosition = new Vector3(Mathf.Clamp(gobj36.transform.localPosition.x, -250, 299), gobj36.transform.localPosition.y,
            Mathf.Clamp(gobj36.transform.localPosition.z, -175, 25));
        }
        else
        {
            if ((gobj36.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj36.transform.localPosition = new Vector3(Mathf.Clamp(gobj36.transform.localPosition.x, -232, 297), gobj36.transform.localPosition.y,
                Mathf.Clamp(gobj36.transform.localPosition.z, -175, 36));
            }
            else
            {
                if ((gobj36.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj36.transform.localPosition = new Vector3(Mathf.Clamp(gobj36.transform.localPosition.x, -222, 281), gobj36.transform.localPosition.y,
                    Mathf.Clamp(gobj36.transform.localPosition.z, -175, 30));
                }
                else
                {
                    if ((gobj36.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj36.transform.localPosition = new Vector3(Mathf.Clamp(gobj36.transform.localPosition.x, -245, 278), gobj36.transform.localPosition.y,
                        Mathf.Clamp(gobj36.transform.localPosition.z, -175, 36));
                    }
                }


            }

        }

        //pièce 38
        if ((gobj37.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj37.transform.localPosition = new Vector3(Mathf.Clamp(gobj37.transform.localPosition.x, -247, 299), gobj37.transform.localPosition.y,
            Mathf.Clamp(gobj37.transform.localPosition.z, -180, 20));
        }
        else
        {
            if ((gobj37.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj37.transform.localPosition = new Vector3(Mathf.Clamp(gobj37.transform.localPosition.x, -234, 297), gobj37.transform.localPosition.y,
                Mathf.Clamp(gobj37.transform.localPosition.z, -180, 32));
            }
            else
            {
                if ((gobj37.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj37.transform.localPosition = new Vector3(Mathf.Clamp(gobj37.transform.localPosition.x, -229, 284), gobj37.transform.localPosition.y,
                    Mathf.Clamp(gobj37.transform.localPosition.z, -180, 29));
                }
                else
                {
                    if ((gobj37.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj37.transform.localPosition = new Vector3(Mathf.Clamp(gobj37.transform.localPosition.x, -245, 280), gobj37.transform.localPosition.y,
                        Mathf.Clamp(gobj37.transform.localPosition.z, -180, 32));
                    }
                }


            }

        }



        //pièce 39
        if ((gobj38.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj38.transform.localPosition = new Vector3(Mathf.Clamp(gobj38.transform.localPosition.x, -248, 299), gobj38.transform.localPosition.y,
            Mathf.Clamp(gobj38.transform.localPosition.z, -185, 15));
        }
        else
        {
            if ((gobj38.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj38.transform.localPosition = new Vector3(Mathf.Clamp(gobj38.transform.localPosition.x, -237, 296), gobj38.transform.localPosition.y,
                Mathf.Clamp(gobj38.transform.localPosition.z, -185, 28));
            }
            else
            {
                if ((gobj38.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj38.transform.localPosition = new Vector3(Mathf.Clamp(gobj38.transform.localPosition.x, -234, 289), gobj38.transform.localPosition.y,
                    Mathf.Clamp(gobj38.transform.localPosition.z, -185, 25));
                }
                else
                {
                    if ((gobj38.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj38.transform.localPosition = new Vector3(Mathf.Clamp(gobj38.transform.localPosition.x, -245, 284), gobj38.transform.localPosition.y,
                        Mathf.Clamp(gobj38.transform.localPosition.z, -185,28));
                    }
                }


            }

        }


        //pièce 40
        if ((gobj39.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj39.transform.localPosition = new Vector3(Mathf.Clamp(gobj39.transform.localPosition.x, -248, 302), gobj39.transform.localPosition.y,
            Mathf.Clamp(gobj39.transform.localPosition.z, -190, 12));
        }
        else
        {
            if ((gobj39.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj39.transform.localPosition = new Vector3(Mathf.Clamp(gobj39.transform.localPosition.x, -240, 296), gobj39.transform.localPosition.y,
                Mathf.Clamp(gobj39.transform.localPosition.z, -190, 24));
            }
            else
            {
                if ((gobj39.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj39.transform.localPosition = new Vector3(Mathf.Clamp(gobj39.transform.localPosition.x, -238, 293), gobj39.transform.localPosition.y,
                    Mathf.Clamp(gobj39.transform.localPosition.z, -190, 23));
                }
                else
                {
                    if ((gobj39.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj39.transform.localPosition = new Vector3(Mathf.Clamp(gobj39.transform.localPosition.x, -246, 288), gobj39.transform.localPosition.y,
                        Mathf.Clamp(gobj39.transform.localPosition.z, -190, 23));
                    }
                }


            }

        }


        //pièce 41
        if ((gobj40.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj40.transform.localPosition = new Vector3(Mathf.Clamp(gobj40.transform.localPosition.x, -250, 302), gobj40.transform.localPosition.y,
            Mathf.Clamp(gobj40.transform.localPosition.z, -195, 9));
        }
        else
        {
            if ((gobj40.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj40.transform.localPosition = new Vector3(Mathf.Clamp(gobj40.transform.localPosition.x, -241, 298), gobj40.transform.localPosition.y,
                Mathf.Clamp(gobj40.transform.localPosition.z, -195,19));
            }
            else
            {
                if ((gobj40.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj40.transform.localPosition = new Vector3(Mathf.Clamp(gobj40.transform.localPosition.x, -242, 294), gobj40.transform.localPosition.y,
                    Mathf.Clamp(gobj40.transform.localPosition.z, -195, 19));
                }
                else
                {
                    if ((gobj40.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj40.transform.localPosition = new Vector3(Mathf.Clamp(gobj40.transform.localPosition.x, -247, 291), gobj40.transform.localPosition.y,
                        Mathf.Clamp(gobj40.transform.localPosition.z, -195, 19));
                    }
                }


            }

        }


        //pièce 42
        if ((gobj41.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj41.transform.localPosition = new Vector3(Mathf.Clamp(gobj41.transform.localPosition.x, -254, 305), gobj41.transform.localPosition.y,
            Mathf.Clamp(gobj41.transform.localPosition.z, -200, 7));
        }
        else
        {
            if ((gobj41.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj41.transform.localPosition = new Vector3(Mathf.Clamp(gobj41.transform.localPosition.x, -243, 303), gobj41.transform.localPosition.y,
                Mathf.Clamp(gobj41.transform.localPosition.z, -200, 15));
            }
            else
            {
                if ((gobj41.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj41.transform.localPosition = new Vector3(Mathf.Clamp(gobj41.transform.localPosition.x, -247, 297), gobj41.transform.localPosition.y,
                    Mathf.Clamp(gobj41.transform.localPosition.z, -200, 17));
                }
                else
                {
                    if ((gobj41.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj41.transform.localPosition = new Vector3(Mathf.Clamp(gobj41.transform.localPosition.x, -248, 293), gobj41.transform.localPosition.y,
                        Mathf.Clamp(gobj41.transform.localPosition.z, -200, 14));
                    }
                }


            }

        }

        //pièce 43
        if ((gobj42.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj42.transform.localPosition = new Vector3(Mathf.Clamp(gobj42.transform.localPosition.x, -266, 309), gobj42.transform.localPosition.y,
            Mathf.Clamp(gobj42.transform.localPosition.z, -205, 9));
        }
        else
        {
            if ((gobj42.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj42.transform.localPosition = new Vector3(Mathf.Clamp(gobj42.transform.localPosition.x, -245, 309), gobj42.transform.localPosition.y,
                Mathf.Clamp(gobj42.transform.localPosition.z, -205, 11));
            }
            else
            {
                if ((gobj42.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj42.transform.localPosition = new Vector3(Mathf.Clamp(gobj42.transform.localPosition.x, -250, 300), gobj42.transform.localPosition.y,
                    Mathf.Clamp(gobj42.transform.localPosition.z, -205, 13));
                }
                else
                {
                    if ((gobj42.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj42.transform.localPosition = new Vector3(Mathf.Clamp(gobj42.transform.localPosition.x, -252, 295), gobj42.transform.localPosition.y,
                        Mathf.Clamp(gobj42.transform.localPosition.z, -205, 10));
                    }
                }


            }

        }


        //pièce 44
        if ((gobj43.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj43.transform.localPosition = new Vector3(Mathf.Clamp(gobj43.transform.localPosition.x, -278, 329), gobj43.transform.localPosition.y,
            Mathf.Clamp(gobj43.transform.localPosition.z, -210, 14));
        }
        else
        {
            if ((gobj43.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj43.transform.localPosition = new Vector3(Mathf.Clamp(gobj43.transform.localPosition.x, -267, 324), gobj43.transform.localPosition.y,
                Mathf.Clamp(gobj43.transform.localPosition.z, -210, 14));
            }
            else
            {
                if ((gobj43.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj43.transform.localPosition = new Vector3(Mathf.Clamp(gobj43.transform.localPosition.x, -264, 314), gobj43.transform.localPosition.y,
                    Mathf.Clamp(gobj43.transform.localPosition.z, -210, 11));
                }
                else
                {
                    if ((gobj43.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj43.transform.localPosition = new Vector3(Mathf.Clamp(gobj43.transform.localPosition.x, -272, 315), gobj43.transform.localPosition.y,
                        Mathf.Clamp(gobj43.transform.localPosition.z, -210, 12));
                    }
                }


            }

        }
    }

}
