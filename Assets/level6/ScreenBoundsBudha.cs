using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenBoundsBudha : MonoBehaviour
{
    public GameObject gobj, gobj1, gobj2, gobj3, gobj4, gobj5, gobj6, gobj7, gobj8, gobj9, gobj10, gobj11, gobj12, gobj13, gobj14,
                      gobj15, gobj16, gobj17, gobj18, gobj19, gobj20, gobj21, gobj22, gobj23, gobj24, gobj25, gobj26, gobj27,
                      gobj28, gobj29, gobj30, gobj31, gobj32, gobj33, gobj34, gobj35, gobj36, gobj37, gobj38, gobj39, gobj40,
                      gobj41, gobj42;



   void Update()

    {
        //pièce 1
        if ((gobj.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj.transform.localPosition = new Vector3(Mathf.Clamp(gobj.transform.localPosition.x, -249,(float) 101.5), gobj.transform.localPosition.y,
            Mathf.Clamp(gobj.transform.localPosition.z, -5, 129));
        }
        else
        {
            if ((gobj.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj.transform.localPosition = new Vector3(Mathf.Clamp(gobj.transform.localPosition.x, -241, 95), gobj.transform.localPosition.y,
                Mathf.Clamp(gobj.transform.localPosition.z, -5, 120));
            }
            else
            {
                if ((gobj.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj.transform.localPosition = new Vector3(Mathf.Clamp(gobj.transform.localPosition.x, -246, 98), gobj.transform.localPosition.y,
                    Mathf.Clamp(gobj.transform.localPosition.z, -5, 129));
                }
                else
                {
                    if ((gobj.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj.transform.localPosition = new Vector3(Mathf.Clamp(gobj.transform.localPosition.x, -243, 92), gobj.transform.localPosition.y,
                        Mathf.Clamp(gobj.transform.localPosition.z, -5, 120));
                    }
                }


            }

        }

        //pièce 2
        if ((gobj1.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj1.transform.localPosition = new Vector3(Mathf.Clamp(gobj1.transform.localPosition.x, -249, (float)101.5), gobj1.transform.localPosition.y,
            Mathf.Clamp(gobj1.transform.localPosition.z, -10, 125));
        }
        else
        {
            if ((gobj1.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj1.transform.localPosition = new Vector3(Mathf.Clamp(gobj1.transform.localPosition.x, -241, 95), gobj1.transform.localPosition.y,
                Mathf.Clamp(gobj1.transform.localPosition.z, -10, 116));
            }
            else
            {
                if ((gobj1.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj1.transform.localPosition = new Vector3(Mathf.Clamp(gobj1.transform.localPosition.x, -246, 98), gobj1.transform.localPosition.y,
                    Mathf.Clamp(gobj1.transform.localPosition.z, -10, 126));
                }
                else
                {
                    if ((gobj1.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj1.transform.localPosition = new Vector3(Mathf.Clamp(gobj1.transform.localPosition.x, -243, 92), gobj1.transform.localPosition.y,
                        Mathf.Clamp(gobj1.transform.localPosition.z, -10, 116));
                    }
                }


            }

        }

        //pièce 3
        if ((gobj2.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj2.transform.localPosition = new Vector3(Mathf.Clamp(gobj2.transform.localPosition.x, -253, 105), gobj2.transform.localPosition.y,
            Mathf.Clamp(gobj2.transform.localPosition.z, -13, 121));
        }
        else
        {
            if ((gobj2.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj2.transform.localPosition = new Vector3(Mathf.Clamp(gobj2.transform.localPosition.x, -241, 97), gobj2.transform.localPosition.y,
                Mathf.Clamp(gobj2.transform.localPosition.z, -13, 113));
            }
            else
            {
                if ((gobj2.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj2.transform.localPosition = new Vector3(Mathf.Clamp(gobj2.transform.localPosition.x, -248, 100), gobj2.transform.localPosition.y,
                    Mathf.Clamp(gobj2.transform.localPosition.z, -13, 123));
                }
                else
                {
                    if ((gobj2.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj2.transform.localPosition = new Vector3(Mathf.Clamp(gobj2.transform.localPosition.x, -246, 92), gobj2.transform.localPosition.y,
                        Mathf.Clamp(gobj2.transform.localPosition.z, -13, 112));
                    }
                }


            }

        }

        //pièce 4
        if ((gobj3.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj3.transform.localPosition = new Vector3(Mathf.Clamp(gobj3.transform.localPosition.x, -256, 108), gobj3.transform.localPosition.y,
            Mathf.Clamp(gobj3.transform.localPosition.z, -18, 118));
        }
        else
        {
            if ((gobj3.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj3.transform.localPosition = new Vector3(Mathf.Clamp(gobj3.transform.localPosition.x, -244, 109), gobj3.transform.localPosition.y,
                Mathf.Clamp(gobj3.transform.localPosition.z, -18, 111));
            }
            else
            {
                if ((gobj3.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj3.transform.localPosition = new Vector3(Mathf.Clamp(gobj3.transform.localPosition.x, -248, 100), gobj3.transform.localPosition.y,
                    Mathf.Clamp(gobj3.transform.localPosition.z, -18, 119));
                }
                else
                {
                    if ((gobj3.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj3.transform.localPosition = new Vector3(Mathf.Clamp(gobj3.transform.localPosition.x, -251, 96), gobj3.transform.localPosition.y,
                        Mathf.Clamp(gobj3.transform.localPosition.z, -18, 110));
                    }
                }


            }

        }


        //pièce 5
        if ((gobj4.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj4.transform.localPosition = new Vector3(Mathf.Clamp(gobj4.transform.localPosition.x, -264, 116), gobj4.transform.localPosition.y,
            Mathf.Clamp(gobj4.transform.localPosition.z, -22, 114));
        }
        else
        {
            if ((gobj4.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj4.transform.localPosition = new Vector3(Mathf.Clamp(gobj4.transform.localPosition.x, -257, 111), gobj4.transform.localPosition.y,
                Mathf.Clamp(gobj4.transform.localPosition.z, -22, 109));
            }
            else
            {
                if ((gobj4.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj4.transform.localPosition = new Vector3(Mathf.Clamp(gobj4.transform.localPosition.x, -259, 110), gobj4.transform.localPosition.y,
                    Mathf.Clamp(gobj4.transform.localPosition.z, -22, 118));
                }
                else
                {
                    if ((gobj4.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj4.transform.localPosition = new Vector3(Mathf.Clamp(gobj4.transform.localPosition.x, -260, 101), gobj4.transform.localPosition.y,
                        Mathf.Clamp(gobj4.transform.localPosition.z, -22, 110));
                    }
                }


            }

        }

        //pièce 6
        if ((gobj5.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj5.transform.localPosition = new Vector3(Mathf.Clamp(gobj5.transform.localPosition.x, -268, 121), gobj5.transform.localPosition.y,
            Mathf.Clamp(gobj5.transform.localPosition.z, -27, 113));
        }
        else
        {
            if ((gobj5.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj5.transform.localPosition = new Vector3(Mathf.Clamp(gobj5.transform.localPosition.x, -259, 119), gobj5.transform.localPosition.y,
                Mathf.Clamp(gobj5.transform.localPosition.z, -27, 108));
            }
            else
            {
                if ((gobj5.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj5.transform.localPosition = new Vector3(Mathf.Clamp(gobj5.transform.localPosition.x, -259, 119), gobj5.transform.localPosition.y,
                    Mathf.Clamp(gobj5.transform.localPosition.z, -27, 117));
                }
                else
                {
                    if ((gobj5.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj5.transform.localPosition = new Vector3(Mathf.Clamp(gobj5.transform.localPosition.x, -269, 105), gobj5.transform.localPosition.y,
                        Mathf.Clamp(gobj5.transform.localPosition.z, -27, 107));
                    }
                }


            }

        }

        //pièce 7
        if ((gobj6.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj6.transform.localPosition = new Vector3(Mathf.Clamp(gobj6.transform.localPosition.x, -281, 132), gobj6.transform.localPosition.y,
            Mathf.Clamp(gobj6.transform.localPosition.z, -30, 110));
        }
        else
        {
            if ((gobj6.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj6.transform.localPosition = new Vector3(Mathf.Clamp(gobj6.transform.localPosition.x, -285, 132), gobj6.transform.localPosition.y,
                Mathf.Clamp(gobj6.transform.localPosition.z, -30, 117));
            }
            else
            {
                if ((gobj6.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj6.transform.localPosition = new Vector3(Mathf.Clamp(gobj6.transform.localPosition.x, -272, 136), gobj6.transform.localPosition.y,
                    Mathf.Clamp(gobj6.transform.localPosition.z, -30, 120));
                }
                else
                {
                    if ((gobj6.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj6.transform.localPosition = new Vector3(Mathf.Clamp(gobj6.transform.localPosition.x, -280, 116), gobj6.transform.localPosition.y,
                        Mathf.Clamp(gobj6.transform.localPosition.z, -30, 109));
                    }
                }


            }

        }

        //pièce 8
        if ((gobj7.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj7.transform.localPosition = new Vector3(Mathf.Clamp(gobj7.transform.localPosition.x, -299, 148), gobj7.transform.localPosition.y,
            Mathf.Clamp(gobj7.transform.localPosition.z, -36, 110));
        }
        else
        {
            if ((gobj7.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj7.transform.localPosition = new Vector3(Mathf.Clamp(gobj7.transform.localPosition.x, -286, 138), gobj7.transform.localPosition.y,
                Mathf.Clamp(gobj7.transform.localPosition.z, -36, 110));
            }
            else
            {
                if ((gobj7.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj7.transform.localPosition = new Vector3(Mathf.Clamp(gobj7.transform.localPosition.x, -297, 138), gobj7.transform.localPosition.y,
                    Mathf.Clamp(gobj7.transform.localPosition.z, -36, 117));
                }
                else
                {
                    if ((gobj7.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj7.transform.localPosition = new Vector3(Mathf.Clamp(gobj7.transform.localPosition.x, -289, 139), gobj7.transform.localPosition.y,
                        Mathf.Clamp(gobj7.transform.localPosition.z, -36, 109));
                    }
                }


            }

        }

        //pièce 9
        if ((gobj8.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj8.transform.localPosition = new Vector3(Mathf.Clamp(gobj8.transform.localPosition.x, -298, 150), gobj8.transform.localPosition.y,
            Mathf.Clamp(gobj8.transform.localPosition.z, -40, 113));
        }
        else
        {
            if ((gobj8.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj8.transform.localPosition = new Vector3(Mathf.Clamp(gobj8.transform.localPosition.x, -288, 137), gobj8.transform.localPosition.y,
                Mathf.Clamp(gobj8.transform.localPosition.z, -40, 104));
            }
            else
            {
                if ((gobj8.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj8.transform.localPosition = new Vector3(Mathf.Clamp(gobj8.transform.localPosition.x, -322, 140), gobj8.transform.localPosition.y,
                    Mathf.Clamp(gobj8.transform.localPosition.z, -40, 113));
                }
                else
                {
                    if ((gobj8.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj8.transform.localPosition = new Vector3(Mathf.Clamp(gobj8.transform.localPosition.x, -285, 146), gobj8.transform.localPosition.y,
                        Mathf.Clamp(gobj8.transform.localPosition.z, -40, 104));
                    }
                }


            }

        }

        //pièce 10
        if ((gobj9.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj9.transform.localPosition = new Vector3(Mathf.Clamp(gobj9.transform.localPosition.x, -298, 150), gobj9.transform.localPosition.y,
            Mathf.Clamp(gobj9.transform.localPosition.z, -45, 121));
        }
        else
        {
            if ((gobj9.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj9.transform.localPosition = new Vector3(Mathf.Clamp(gobj9.transform.localPosition.x, -288, 135), gobj9.transform.localPosition.y,
                Mathf.Clamp(gobj9.transform.localPosition.z, -45, 99));
            }
            else
            {
                if ((gobj9.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj9.transform.localPosition = new Vector3(Mathf.Clamp(gobj9.transform.localPosition.x, -322, 140), gobj9.transform.localPosition.y,
                    Mathf.Clamp(gobj9.transform.localPosition.z, -45, 107));
                }
                else
                {
                    if ((gobj9.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj9.transform.localPosition = new Vector3(Mathf.Clamp(gobj9.transform.localPosition.x, -283, 146), gobj9.transform.localPosition.y,
                        Mathf.Clamp(gobj9.transform.localPosition.z, -45, 98));
                    }
                }


            }

        }

        //pièce 11
        if ((gobj10.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj10.transform.localPosition = new Vector3(Mathf.Clamp(gobj10.transform.localPosition.x, -298, 150), gobj10.transform.localPosition.y,
            Mathf.Clamp(gobj10.transform.localPosition.z, -50, 119));
        }
        else
        {
            if ((gobj10.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj10.transform.localPosition = new Vector3(Mathf.Clamp(gobj10.transform.localPosition.x, -288, 135), gobj10.transform.localPosition.y,
                Mathf.Clamp(gobj10.transform.localPosition.z, -50, 97));
            }
            else
            {
                if ((gobj10.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj10.transform.localPosition = new Vector3(Mathf.Clamp(gobj10.transform.localPosition.x, -322, 140), gobj10.transform.localPosition.y,
                    Mathf.Clamp(gobj10.transform.localPosition.z, -50, 104));
                }
                else
                {
                    if ((gobj10.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj10.transform.localPosition = new Vector3(Mathf.Clamp(gobj10.transform.localPosition.x, -286, 146), gobj10.transform.localPosition.y,
                        Mathf.Clamp(gobj10.transform.localPosition.z, -50, 96));
                    }
                }


            }

        }

        //pièce 12
        if ((gobj11.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj11.transform.localPosition = new Vector3(Mathf.Clamp(gobj11.transform.localPosition.x, -305, 156), gobj11.transform.localPosition.y,
            Mathf.Clamp(gobj11.transform.localPosition.z, -53, 116));
        }
        else
        {
            if ((gobj11.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj11.transform.localPosition = new Vector3(Mathf.Clamp(gobj11.transform.localPosition.x, -288, 135), gobj11.transform.localPosition.y,
                Mathf.Clamp(gobj11.transform.localPosition.z, -53, 96));
            }
            else
            {
                if ((gobj11.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj11.transform.localPosition = new Vector3(Mathf.Clamp(gobj11.transform.localPosition.x, -322, 143), gobj11.transform.localPosition.y,
                    Mathf.Clamp(gobj11.transform.localPosition.z, -53, 100));
                }
                else
                {
                    if ((gobj11.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj11.transform.localPosition = new Vector3(Mathf.Clamp(gobj11.transform.localPosition.x, -296, 146), gobj11.transform.localPosition.y,
                        Mathf.Clamp(gobj11.transform.localPosition.z, -53, 93));
                    }
                }


            }

        }

        //pièce 13
        if ((gobj12.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj12.transform.localPosition = new Vector3(Mathf.Clamp(gobj12.transform.localPosition.x, -323, 170), gobj12.transform.localPosition.y,
            Mathf.Clamp(gobj12.transform.localPosition.z, -55, 116));
        }
        else
        {
            if ((gobj12.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj12.transform.localPosition = new Vector3(Mathf.Clamp(gobj12.transform.localPosition.x, -290, 166), gobj12.transform.localPosition.y,
                Mathf.Clamp(gobj12.transform.localPosition.z, -55, 98));
            }
            else
            {
                if ((gobj12.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj12.transform.localPosition = new Vector3(Mathf.Clamp(gobj12.transform.localPosition.x, -325, 143), gobj12.transform.localPosition.y,
                    Mathf.Clamp(gobj12.transform.localPosition.z, -55, 96));
                }
                else
                {
                    if ((gobj12.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj12.transform.localPosition = new Vector3(Mathf.Clamp(gobj12.transform.localPosition.x, -325, 145), gobj12.transform.localPosition.y,
                        Mathf.Clamp(gobj12.transform.localPosition.z, -55, 91));
                    }
                }


            }

        }

        //pièce 14
        if ((gobj13.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj13.transform.localPosition = new Vector3(Mathf.Clamp(gobj13.transform.localPosition.x, -326, 186), gobj13.transform.localPosition.y,
            Mathf.Clamp(gobj13.transform.localPosition.z, -53, 116));
        }
        else
        {
            if ((gobj13.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj13.transform.localPosition = new Vector3(Mathf.Clamp(gobj13.transform.localPosition.x, -290, 166), gobj13.transform.localPosition.y,
                Mathf.Clamp(gobj13.transform.localPosition.z, -53, 93));
            }
            else
            {
                if ((gobj13.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj13.transform.localPosition = new Vector3(Mathf.Clamp(gobj13.transform.localPosition.x, -328, 144), gobj13.transform.localPosition.y,
                    Mathf.Clamp(gobj13.transform.localPosition.z, -53, 92));
                }
                else
                {
                    if ((gobj13.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj13.transform.localPosition = new Vector3(Mathf.Clamp(gobj13.transform.localPosition.x, -325, 172), gobj13.transform.localPosition.y,
                        Mathf.Clamp(gobj13.transform.localPosition.z, -53, 92));
                    }
                }


            }

        }

        //pièce 15
        if ((gobj14.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj14.transform.localPosition = new Vector3(Mathf.Clamp(gobj14.transform.localPosition.x, -325, 208), gobj14.transform.localPosition.y,
            Mathf.Clamp(gobj14.transform.localPosition.z, -60, 111));
        }
        else
        {
            if ((gobj14.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj14.transform.localPosition = new Vector3(Mathf.Clamp(gobj14.transform.localPosition.x, -290, 163), gobj14.transform.localPosition.y,
                Mathf.Clamp(gobj14.transform.localPosition.z, -60, 88));
            }
            else
            {
                if ((gobj14.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj14.transform.localPosition = new Vector3(Mathf.Clamp(gobj14.transform.localPosition.x, -327, 144), gobj14.transform.localPosition.y,
                    Mathf.Clamp(gobj14.transform.localPosition.z, -60, 88));
                }
                else
                {
                    if ((gobj14.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj14.transform.localPosition = new Vector3(Mathf.Clamp(gobj14.transform.localPosition.x, -330, 167), gobj14.transform.localPosition.y,
                        Mathf.Clamp(gobj14.transform.localPosition.z, -60, 85));
                    }
                }


            }

        }


        //pièce 16
        if ((gobj15.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj15.transform.localPosition = new Vector3(Mathf.Clamp(gobj15.transform.localPosition.x, -325, 205), gobj15.transform.localPosition.y,
            Mathf.Clamp(gobj15.transform.localPosition.z, -60, 107));
        }
        else
        {
            if ((gobj15.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj15.transform.localPosition = new Vector3(Mathf.Clamp(gobj15.transform.localPosition.x, -290, 163), gobj15.transform.localPosition.y,
                Mathf.Clamp(gobj15.transform.localPosition.z, -60, 82));
            }
            else
            {
                if ((gobj15.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj15.transform.localPosition = new Vector3(Mathf.Clamp(gobj15.transform.localPosition.x, -327, 144), gobj15.transform.localPosition.y,
                    Mathf.Clamp(gobj15.transform.localPosition.z, -60, 82));
                }
                else
                {
                    if ((gobj15.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj15.transform.localPosition = new Vector3(Mathf.Clamp(gobj15.transform.localPosition.x, -328, 166), gobj15.transform.localPosition.y,
                        Mathf.Clamp(gobj15.transform.localPosition.z, -60, 80));
                    }
                }


            }

        }


        //pièce 17
        if ((gobj16.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj16.transform.localPosition = new Vector3(Mathf.Clamp(gobj16.transform.localPosition.x, -325, 205), gobj16.transform.localPosition.y,
            Mathf.Clamp(gobj16.transform.localPosition.z, -65, 102));
        }
        else
        {
            if ((gobj16.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj16.transform.localPosition = new Vector3(Mathf.Clamp(gobj16.transform.localPosition.x, -290, 163), gobj16.transform.localPosition.y,
                Mathf.Clamp(gobj16.transform.localPosition.z, -65, 79));
            }
            else
            {
                if ((gobj16.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj16.transform.localPosition = new Vector3(Mathf.Clamp(gobj16.transform.localPosition.x, -327, 144), gobj16.transform.localPosition.y,
                    Mathf.Clamp(gobj16.transform.localPosition.z, -65, 79));
                }
                else
                {
                    if ((gobj16.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj16.transform.localPosition = new Vector3(Mathf.Clamp(gobj16.transform.localPosition.x, -328, 166), gobj16.transform.localPosition.y,
                        Mathf.Clamp(gobj16.transform.localPosition.z, -65, 76));
                    }
                }


            }

        }

        //pièce 18
        if ((gobj17.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj17.transform.localPosition = new Vector3(Mathf.Clamp(gobj17.transform.localPosition.x, -328, 174), gobj17.transform.localPosition.y,
            Mathf.Clamp(gobj17.transform.localPosition.z, -70, 93));
        }
        else
        {
            if ((gobj17.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj17.transform.localPosition = new Vector3(Mathf.Clamp(gobj17.transform.localPosition.x, -292, 164), gobj17.transform.localPosition.y,
                Mathf.Clamp(gobj17.transform.localPosition.z, -70, 73));
            }
            else
            {
                if ((gobj17.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj17.transform.localPosition = new Vector3(Mathf.Clamp(gobj17.transform.localPosition.x, -327, 144), gobj17.transform.localPosition.y,
                    Mathf.Clamp(gobj17.transform.localPosition.z, -70, 75));
                }
                else
                {
                    if ((gobj17.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj17.transform.localPosition = new Vector3(Mathf.Clamp(gobj17.transform.localPosition.x, -310, 169), gobj17.transform.localPosition.y,
                        Mathf.Clamp(gobj17.transform.localPosition.z, -70, 74));
                    }
                }


            }

        }


        //pièce 19
        if ((gobj18.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj18.transform.localPosition = new Vector3(Mathf.Clamp(gobj18.transform.localPosition.x, -330, 171), gobj18.transform.localPosition.y,
            Mathf.Clamp(gobj18.transform.localPosition.z, -75, 88));
        }
        else
        {
            if ((gobj18.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj18.transform.localPosition = new Vector3(Mathf.Clamp(gobj18.transform.localPosition.x, -290, 166), gobj18.transform.localPosition.y,
                Mathf.Clamp(gobj18.transform.localPosition.z, -75, 67));
            }
            else
            {
                if ((gobj18.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj18.transform.localPosition = new Vector3(Mathf.Clamp(gobj18.transform.localPosition.x, -317, 146), gobj18.transform.localPosition.y,
                    Mathf.Clamp(gobj18.transform.localPosition.z, -75, 72));
                }
                else
                {
                    if ((gobj18.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj18.transform.localPosition = new Vector3(Mathf.Clamp(gobj18.transform.localPosition.x, -308, 163), gobj18.transform.localPosition.y,
                        Mathf.Clamp(gobj18.transform.localPosition.z, -75, 70));
                    }
                }


            }

        }


        //pièce 20
        if ((gobj19.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj19.transform.localPosition = new Vector3(Mathf.Clamp(gobj19.transform.localPosition.x, -337, 170), gobj19.transform.localPosition.y,
            Mathf.Clamp(gobj19.transform.localPosition.z, -80, 82));
        }
        else
        {
            if ((gobj19.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj19.transform.localPosition = new Vector3(Mathf.Clamp(gobj19.transform.localPosition.x, -285, 172), gobj19.transform.localPosition.y,
                Mathf.Clamp(gobj19.transform.localPosition.z, -80, 60));
            }
            else
            {
                if ((gobj19.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj19.transform.localPosition = new Vector3(Mathf.Clamp(gobj19.transform.localPosition.x, -292, 143), gobj19.transform.localPosition.y,
                    Mathf.Clamp(gobj19.transform.localPosition.z, -80, 68));
                }
                else
                {
                    if ((gobj19.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj19.transform.localPosition = new Vector3(Mathf.Clamp(gobj19.transform.localPosition.x, -306, 136), gobj19.transform.localPosition.y,
                        Mathf.Clamp(gobj19.transform.localPosition.z, -80, 60));
                    }
                }


            }

        }

        //pièce 21
        if ((gobj20.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj20.transform.localPosition = new Vector3(Mathf.Clamp(gobj20.transform.localPosition.x, -355, 168), gobj20.transform.localPosition.y,
            Mathf.Clamp(gobj20.transform.localPosition.z, -82, 77));
        }
        else
        {
            if ((gobj20.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj20.transform.localPosition = new Vector3(Mathf.Clamp(gobj20.transform.localPosition.x, -282, 190), gobj20.transform.localPosition.y,
                Mathf.Clamp(gobj20.transform.localPosition.z, -82, 53));
            }
            else
            {
                if ((gobj20.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj20.transform.localPosition = new Vector3(Mathf.Clamp(gobj20.transform.localPosition.x, -289, 141), gobj20.transform.localPosition.y,
                    Mathf.Clamp(gobj20.transform.localPosition.z, -82, 63));
                }
                else
                {
                    if ((gobj20.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj20.transform.localPosition = new Vector3(Mathf.Clamp(gobj20.transform.localPosition.x, -306, 134), gobj20.transform.localPosition.y,
                        Mathf.Clamp(gobj20.transform.localPosition.z, -82,53));
                    }
                }


            }

        }

        //pièce 22
        if ((gobj21.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj21.transform.localPosition = new Vector3(Mathf.Clamp(gobj21.transform.localPosition.x, -378, 166), gobj21.transform.localPosition.y,
            Mathf.Clamp(gobj21.transform.localPosition.z, -88, 70));
        }
        else
        {
            if ((gobj21.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj21.transform.localPosition = new Vector3(Mathf.Clamp(gobj21.transform.localPosition.x, -281, 194), gobj21.transform.localPosition.y,
                Mathf.Clamp(gobj21.transform.localPosition.z, -88, 48));
            }
            else
            {
                if ((gobj21.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj21.transform.localPosition = new Vector3(Mathf.Clamp(gobj21.transform.localPosition.x, -289, 141), gobj21.transform.localPosition.y,
                    Mathf.Clamp(gobj21.transform.localPosition.z, -88, 60));
                }
                else
                {
                    if ((gobj21.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj21.transform.localPosition = new Vector3(Mathf.Clamp(gobj21.transform.localPosition.x, -305, 132), gobj21.transform.localPosition.y,
                        Mathf.Clamp(gobj21.transform.localPosition.z, -88, 46));
                    }
                }


            }

        }

        //pièce 23
        if ((gobj22.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj22.transform.localPosition = new Vector3(Mathf.Clamp(gobj22.transform.localPosition.x, -378, 166), gobj22.transform.localPosition.y,
            Mathf.Clamp(gobj22.transform.localPosition.z, -92, 67));
        }
        else
        {
            if ((gobj22.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj22.transform.localPosition = new Vector3(Mathf.Clamp(gobj22.transform.localPosition.x, -279, 192), gobj22.transform.localPosition.y,
                Mathf.Clamp(gobj22.transform.localPosition.z, -92, 43));
            }
            else
            {
                if ((gobj22.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj22.transform.localPosition = new Vector3(Mathf.Clamp(gobj22.transform.localPosition.x,-288, 140), gobj22.transform.localPosition.y,
                    Mathf.Clamp(gobj22.transform.localPosition.z, -92, 55));
                }
                else
                {
                    if ((gobj22.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj22.transform.localPosition = new Vector3(Mathf.Clamp(gobj22.transform.localPosition.x, -305, 130), gobj22.transform.localPosition.y,
                        Mathf.Clamp(gobj22.transform.localPosition.z, -92, 43));
                    }
                }


            }

        }


        //pièce 24
        if ((gobj23.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj23.transform.localPosition = new Vector3(Mathf.Clamp(gobj23.transform.localPosition.x, -373, 218), gobj23.transform.localPosition.y,
            Mathf.Clamp(gobj23.transform.localPosition.z, -100, 83));
        }
        else
        {
            if ((gobj23.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj23.transform.localPosition = new Vector3(Mathf.Clamp(gobj23.transform.localPosition.x, -300,207), gobj23.transform.localPosition.y,
                Mathf.Clamp(gobj23.transform.localPosition.z, -100, 50));
            }
            else
            {
                if ((gobj23.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj23.transform.localPosition = new Vector3(Mathf.Clamp(gobj23.transform.localPosition.x, -289, 141), gobj23.transform.localPosition.y,
                    Mathf.Clamp(gobj23.transform.localPosition.z, -100, 50));
                }
                else
                {
                    if ((gobj23.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj23.transform.localPosition = new Vector3(Mathf.Clamp(gobj23.transform.localPosition.x, -357, 152), gobj23.transform.localPosition.y,
                        Mathf.Clamp(gobj23.transform.localPosition.z, -100,52));
                    }
                }


            }

        }

        //pièce 25
        if ((gobj24.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj24.transform.localPosition = new Vector3(Mathf.Clamp(gobj24.transform.localPosition.x, -370, 219), gobj24.transform.localPosition.y,
            Mathf.Clamp(gobj24.transform.localPosition.z, -105,79));
        }
        else
        {
            if ((gobj24.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj24.transform.localPosition = new Vector3(Mathf.Clamp(gobj24.transform.localPosition.x, -305, 209), gobj24.transform.localPosition.y,
                Mathf.Clamp(gobj24.transform.localPosition.z, -105, 49));
            }
            else
            {
                if ((gobj24.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj24.transform.localPosition = new Vector3(Mathf.Clamp(gobj24.transform.localPosition.x, -288, 140), gobj24.transform.localPosition.y,
                    Mathf.Clamp(gobj24.transform.localPosition.z, -105, 45));
                }
                else
                {
                    if ((gobj24.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj24.transform.localPosition = new Vector3(Mathf.Clamp(gobj24.transform.localPosition.x, -357, 155), gobj24.transform.localPosition.y,
                        Mathf.Clamp(gobj24.transform.localPosition.z, -105, 50));
                    }
                }


            }

        }

        //pièce 26
        if ((gobj25.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj25.transform.localPosition = new Vector3(Mathf.Clamp(gobj25.transform.localPosition.x, -358, 216), gobj25.transform.localPosition.y,
            Mathf.Clamp(gobj25.transform.localPosition.z, -105, 76));
        }
        else
        {
            if ((gobj25.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj25.transform.localPosition = new Vector3(Mathf.Clamp(gobj25.transform.localPosition.x, -308, 215), gobj25.transform.localPosition.y,
                Mathf.Clamp(gobj25.transform.localPosition.z, -105, 46));
            }
            else
            {
                if ((gobj25.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj25.transform.localPosition = new Vector3(Mathf.Clamp(gobj25.transform.localPosition.x, -288, 140), gobj25.transform.localPosition.y,
                    Mathf.Clamp(gobj25.transform.localPosition.z, -105, 40));
                }
                else
                {
                    if ((gobj25.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj25.transform.localPosition = new Vector3(Mathf.Clamp(gobj25.transform.localPosition.x, -362, 163), gobj25.transform.localPosition.y,
                        Mathf.Clamp(gobj25.transform.localPosition.z, -105, 46));
                    }
                }


            }

        }

        //pièce 27
        if ((gobj26.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj26.transform.localPosition = new Vector3(Mathf.Clamp(gobj26.transform.localPosition.x, -355, 213), gobj26.transform.localPosition.y,
            Mathf.Clamp(gobj26.transform.localPosition.z, -110, 72));
        }
        else
        {
            if ((gobj26.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj26.transform.localPosition = new Vector3(Mathf.Clamp(gobj26.transform.localPosition.x, -312, 216), gobj26.transform.localPosition.y,
                Mathf.Clamp(gobj26.transform.localPosition.z, -110, 42));
            }
            else
            {
                if ((gobj26.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj26.transform.localPosition = new Vector3(Mathf.Clamp(gobj26.transform.localPosition.x, -293, 142), gobj26.transform.localPosition.y,
                    Mathf.Clamp(gobj26.transform.localPosition.z, -110, 36));
                }
                else
                {
                    if ((gobj26.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj26.transform.localPosition = new Vector3(Mathf.Clamp(gobj26.transform.localPosition.x, -364, 164), gobj26.transform.localPosition.y,
                        Mathf.Clamp(gobj26.transform.localPosition.z, -110, 42));
                    }
                }


            }

        }


        //pièce 28
        if ((gobj27.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj27.transform.localPosition = new Vector3(Mathf.Clamp(gobj27.transform.localPosition.x, -352, 214), gobj27.transform.localPosition.y,
            Mathf.Clamp(gobj27.transform.localPosition.z, -113, 69));
        }
        else
        {
            if ((gobj27.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj27.transform.localPosition = new Vector3(Mathf.Clamp(gobj27.transform.localPosition.x, -315, 218), gobj27.transform.localPosition.y,
                Mathf.Clamp(gobj27.transform.localPosition.z, -113, 40));
            }
            else
            {
                if ((gobj27.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj27.transform.localPosition = new Vector3(Mathf.Clamp(gobj27.transform.localPosition.x, -297, 137), gobj27.transform.localPosition.y,
                    Mathf.Clamp(gobj27.transform.localPosition.z, -113, 31));
                }
                else
                {
                    if ((gobj27.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj27.transform.localPosition = new Vector3(Mathf.Clamp(gobj27.transform.localPosition.x, -368, 167), gobj27.transform.localPosition.y,
                        Mathf.Clamp(gobj27.transform.localPosition.z, -113, 39));
                    }
                }


            }

        }


        //pièce 29
        if ((gobj28.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj28.transform.localPosition = new Vector3(Mathf.Clamp(gobj28.transform.localPosition.x, -361, 214), gobj28.transform.localPosition.y,
            Mathf.Clamp(gobj28.transform.localPosition.z, -118, 64));
        }
        else
        {
            if ((gobj28.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj28.transform.localPosition = new Vector3(Mathf.Clamp(gobj28.transform.localPosition.x, -318, 220), gobj28.transform.localPosition.y,
                Mathf.Clamp(gobj28.transform.localPosition.z, -118, 37));
            }
            else
            {
                if ((gobj28.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj28.transform.localPosition = new Vector3(Mathf.Clamp(gobj28.transform.localPosition.x, -307, 135), gobj28.transform.localPosition.y,
                    Mathf.Clamp(gobj28.transform.localPosition.z, -118, 27));
                }
                else
                {
                    if ((gobj28.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj28.transform.localPosition = new Vector3(Mathf.Clamp(gobj28.transform.localPosition.x, -369, 169), gobj28.transform.localPosition.y,
                        Mathf.Clamp(gobj28.transform.localPosition.z, -118, 37));
                    }
                }


            }

        }


        //pièce 30
        if ((gobj29.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj29.transform.localPosition = new Vector3(Mathf.Clamp(gobj29.transform.localPosition.x, -379, 218), gobj29.transform.localPosition.y,
            Mathf.Clamp(gobj29.transform.localPosition.z, -122, 57));
        }
        else
        {
            if ((gobj29.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj29.transform.localPosition = new Vector3(Mathf.Clamp(gobj29.transform.localPosition.x, -323, 223), gobj29.transform.localPosition.y,
                Mathf.Clamp(gobj29.transform.localPosition.z, -122, 35));
            }
            else
            {
                if ((gobj29.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj29.transform.localPosition = new Vector3(Mathf.Clamp(gobj29.transform.localPosition.x, -309, 137), gobj29.transform.localPosition.y,
                    Mathf.Clamp(gobj29.transform.localPosition.z, -122, 24));
                }
                else
                {
                    if ((gobj29.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj29.transform.localPosition = new Vector3(Mathf.Clamp(gobj29.transform.localPosition.x, -369, 178), gobj29.transform.localPosition.y,
                        Mathf.Clamp(gobj29.transform.localPosition.z, -122, 36));
                    }
                }


            }

        }


        //pièce 31
        if ((gobj30.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj30.transform.localPosition = new Vector3(Mathf.Clamp(gobj30.transform.localPosition.x, -371, 218), gobj30.transform.localPosition.y,
            Mathf.Clamp(gobj30.transform.localPosition.z, -125, 61));
        }
        else
        {
            if ((gobj30.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj30.transform.localPosition = new Vector3(Mathf.Clamp(gobj30.transform.localPosition.x, -330, 235), gobj30.transform.localPosition.y,
                Mathf.Clamp(gobj30.transform.localPosition.z, -125, 38));
            }
            else
            {
                if ((gobj30.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj30.transform.localPosition = new Vector3(Mathf.Clamp(gobj30.transform.localPosition.x, -309, 143), gobj30.transform.localPosition.y,
                    Mathf.Clamp(gobj30.transform.localPosition.z, -125, 19));
                }
                else
                {
                    if ((gobj30.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj30.transform.localPosition = new Vector3(Mathf.Clamp(gobj30.transform.localPosition.x, -367, 182), gobj30.transform.localPosition.y,
                        Mathf.Clamp(gobj30.transform.localPosition.z, -125, 34));
                    }
                }


            }

        }


        //pièce 32
        if ((gobj31.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj31.transform.localPosition = new Vector3(Mathf.Clamp(gobj31.transform.localPosition.x, -402, 218), gobj31.transform.localPosition.y,
            Mathf.Clamp(gobj31.transform.localPosition.z, -131, 49));
        }
        else
        {
            if ((gobj31.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj31.transform.localPosition = new Vector3(Mathf.Clamp(gobj31.transform.localPosition.x, -333, 245), gobj31.transform.localPosition.y,
                Mathf.Clamp(gobj31.transform.localPosition.z, -131, 34));
            }
            else
            {
                if ((gobj31.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj31.transform.localPosition = new Vector3(Mathf.Clamp(gobj31.transform.localPosition.x, -309, 174), gobj31.transform.localPosition.y,
                    Mathf.Clamp(gobj31.transform.localPosition.z, -131, 15));
                }
                else
                {
                    if ((gobj31.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj31.transform.localPosition = new Vector3(Mathf.Clamp(gobj31.transform.localPosition.x, -367, 182), gobj31.transform.localPosition.y,
                        Mathf.Clamp(gobj31.transform.localPosition.z, -131, 31));
                    }
                }


            }

        }


        //pièce 33
        if ((gobj32.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj32.transform.localPosition = new Vector3(Mathf.Clamp(gobj32.transform.localPosition.x, -402, 213), gobj32.transform.localPosition.y,
            Mathf.Clamp(gobj32.transform.localPosition.z, -135, 49));
        }
        else
        {
            if ((gobj32.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj32.transform.localPosition = new Vector3(Mathf.Clamp(gobj32.transform.localPosition.x, -333, 247), gobj32.transform.localPosition.y,
                Mathf.Clamp(gobj32.transform.localPosition.z, -135, 30));
            }
            else
            {
                if ((gobj32.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj32.transform.localPosition = new Vector3(Mathf.Clamp(gobj32.transform.localPosition.x, -303, 176), gobj32.transform.localPosition.y,
                    Mathf.Clamp(gobj32.transform.localPosition.z, -135, 11));
                }
                else
                {
                    if ((gobj32.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj32.transform.localPosition = new Vector3(Mathf.Clamp(gobj32.transform.localPosition.x, -395, 185), gobj32.transform.localPosition.y,
                        Mathf.Clamp(gobj32.transform.localPosition.z, -135, 30));
                    }
                }


            }

        }



        //pièce 34
        if ((gobj33.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj33.transform.localPosition = new Vector3(Mathf.Clamp(gobj33.transform.localPosition.x, -400, 212), gobj33.transform.localPosition.y,
            Mathf.Clamp(gobj33.transform.localPosition.z, -140, 42));
        }
        else
        {
            if ((gobj33.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj33.transform.localPosition = new Vector3(Mathf.Clamp(gobj33.transform.localPosition.x, -335, 245), gobj33.transform.localPosition.y,
                Mathf.Clamp(gobj33.transform.localPosition.z, -140, 26));
            }
            else
            {
                if ((gobj33.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj33.transform.localPosition = new Vector3(Mathf.Clamp(gobj33.transform.localPosition.x, -303, 176), gobj33.transform.localPosition.y,
                    Mathf.Clamp(gobj33.transform.localPosition.z, -140, 7));
                }
                else
                {
                    if ((gobj33.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj33.transform.localPosition = new Vector3(Mathf.Clamp(gobj33.transform.localPosition.x, -393, 186), gobj33.transform.localPosition.y,
                        Mathf.Clamp(gobj33.transform.localPosition.z, -140, 27));
                    }
                }


            }

        }


        //pièce 35
        if ((gobj34.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj34.transform.localPosition = new Vector3(Mathf.Clamp(gobj34.transform.localPosition.x, -398, 214), gobj34.transform.localPosition.y,
            Mathf.Clamp(gobj34.transform.localPosition.z, -145, 40));
        }
        else
        {
            if ((gobj34.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj34.transform.localPosition = new Vector3(Mathf.Clamp(gobj34.transform.localPosition.x, -337, 244), gobj34.transform.localPosition.y,
                Mathf.Clamp(gobj34.transform.localPosition.z, -145, 25));
            }
            else
            {
                if ((gobj34.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj34.transform.localPosition = new Vector3(Mathf.Clamp(gobj34.transform.localPosition.x, -304, 180), gobj34.transform.localPosition.y,
                    Mathf.Clamp(gobj34.transform.localPosition.z, -145, 2));
                }
                else
                {
                    if ((gobj34.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj34.transform.localPosition = new Vector3(Mathf.Clamp(gobj34.transform.localPosition.x, -393, 188), gobj34.transform.localPosition.y,
                        Mathf.Clamp(gobj34.transform.localPosition.z, -145, 28));
                    }
                }


            }

        }

        //pièce 36
        if ((gobj35.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj35.transform.localPosition = new Vector3(Mathf.Clamp(gobj35.transform.localPosition.x, -400, 216), gobj35.transform.localPosition.y,
            Mathf.Clamp(gobj35.transform.localPosition.z, -150, 36));
        }
        else
        {
            if ((gobj35.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj35.transform.localPosition = new Vector3(Mathf.Clamp(gobj35.transform.localPosition.x, -337, 245), gobj35.transform.localPosition.y,
                Mathf.Clamp(gobj35.transform.localPosition.z, -150, 16));
            }
            else
            {
                if ((gobj35.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj35.transform.localRotation = Quaternion.Euler(0, 0, 270);
                }
                else
                {
                    if ((gobj35.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj35.transform.localPosition = new Vector3(Mathf.Clamp(gobj35.transform.localPosition.x, -393, 188), gobj35.transform.localPosition.y,
                        Mathf.Clamp(gobj35.transform.localPosition.z, -150, 16));
                    }
                }


            }

        }

        //pièce 37
        if ((gobj36.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj36.transform.localPosition = new Vector3(Mathf.Clamp(gobj36.transform.localPosition.x, -400, 216), gobj36.transform.localPosition.y,
            Mathf.Clamp(gobj36.transform.localPosition.z, -153, 31));
        }
        else
        {
            if ((gobj36.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj36.transform.localPosition = new Vector3(Mathf.Clamp(gobj36.transform.localPosition.x, -337, 245), gobj36.transform.localPosition.y,
                Mathf.Clamp(gobj36.transform.localPosition.z, -153, 12));
            }
            else
            {
                if ((gobj36.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj36.transform.localRotation = Quaternion.Euler(0, 0, 270);
                }
                else
                {
                    if ((gobj36.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj36.transform.localPosition = new Vector3(Mathf.Clamp(gobj36.transform.localPosition.x, -392, 188), gobj36.transform.localPosition.y,
                        Mathf.Clamp(gobj36.transform.localPosition.z, -153, 12));
                    }
                }


            }

        }


        //pièce 38
        if ((gobj37.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj37.transform.localPosition = new Vector3(Mathf.Clamp(gobj37.transform.localPosition.x, -400, 255), gobj37.transform.localPosition.y,
            Mathf.Clamp(gobj37.transform.localPosition.z, -157, 27));
        }
        else
        {
            if ((gobj37.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj37.transform.localPosition = new Vector3(Mathf.Clamp(gobj37.transform.localPosition.x, -337, 245), gobj37.transform.localPosition.y,
                Mathf.Clamp(gobj37.transform.localPosition.z, -157, 10));
            }
            else
            {
                if ((gobj37.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj37.transform.localRotation = Quaternion.Euler(0, 0, 270);
                }
                else
                {
                    if ((gobj37.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj37.transform.localPosition = new Vector3(Mathf.Clamp(gobj37.transform.localPosition.x, -392, 188), gobj37.transform.localPosition.y,
                        Mathf.Clamp(gobj37.transform.localPosition.z, -157, 10));
                    }
                }


            }

        }


        //pièce 39
        if ((gobj38.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj38.transform.localPosition = new Vector3(Mathf.Clamp(gobj38.transform.localPosition.x, -400, 252), gobj38.transform.localPosition.y,
            Mathf.Clamp(gobj38.transform.localPosition.z, -163, 24));
        }
        else
        {
            if ((gobj38.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj38.transform.localPosition = new Vector3(Mathf.Clamp(gobj38.transform.localPosition.x, -337, 245), gobj38.transform.localPosition.y,
                Mathf.Clamp(gobj38.transform.localPosition.z, -163, 6));
            }
            else
            {
                if ((gobj38.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj38.transform.localRotation = Quaternion.Euler(0, 0, 270);
                }
                else
                {
                    if ((gobj38.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj38.transform.localPosition = new Vector3(Mathf.Clamp(gobj38.transform.localPosition.x, -392, 190), gobj38.transform.localPosition.y,
                        Mathf.Clamp(gobj38.transform.localPosition.z, -163, 6));
                    }
                }


            }

        }

        //pièce 40
        if ((gobj39.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj39.transform.localPosition = new Vector3(Mathf.Clamp(gobj39.transform.localPosition.x, -404, 256), gobj39.transform.localPosition.y,
            Mathf.Clamp(gobj39.transform.localPosition.z, -167, 22));
        }
        else
        {
            if ((gobj39.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj39.transform.localPosition = new Vector3(Mathf.Clamp(gobj39.transform.localPosition.x, -342, 250), gobj39.transform.localPosition.y,
                Mathf.Clamp(gobj39.transform.localPosition.z, -167, 3));
            }
            else
            {
                if ((gobj39.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj39.transform.localRotation = Quaternion.Euler(0, 0, 270);
                }
                else
                {
                    if ((gobj39.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj39.transform.localPosition = new Vector3(Mathf.Clamp(gobj39.transform.localPosition.x, -394, 195), gobj39.transform.localPosition.y,
                        Mathf.Clamp(gobj39.transform.localPosition.z, -167, 3));
                    }
                }


            }

        }

        //pièce 41
        if ((gobj40.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj40.transform.localPosition = new Vector3(Mathf.Clamp(gobj40.transform.localPosition.x, -408, 258), gobj40.transform.localPosition.y,
            Mathf.Clamp(gobj40.transform.localPosition.z, -172, 20));
        }
        else
        {
            if ((gobj40.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj40.transform.localPosition = new Vector3(Mathf.Clamp(gobj40.transform.localPosition.x, -347, 250), gobj40.transform.localPosition.y,
                Mathf.Clamp(gobj40.transform.localPosition.z, -172, 1));
            }
            else
            {
                if ((gobj40.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj40.transform.localRotation = Quaternion.Euler(0, 0, 270);
                }
                else
                {
                    if ((gobj40.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj40.transform.localPosition = new Vector3(Mathf.Clamp(gobj40.transform.localPosition.x, -394, 199), gobj40.transform.localPosition.y,
                        Mathf.Clamp(gobj40.transform.localPosition.z, -172, 1));
                    }
                }


            }

        }


        //pièce 42
        if ((gobj41.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj41.transform.localPosition = new Vector3(Mathf.Clamp(gobj41.transform.localPosition.x, -411, 262), gobj41.transform.localPosition.y,
            Mathf.Clamp(gobj41.transform.localPosition.z, -176, 16));
        }
        else
        {
            if ((gobj41.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj41.transform.localPosition = new Vector3(Mathf.Clamp(gobj41.transform.localPosition.x, -349, 245), gobj41.transform.localPosition.y,
                Mathf.Clamp(gobj41.transform.localPosition.z, -176, 0));
            }
            else
            {
                if ((gobj41.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj41.transform.localRotation = Quaternion.Euler(0, 0, 0);
                }
                else
                {
                    if ((gobj41.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj41.transform.localRotation = Quaternion.Euler(0, 0, 0);
                    }
                }


            }

        }


        //pièce 43
        if ((gobj42.transform.localRotation == Quaternion.Euler(0, 0, 0)))

        {
            gobj42.transform.localPosition = new Vector3(Mathf.Clamp(gobj42.transform.localPosition.x, -417, 268), gobj42.transform.localPosition.y,
            Mathf.Clamp(gobj42.transform.localPosition.z, -182, 13));
        }
        else
        {
            if ((gobj42.transform.localRotation == Quaternion.Euler(0, 0, 90)))

            {
                gobj42.transform.localRotation = Quaternion.Euler(0, 0, 0);
            }
            else
            {
                if ((gobj42.transform.localRotation == Quaternion.Euler(0, 0, 180)))

                {
                    gobj42.transform.localRotation = Quaternion.Euler(0, 0, 0);
                }
                else
                {
                    if ((gobj42.transform.localRotation == Quaternion.Euler(0, 0, 270)))

                    {
                        gobj42.transform.localRotation = Quaternion.Euler(0, 0, 0);
                    }
                }


            }

        }
    }
}
