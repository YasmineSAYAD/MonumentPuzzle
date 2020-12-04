using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreTaj : MonoBehaviour
{
    [SerializeField]
    private int lastScore;
    public Text score,score1,time;
    public Button joker;
    public GameObject ChildElement3, ChildElement4, ChildElement5, ChildElement6, ChildElement7,
        ChildElement8, ChildElement9, ChildElement10, ChildElement11, ChildElement12, ChildElement13, ChildElement14,
        ChildElement15, ChildElement16, ChildElement17, ChildElement18, ChildElement19, ChildElement20, ChildElement21,
        ChildElement22, ChildElement23, ChildElement24, ChildElement25, ChildElement26, ChildElement27, ChildElement28,
        ChildElement29,image2, imageVect;

    int  i2 = 0, j2 = 0, i3 = 0, j3 = 0, i4 = 0, j4 = 0, i5 = 0, j5 = 0, i6 = 0, j6 = 0,
        i7 = 0, j7 = 0, i8 = 0, j8 = 0, i9 = 0, j9 = 0, i10 = 0, j10 = 0, i11 = 0, j11 = 0, i12 = 0, j12 = 0, i13 = 0, j13 = 0
        , i14 = 0, j14 = 0, i15 = 0, j15 = 0, i16 = 0, j16 = 0, i17 = 0, j17 = 0, i18 = 0, j18 = 0, i19 = 0, j19 = 0,
        i20 = 0, j20 = 0, i21 = 0, j21 = 0, i22 = 0, j22 = 0, i23 = 0, j23 = 0, i24 = 0, j24 = 0, i25 = 0, j25 = 0, 
        i26 = 0, j26= 0, i27 = 0, j27 = 0, i28 = 0, j28 = 0,imgv=0,imghist=0;
    public AudioSource source, sourceshortVic;
    public AudioClip clip, clipshortVic;

    void Start()
    {
        ZPlayerPrefs.Initialize("y1a2s3", "8745dsdfE7D8df8425SDmjgh4fgtR");
        lastScore = ZPlayerPrefs.GetInt("Score");
        ZPlayerPrefs.SetString("succes", "no");
    }


   
    void Update()
    {
        StartCoroutine(Score());
        score.text = lastScore + "";
        if (lastScore < 100)
        {
            joker.GetComponent<Button>().interactable = false;
        }
        else
        {
            joker.GetComponent<Button>().interactable = true;
        }


        if ((ChildElement3.transform.localPosition == new Vector3((float)-0.08180511, (float)-0.1923621, (float)-4.353579)) && i2 == 0)
        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i2 = 1;

        }

        if ((ChildElement3.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) && j2 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j2 = 1;

        }

        if ((ChildElement4.transform.localPosition == new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702)) && i3 == 0)
        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i3 = 1;

        }

        if ((ChildElement4.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) && j3 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j3 = 1;

        }

        if ((ChildElement5.transform.localPosition == new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702)) && i4 == 0)
        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i4 = 1;

        }

        if ((ChildElement5.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) && j4 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j4 = 1;

        }

        if ((ChildElement6.transform.localPosition == new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702)) && i5 == 0)
        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i5 = 1;

        }

        if ((ChildElement6.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) && j5 == 0)

        {
           source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j5 = 1;

        }
        if ((ChildElement7.transform.localPosition == new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702)) && i6 == 0)
        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i6 = 1;

        }

        if ((ChildElement7.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) && j6 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j6 = 1;

        }

        if ((ChildElement8.transform.localPosition == new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702)) && i7 == 0)
        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i7 = 1;

        }

        if ((ChildElement8.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) && j7 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j7 = 1;

        }
        if ((ChildElement9.transform.localPosition == new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702)) && i8 == 0)
        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i8 = 1;

        }

        if ((ChildElement9.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) && j8 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j8 = 1;

        }

        if ((ChildElement10.transform.localPosition == new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702)) && i9 == 0)
        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i9 = 1;

        }

        if ((ChildElement10.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) && j9 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j9 = 1;

        }

        if ((ChildElement11.transform.localPosition == new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702)) && i10 == 0)
        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i10 = 1;

        }

        if ((ChildElement11.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) && j10 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j10 = 1;

        }
        if ((ChildElement12.transform.localPosition == new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702)) && i11 == 0)
        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i11 = 1;

        }

        if ((ChildElement12.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) && j11 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j11 = 1;

        }
        if ((ChildElement13.transform.localPosition == new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702)) && i12== 0)
        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i12 = 1;

        }

        if ((ChildElement13.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) && j12 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j12 = 1;

        }
        if ((ChildElement14.transform.localPosition == new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702)) && i13 == 0)
        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i13 = 1;

        }

        if ((ChildElement14.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) && j13 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j13 = 1;

        }
        if ((ChildElement15.transform.localPosition == new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702)) && i14 == 0)
        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i14 = 1;

        }

        if ((ChildElement15.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) && j14 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j14 = 1;

        }
        if ((ChildElement16.transform.localPosition == new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702)) && i15 == 0)
        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i15 = 1;

        }

        if ((ChildElement16.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) && j15 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j15 = 1;

        }
        if ((ChildElement17.transform.localPosition == new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702)) && i16 == 0)
        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i16 = 1;

        }

        if ((ChildElement17.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) && j16 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j16 = 1;

        }
        if ((ChildElement18.transform.localPosition == new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702)) && i17 == 0)
        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i17 = 1;

        }

        if ((ChildElement18.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) && j17 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j17 = 1;

        }

        if ((ChildElement19.transform.localPosition == new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702)) && i18 == 0)
        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i18 = 1;

        }

        if ((ChildElement19.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) && j18 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j18 = 1;

        }

        if ((ChildElement20.transform.localPosition == new Vector3((float)1.252619, (float)-0.3987826, (float)-3.052516)) && i19 == 0)
        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i19 = 1;

        }

        if ((ChildElement20.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) && j19 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j19 = 1;

        }

        if ((ChildElement21.transform.localPosition == new Vector3((float)1.252619, (float)-0.3987826, (float)-3.052516)) && i20 == 0)
        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i20 = 1;

        }

        if ((ChildElement21.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) && j20 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j20 = 1;

        }

        if ((ChildElement22.transform.localPosition == new Vector3((float)1.252619, (float)-0.3987826, (float)-3.052516)) && i21 == 0)
        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i21 = 1;

        }

        if ((ChildElement22.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) && j21 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j21 = 1;

        }

        if ((ChildElement23.transform.localPosition == new Vector3((float)1.252619, (float)-0.3987826, (float)-3.052516)) && i22 == 0)
        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i22 = 1;

        }

        if ((ChildElement23.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) && j22 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j22 = 1;

        }

        if ((ChildElement24.transform.localPosition == new Vector3((float)2.00975, (float)-1.551666, (float)-4.396697)) && i23 == 0)
        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i23 = 1;

        }

        if ((ChildElement24.transform.localRotation == Quaternion.Euler((float)-90.00001, 0, (float)90.00001)) && j23 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j23 = 1;

        }
        if ((ChildElement25.transform.localPosition == new Vector3((float)2.00975, (float)-1.551666, (float)-4.396697)) && i24 == 0)
        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i24 = 1;

        }

        if ((ChildElement25.transform.localRotation == Quaternion.Euler((float)-90.00001, 0, (float)90.00001)) && j24 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j24 = 1;

        }

        if ((ChildElement26.transform.localPosition == new Vector3((float)2.00975, (float)-1.551666, (float)-4.396697)) && i25 == 0)
        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i25 = 1;

        }

        if ((ChildElement26.transform.localRotation == Quaternion.Euler((float)-90.00001, 0, (float)90.00001)) && j25 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j25 = 1;

        }

        if ((ChildElement27.transform.localPosition == new Vector3((float)2.00975, (float)-1.551666, (float)-4.396697)) && i26 == 0)
        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i26 = 1;

        }

        if ((ChildElement27.transform.localRotation == Quaternion.Euler((float)-90.00001, 0, (float)90.00001)) && j26 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j26 = 1;

        }

        if ((ChildElement28.transform.localPosition == new Vector3((float)2.00975, (float)-1.551666, (float)-4.396697)) && i27 == 0)
        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i27 = 1;

        }

        if ((ChildElement28.transform.localRotation == Quaternion.Euler((float)-90.00001, 0, (float)90.00001)) && j27 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j27 = 1;

        }

        if ((ChildElement29.transform.localPosition == new Vector3((float)-0.07838482, (float)2.271985, (float)-4.344925)) && i28 == 0)
        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i28 = 1;

        }

        if ((ChildElement29.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) && j28 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j28 = 1;

        }



      
    }
    IEnumerator Score()
    {

        if (
            (ChildElement3.transform.localPosition == new Vector3((float)-0.08180511, (float)-0.1923621, (float)-4.353579)) &&
            (ChildElement3.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) &&
            (ChildElement4.transform.localPosition == new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702)) &&
            (ChildElement4.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) &&
            (ChildElement5.transform.localPosition == new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702)) &&
            (ChildElement5.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) &&
            (ChildElement6.transform.localPosition == new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702)) &&
            (ChildElement6.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) &&
            (ChildElement7.transform.localPosition == new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702)) &&
            (ChildElement7.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) &&
            (ChildElement8.transform.localPosition == new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702)) &&
            (ChildElement8.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) &&
            (ChildElement9.transform.localPosition == new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702)) &&
            (ChildElement9.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) &&
            (ChildElement10.transform.localPosition == new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702)) &&
            (ChildElement10.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) &&
            (ChildElement11.transform.localPosition == new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702)) &&
            (ChildElement11.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) &&
            (ChildElement12.transform.localPosition == new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702)) &&
            (ChildElement12.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) &&
            (ChildElement13.transform.localPosition == new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702)) &&
            (ChildElement13.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) &&
            (ChildElement14.transform.localPosition == new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702)) &&
            (ChildElement14.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) &&
            (ChildElement15.transform.localPosition == new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702)) &&
            (ChildElement15.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) &&
            (ChildElement16.transform.localPosition == new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702)) &&
            (ChildElement16.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) &&
            (ChildElement17.transform.localPosition == new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702)) &&
            (ChildElement17.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) &&
            (ChildElement18.transform.localPosition == new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702)) &&
            (ChildElement18.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) &&
            (ChildElement19.transform.localPosition == new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702)) &&
            (ChildElement19.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) &&
            (ChildElement20.transform.localPosition == new Vector3((float)1.252619, (float)-0.3987826, (float)-3.052516)) &&
            (ChildElement20.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) &&
            (ChildElement21.transform.localPosition == new Vector3((float)1.252619, (float)-0.3987826, (float)-3.052516)) &&
            (ChildElement21.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) &&
            (ChildElement22.transform.localPosition == new Vector3((float)1.252619, (float)-0.3987826, (float)-3.052516)) &&
            (ChildElement22.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) &&
            (ChildElement23.transform.localPosition == new Vector3((float)1.252619, (float)-0.3987826, (float)-3.052516)) &&
            (ChildElement23.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) &&
            (ChildElement24.transform.localPosition == new Vector3((float)2.00975, (float)-1.551666, (float)-4.396697)) &&
            (ChildElement24.transform.localRotation == Quaternion.Euler((float)-90.00001, 0, (float)90.00001)) &&
            (ChildElement25.transform.localPosition == new Vector3((float)2.00975, (float)-1.551666, (float)-4.396697)) &&
            (ChildElement25.transform.localRotation == Quaternion.Euler((float)-90.00001, 0, (float)90.00001)) &&
            (ChildElement26.transform.localPosition == new Vector3((float)2.00975, (float)-1.551666, (float)-4.396697)) &&
            (ChildElement26.transform.localRotation == Quaternion.Euler((float)-90.00001, 0, (float)90.00001)) &&
            (ChildElement27.transform.localPosition == new Vector3((float)2.00975, (float)-1.551666, (float)-4.396697)) &&
            (ChildElement27.transform.localRotation == Quaternion.Euler((float)-90.00001, 0, (float)90.00001)) &&
            (ChildElement28.transform.localPosition == new Vector3((float)2.00975, (float)-1.551666, (float)-4.396697)) &&
            (ChildElement28.transform.localRotation == Quaternion.Euler((float)-90.00001, 0, (float)90.00001)) &&
            (ChildElement29.transform.localPosition == new Vector3((float)-0.07838482, (float)2.271985, (float)-4.344925)) &&
            (ChildElement29.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0))

            )
        {
            ZPlayerPrefs.SetString("level", "level6");
            ZPlayerPrefs.SetInt("Score", lastScore);
            score1.text = "Score: " + ZPlayerPrefs.GetInt("Score");
            time.gameObject.SetActive(false);
            // victoire
            if (imgv == 0)
            {
                source.PlayOneShot(clip);
                imageVect.SetActive(true);
                imgv = 1;
            }
            yield return new WaitForSeconds(2);

            imageVect.SetActive(false);
            //afficher l'histoire
            if (imghist == 0)
            {

                image2.SetActive(true);
                imghist = 1;
            }

        }
    }
        public void Joker()
    {


        if ((ChildElement3.transform.localPosition != new Vector3((float)-0.08180511, (float)-0.1923621, (float)-4.353579)) &&
            (ChildElement3.transform.localRotation != Quaternion.Euler((float)-89.98, 0, 0)))
        {
            ChildElement3.transform.localPosition = new Vector3((float)-0.08180511, (float)-0.1923621, (float)-4.353579);
            ChildElement3.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
            lastScore = lastScore - 115;

        }
        else
        {


            if ((ChildElement4.transform.localPosition != new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702)) &&
            (ChildElement4.transform.localRotation != Quaternion.Euler((float)-89.98, 0, 0)))
            {
                ChildElement4.transform.localPosition = new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702);
                ChildElement4.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);

                lastScore = lastScore - 115;
            }
            else
            {

                if ((ChildElement5.transform.localPosition != new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702)) &&
            (ChildElement5.transform.localRotation != Quaternion.Euler((float)-89.98, 0, 0)))
                {
                    ChildElement5.transform.localPosition = new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702);
                    ChildElement5.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                    lastScore = lastScore - 115;
                }
                else
                {

                    if ((ChildElement6.transform.localPosition != new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702)) &&
                        (ChildElement6.transform.localRotation != Quaternion.Euler((float)-89.98, 0, 0)))
                    {
                        ChildElement6.transform.localPosition = new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702);
                        ChildElement6.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                        lastScore = lastScore - 115;
                    }
                    else
                    {

                        if ((ChildElement7.transform.localPosition != new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702)) &&
                           (ChildElement7.transform.localRotation != Quaternion.Euler((float)-89.98, 0, 0)))
                        {
                            ChildElement7.transform.localPosition = new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702);
                            ChildElement7.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                            lastScore = lastScore - 115;
                        }
                        else
                        {

                            if ((ChildElement8.transform.localPosition != new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702)) &&
                               (ChildElement8.transform.localRotation != Quaternion.Euler((float)-89.98, 0, 0)))
                            {
                                ChildElement8.transform.localPosition = new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702);
                                ChildElement8.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                                lastScore = lastScore - 115;
                            }
                            else
                            {

                                if ((ChildElement9.transform.localPosition != new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702)) &&
                                    (ChildElement9.transform.localRotation != Quaternion.Euler((float)-89.98, 0, 0)))
                                {
                                    ChildElement9.transform.localPosition = new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702);
                                    ChildElement9.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                                    lastScore = lastScore - 115;
                                }
                                else
                                {

                                    if ((ChildElement10.transform.localPosition != new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702)) &&
                                        (ChildElement10.transform.localRotation!= Quaternion.Euler((float)-89.98, 0, 0)))
                                    {
                                        ChildElement10.transform.localPosition = new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702);
                                        ChildElement10.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                                        lastScore = lastScore - 115;
                                    }
                                    else
                                    {

                                        if ((ChildElement11.transform.localPosition != new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702)) &&
                                            (ChildElement11.transform.localRotation != Quaternion.Euler((float)-89.98, 0, 0)))
                                        {
                                            ChildElement11.transform.localPosition = new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702);
                                            ChildElement11.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                                            lastScore = lastScore - 115;
                                        }
                                        else
                                        {

                                            if ((ChildElement12.transform.localPosition != new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702)) &&
                                                (ChildElement12.transform.localRotation != Quaternion.Euler((float)-89.98, 0, 0)))
                                            {
                                                ChildElement12.transform.localPosition = new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702);
                                                ChildElement12.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                                                lastScore = lastScore - 115;
                                            }
                                            else
                                            {

                                                if ((ChildElement13.transform.localPosition != new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702)) &&
                                                    (ChildElement13.transform.localRotation != Quaternion.Euler((float)-89.98, 0, 0)))
                                                {
                                                    ChildElement13.transform.localPosition = new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702);
                                                    ChildElement13.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                                                    lastScore = lastScore - 115;
                                                }
                                                else
                                                {

                                                    if ((ChildElement14.transform.localPosition != new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702)) &&
                                                        (ChildElement14.transform.localRotation != Quaternion.Euler((float)-89.98, 0, 0)))
                                                    {
                                                        ChildElement14.transform.localPosition = new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702);
                                                        ChildElement14.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                                                        lastScore = lastScore - 115;
                                                    }
                                                    else
                                                    {

                                                        if ((ChildElement15.transform.localPosition != new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702)) &&
                                                            (ChildElement15.transform.localRotation != Quaternion.Euler((float)-89.98, 0, 0)))
                                                        {
                                                            ChildElement15.transform.localPosition = new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702);
                                                            ChildElement15.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                                                            lastScore = lastScore - 115;
                                                        }
                                                        else
                                                        {

                                                            if ((ChildElement16.transform.localPosition != new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702)) &&
                                                                (ChildElement16.transform.localRotation != Quaternion.Euler((float)-89.98, 0, 0)))
                                                            {
                                                                ChildElement16.transform.localPosition = new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702);
                                                                ChildElement16.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                                                                lastScore = lastScore - 115;
                                                            }
                                                            else
                                                            {

                                                                if ((ChildElement17.transform.localPosition != new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702)) &&
                                                                    (ChildElement17.transform.localRotation != Quaternion.Euler((float)-89.98, 0, 0)))
                                                                {
                                                                    ChildElement17.transform.localPosition = new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702);
                                                                    ChildElement17.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                                                                    lastScore = lastScore - 115;
                                                                }
                                                                else
                                                                {

                                                                    if ((ChildElement18.transform.localPosition != new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702)) &&
                                                                        (ChildElement18.transform.localRotation != Quaternion.Euler((float)-89.98, 0, 0)))
                                                                    {
                                                                        ChildElement18.transform.localPosition = new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702);
                                                                        ChildElement18.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                                                                        lastScore = lastScore - 115;
                                                                    }
                                                                    else
                                                                    {

                                                                        if ((ChildElement19.transform.localPosition != new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702)) &&
                                                                            (ChildElement19.transform.localRotation != Quaternion.Euler((float)-89.98, 0, 0)))
                                                                        {
                                                                            ChildElement19.transform.localPosition = new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702);
                                                                            ChildElement19.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                                                                            lastScore = lastScore - 115;
                                                                        }
                                                                        else
                                                                        {

                                                                            if ((ChildElement20.transform.localPosition != new Vector3((float)1.252619, (float)-0.3987826, (float)-3.052516)) &&
                                                                                (ChildElement20.transform.localRotation != Quaternion.Euler((float)-89.98, 0, 0)))
                                                                            {
                                                                                ChildElement20.transform.localPosition = new Vector3((float)1.252619, (float)-0.3987826, (float)-3.052516);
                                                                                ChildElement20.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                                                                                lastScore = lastScore - 115;
                                                                            }
                                                                            else
                                                                            {

                                                                                if ((ChildElement21.transform.localPosition != new Vector3((float)1.252619, (float)-0.3987826, (float)-3.052516)) &&
                                                                                    (ChildElement21.transform.localRotation!= Quaternion.Euler((float)-89.98, 0, 0)))
                                                                                {
                                                                                    ChildElement21.transform.localPosition = new Vector3((float)1.252619, (float)-0.3987826, (float)-3.052516);
                                                                                    ChildElement21.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                                                                                    lastScore = lastScore - 115;
                                                                                }
                                                                                else
                                                                                {

                                                                                    if ((ChildElement22.transform.localPosition != new Vector3((float)1.252619, (float)-0.3987826, (float)-3.052516)) &&
                                                                                       (ChildElement22.transform.localRotation != Quaternion.Euler((float)-89.98, 0, 0)))
                                                                                    {
                                                                                        ChildElement22.transform.localPosition = new Vector3((float)1.252619, (float)-0.3987826, (float)-3.052516);
                                                                                        ChildElement22.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                                                                                        lastScore = lastScore - 115;
                                                                                    }
                                                                                    else
                                                                                    {

                                                                                        if ((ChildElement23.transform.localPosition != new Vector3((float)1.252619, (float)-0.3987826, (float)-3.052516)) &&
                                                                                           (ChildElement23.transform.localRotation != Quaternion.Euler((float)-89.98, 0, 0)))
                                                                                        {
                                                                                            ChildElement23.transform.localPosition = new Vector3((float)1.252619, (float)-0.3987826, (float)-3.052516);
                                                                                            ChildElement23.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                                                                                            lastScore = lastScore - 115;
                                                                                        }
                                                                                        else
                                                                                        {

                                                                                            if ((ChildElement24.transform.localPosition != new Vector3((float)2.00975, (float)-1.551666, (float)-4.396697)) &&
                                                                                                (ChildElement24.transform.localRotation!= Quaternion.Euler((float)-90.00001, 0, (float)90.00001)))
                                                                                            {
                                                                                                ChildElement24.transform.localPosition = new Vector3((float)2.00975, (float)-1.551666, (float)-4.396697);
                                                                                                ChildElement24.transform.localRotation = Quaternion.Euler((float)-90.00001, 0, (float)90.00001);
                                                                                                lastScore = lastScore - 115;
                                                                                            }
                                                                                            else
                                                                                            {

                                                                                                if ((ChildElement25.transform.localPosition != new Vector3((float)2.00975, (float)-1.551666, (float)-4.396697)) &&
                                                                                                    (ChildElement25.transform.localRotation != Quaternion.Euler((float)-90.00001, 0, (float)90.00001)))
                                                                                                {
                                                                                                    ChildElement25.transform.localPosition = new Vector3((float)2.00975, (float)-1.551666, (float)-4.396697);
                                                                                                    ChildElement25.transform.localRotation = Quaternion.Euler((float)-90.00001, 0, (float)90.00001);
                                                                                                    lastScore = lastScore - 115;
                                                                                                }
                                                                                                else
                                                                                                {

                                                                                                    if ((ChildElement26.transform.localPosition != new Vector3((float)2.00975, (float)-1.551666, (float)-4.396697)) &&
                                                                                                       (ChildElement26.transform.localRotation != Quaternion.Euler((float)-90.00001, 0, (float)90.00001)))
                                                                                                    {
                                                                                                        ChildElement26.transform.localPosition = new Vector3((float)2.00975, (float)-1.551666, (float)-4.396697);
                                                                                                        ChildElement26.transform.localRotation = Quaternion.Euler((float)-90.00001, 0, (float)90.00001);
                                                                                                        lastScore = lastScore - 115;
                                                                                                    }
                                                                                                    else
                                                                                                    {

                                                                                                        if ((ChildElement27.transform.localPosition != new Vector3((float)2.00975, (float)-1.551666, (float)-4.396697)) &&
                                                                                                           (ChildElement27.transform.localRotation != Quaternion.Euler((float)-90.00001, 0, (float)90.00001)))
                                                                                                        {
                                                                                                            ChildElement27.transform.localPosition = new Vector3((float)2.00975, (float)-1.551666, (float)-4.396697);
                                                                                                            ChildElement27.transform.localRotation = Quaternion.Euler((float)-90.00001, 0, (float)90.00001);
                                                                                                            lastScore = lastScore - 115;
                                                                                                        }
                                                                                                        else
                                                                                                        {

                                                                                                            if ((ChildElement28.transform.localPosition != new Vector3((float)2.00975, (float)-1.551666, (float)-4.396697)) &&
                                                                                                               (ChildElement28.transform.localRotation != Quaternion.Euler((float)-90.00001, 0, (float)90.00001)))
                                                                                                            {
                                                                                                                ChildElement28.transform.localPosition = new Vector3((float)2.00975, (float)-1.551666, (float)-4.396697);
                                                                                                                ChildElement28.transform.localRotation = Quaternion.Euler((float)-90.00001, 0, (float)90.00001);
                                                                                                                lastScore = lastScore - 115;
                                                                                                            }
                                                                                                            else
                                                                                                            {

                                                                                                                if ((ChildElement29.transform.localPosition != new Vector3((float)-0.07838482, (float)2.271985, (float)-4.344925)) &&
                                                                                                                   (ChildElement29.transform.localRotation != Quaternion.Euler((float)-89.98, 0, 0)))
                                                                                                                {
                                                                                                                    ChildElement29.transform.localPosition = new Vector3((float)-0.07838482, (float)2.271985, (float)-4.344925);
                                                                                                                    ChildElement29.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                                                                                                                    lastScore = lastScore - 115;
                                                                                                                }

                                                                                                            }

                                                                                                        }

                                                                                                    }

                                                                                                }

                                                                                            }

                                                                                        }

                                                                                    }

                                                                                }

                                                                            }

                                                                        }

                                                                    }

                                                                }

                                                            }
              
                                                        }

                                                    }

                                                }

                                            }

                                        }

                                    }

                                }

                            }

                        }

                    }
                }
            }
        }


    }

}
