using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreBudha : MonoBehaviour
{

    [SerializeField]
    private int lastScore;
    public Text score, score1,time;
    public Button joker;
    public GameObject ChildElement1, ChildElement2, ChildElement3, ChildElement4, ChildElement5, ChildElement6, ChildElement7,
        ChildElement8, ChildElement9, ChildElement10, ChildElement11, ChildElement12, ChildElement13, ChildElement14,
        ChildElement15, ChildElement16, ChildElement17, ChildElement18, ChildElement19, ChildElement20, ChildElement21,
        ChildElement22, ChildElement23, ChildElement24, ChildElement25, ChildElement26, ChildElement27, ChildElement28,
        ChildElement29, ChildElement30, ChildElement31, ChildElement32, ChildElement33, ChildElement34, ChildElement35,
        ChildElement36, ChildElement37, ChildElement38, ChildElement39, ChildElement40, ChildElement41, ChildElement42,
        ChildElement43, imageVect, image2;
    int i1 = 0, j1 = 0, i2 = 0, j2 = 0, i3 = 0, j3 = 0, i4 = 0, j4 = 0, i5 = 0, j5 = 0, i6 = 0, j6 = 0,
        i7 = 0, j7 = 0, i8 = 0, j8 = 0, i9 = 0, j9 = 0, i10 = 0, j10 = 0, i11 = 0, j11 = 0, i12 = 0,
        j12 = 0, i13 = 0, j13 = 0, i14 = 0, j14 = 0, i15 = 0, j15 = 0, i16 = 0, j16 = 0, i17 = 0, j17 = 0,
        i18 = 0, j18 = 0, i19 = 0, j19 = 0, i20 = 0, j20 = 0, i21 = 0, j21 = 0, i22 = 0, j22 = 0, i23 = 0, j23 = 0,
        i24 = 0, j24 = 0, i25 = 0, j25 = 0, i26 = 0, j26 = 0, i27 = 0, j27 = 0, i28 = 0, j28 = 0, i29 = 0, j29 = 0,
        i30 = 0, j30 = 0, i31 = 0, j31 = 0, i32 = 0, j32 = 0, i33 = 0, j33 = 0, i34 = 0, j34 = 0, i35 = 0, j35 = 0, i36 = 0, j36 = 0,
        i37 = 0, j37 = 0, i38 = 0, j38 = 0, i39 = 0, j39 = 0, i40 = 0, j40 = 0, i41 = 0, j41 = 0, i42 = 0, j42 = 0,
        i43 = 0, j43 = 0, imgv = 0, imghist = 0;

    public AudioSource source, sourceshortVic;
    public AudioClip clip, clipshortVic;
    void Start()
    {
        ZPlayerPrefs.Initialize("y1a2s3", "8745dsdfE7D8df8425SDmjgh4fgtR");
        lastScore = PlayerPrefs.GetInt("Score");
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



        if ((ChildElement1.transform.localPosition == new Vector3(0, 0, 0)) && i1 == 0)
        {
            if (ChildElement1.transform.localRotation.z == 0)
            {

                ChildElement1.transform.localRotation = Quaternion.Euler(0, 0, 0);

            }
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i1 = 1;

        }

        if ((ChildElement1.transform.localRotation == Quaternion.Euler(ChildElement1.transform.localRotation.x, 0, 0)) && j1 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j1 = 1;

        }
        if ((ChildElement2.transform.localPosition == new Vector3(0, 0, 0)) && i2 == 0)
        {
            if (ChildElement2.transform.localRotation.z == 0)
            {

                ChildElement2.transform.localRotation = Quaternion.Euler(0, 0, 0);

            }
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i2 = 1;

        }

        if ((ChildElement2.transform.localRotation == Quaternion.Euler(ChildElement2.transform.localRotation.x, 0, 0)) && j2 == 0)

        {
             source.PlayOneShot(clipshortVic);
             lastScore = lastScore + 10;
             j2 = 1;

        }
        if ((ChildElement3.transform.localPosition == new Vector3(0, 0, 0)) && i3 == 0)
        {
            if (ChildElement3.transform.localRotation.z == 0)
            {

                ChildElement3.transform.localRotation = Quaternion.Euler(0, 0, 0);

            }
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i3 = 1;

        }

        if ((ChildElement3.transform.localRotation == Quaternion.Euler(ChildElement3.transform.localRotation.x, 0, 0)) && j3 == 0)

        {
             source.PlayOneShot(clipshortVic);
             lastScore = lastScore + 10;
             j3 = 1;

        }
        if ((ChildElement4.transform.localPosition == new Vector3(0, 0, 0)) && i4 == 0)
        {
            if (ChildElement4.transform.localRotation.z == 0)
            {

                ChildElement4.transform.localRotation = Quaternion.Euler(0, 0, 0);

            }
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i4 = 1;

        }

        if ((ChildElement4.transform.localRotation == Quaternion.Euler(ChildElement4.transform.localRotation.x, 0, 0)) && j4 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j4 = 1;

        }

        if ((ChildElement5.transform.localPosition == new Vector3(0, 0, 0)) && i5 == 0)
        {
            if (ChildElement5.transform.localRotation.z == 0)
            {

                ChildElement5.transform.localRotation = Quaternion.Euler(0, 0, 0);

            }
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i5 = 1;

        }

        if ((ChildElement5.transform.localRotation == Quaternion.Euler(ChildElement5.transform.localRotation.x, 0, 0)) && j5 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j5 = 1;

        }
        if ((ChildElement6.transform.localPosition == new Vector3(0, 0, 0)) && i6 == 0)
        {
            if (ChildElement6.transform.localRotation.z == 0)
            {

                ChildElement6.transform.localRotation = Quaternion.Euler(0, 0, 0);

            }
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i6 = 1;

        }

        if ((ChildElement6.transform.localRotation == Quaternion.Euler(ChildElement6.transform.localRotation.x, 0, 0)) && j6 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j6 = 1;

        }
        if ((ChildElement7.transform.localPosition == new Vector3(0, 0, 0)) && i7 == 0)
        {
            if (ChildElement7.transform.localRotation.z == 0)
            {

                ChildElement7.transform.localRotation = Quaternion.Euler(0, 0, 0);

            }
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i7 = 1;

        }

        if ((ChildElement7.transform.localRotation == Quaternion.Euler(ChildElement7.transform.localRotation.x, 0, 0)) && j7 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j7 = 1;

        }
        if ((ChildElement8.transform.localPosition == new Vector3(0, 0, 0)) && i8 == 0)
        {
            if (ChildElement8.transform.localRotation.z == 0)
            {

                ChildElement8.transform.localRotation = Quaternion.Euler(0, 0, 0);

            }
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i8 = 1;

        }

        if ((ChildElement8.transform.localRotation == Quaternion.Euler(ChildElement8.transform.localRotation.x, 0, 0)) && j8 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j8 = 1;

        }
        if ((ChildElement9.transform.localPosition == new Vector3(0, 0, 0)) && i9 == 0)
        {
            if (ChildElement9.transform.localRotation.z == 0)
            {

                ChildElement9.transform.localRotation = Quaternion.Euler(0, 0, 0);

            }
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i9 = 1;

        }

        if ((ChildElement9.transform.localRotation == Quaternion.Euler(ChildElement9.transform.localRotation.x, 0, 0)) && j9 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j9 = 1;

        }
        if ((ChildElement10.transform.localPosition == new Vector3(0, 0, 0)) && i10 == 0)
        {
            if (ChildElement10.transform.localRotation.z == 0)
            {

                ChildElement10.transform.localRotation = Quaternion.Euler(0, 0, 0);

            }
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i10 = 1;

        }

        if ((ChildElement10.transform.localRotation == Quaternion.Euler(ChildElement10.transform.localRotation.x, 0, 0)) && j10 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j10 = 1;

        }
        if ((ChildElement11.transform.localPosition == new Vector3(0, 0, 0)) && i11 == 0)
        {
            if (ChildElement11.transform.localRotation.z == 0)
            {

                ChildElement11.transform.localRotation = Quaternion.Euler(0, 0, 0);

            }
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i11 = 1;

        }

        if ((ChildElement11.transform.localRotation == Quaternion.Euler(ChildElement11.transform.localRotation.x, 0, 0)) && j11 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j11 = 1;

        }
        if ((ChildElement12.transform.localPosition == new Vector3(0, 0, 0)) && i12 == 0)
        {
            if (ChildElement12.transform.localRotation.z == 0)
            {

                ChildElement12.transform.localRotation = Quaternion.Euler(0, 0, 0);

            }
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i12 = 1;

        }

        if ((ChildElement12.transform.localRotation == Quaternion.Euler(ChildElement12.transform.localRotation.x, 0, 0)) && j12 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j12 = 1;

        }
        if ((ChildElement13.transform.localPosition == new Vector3(0, 0, 0)) && i13 == 0)
        {
            if (ChildElement13.transform.localRotation.z == 0)
            {

                ChildElement13.transform.localRotation = Quaternion.Euler(0, 0, 0);

            }
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i13 = 1;

        }

        if ((ChildElement13.transform.localRotation == Quaternion.Euler(ChildElement13.transform.localRotation.x, 0, 0)) && j13 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j13 = 1;

        }
        if ((ChildElement14.transform.localPosition == new Vector3(0, 0, 0)) && i14 == 0)
        {
            if (ChildElement14.transform.localRotation.z == 0)
            {

                ChildElement14.transform.localRotation = Quaternion.Euler(0, 0, 0);

            }
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i14 = 1;

        }

        if ((ChildElement14.transform.localRotation == Quaternion.Euler(ChildElement14.transform.localRotation.x, 0, 0)) && j14 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j14 = 1;

        }
        if ((ChildElement15.transform.localPosition == new Vector3(0, 0, 0)) && i15 == 0)
        {
            if (ChildElement15.transform.localRotation.z == 0)
            {

                ChildElement15.transform.localRotation = Quaternion.Euler(0, 0, 0);

            }
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i15 = 1;

        }

        if ((ChildElement15.transform.localRotation == Quaternion.Euler(ChildElement15.transform.localRotation.x, 0, 0)) && j15 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j15 = 1;

        }
        if ((ChildElement16.transform.localPosition == new Vector3(0, 0, 0)) && i16 == 0)
        {
            if (ChildElement16.transform.localRotation.z == 0)
            {

                ChildElement16.transform.localRotation = Quaternion.Euler(0, 0, 0);

            }
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i16 = 1;

        }

        if ((ChildElement16.transform.localRotation == Quaternion.Euler(ChildElement16.transform.localRotation.x, 0, 0)) && j16 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j16 = 1;

        }
        if ((ChildElement17.transform.localPosition == new Vector3(0, 0, 0)) && i17 == 0)
        {
            if (ChildElement17.transform.localRotation.z == 0)
            {

                ChildElement17.transform.localRotation = Quaternion.Euler(0, 0, 0);

            }
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i17 = 1;

        }

        if ((ChildElement17.transform.localRotation == Quaternion.Euler(ChildElement17.transform.localRotation.x, 0, 0)) && j17 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j17 = 1;

        }
        if ((ChildElement18.transform.localPosition == new Vector3(0, 0, 0)) && i18 == 0)
        {
            if (ChildElement18.transform.localRotation.z == 0)
            {

                ChildElement18.transform.localRotation = Quaternion.Euler(0, 0, 0);

            }
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i18 = 1;

        }

        if ((ChildElement18.transform.localRotation == Quaternion.Euler(ChildElement18.transform.localRotation.x, 0, 0)) && j18 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j18 = 1;

        }
        if ((ChildElement19.transform.localPosition == new Vector3(0, 0, 0)) && i19 == 0)
        {
            if (ChildElement19.transform.localRotation.z == 0)
            {

                ChildElement19.transform.localRotation = Quaternion.Euler(0, 0, 0);

            }
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i19 = 1;

        }

        if ((ChildElement19.transform.localRotation == Quaternion.Euler(ChildElement19.transform.localRotation.x, 0, 0)) && j19 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j19 = 1;

        }
        if ((ChildElement20.transform.localPosition == new Vector3(0, 0, 0)) && i20 == 0)
        {
            if (ChildElement20.transform.localRotation.z == 0)
            {

                ChildElement20.transform.localRotation = Quaternion.Euler(0, 0, 0);

            }
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i20 = 1;

        }

        if ((ChildElement20.transform.localRotation == Quaternion.Euler(ChildElement20.transform.localRotation.x, 0, 0)) && j20 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j20 = 1;

        }
        if ((ChildElement21.transform.localPosition == new Vector3(0, 0, 0)) && i21 == 0)
        {
            if (ChildElement21.transform.localRotation.z == 0)
            {

                ChildElement21.transform.localRotation = Quaternion.Euler(0, 0, 0);

            }
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i21 = 1;

        }

        if ((ChildElement21.transform.localRotation == Quaternion.Euler(ChildElement21.transform.localRotation.x, 0, 0)) && j21 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j21 = 1;

        }
        if ((ChildElement22.transform.localPosition == new Vector3(0, 0, 0)) && i22 == 0)
        {
            if (ChildElement22.transform.localRotation.z == 0)
            {

                ChildElement22.transform.localRotation = Quaternion.Euler(0, 0, 0);

            }
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i22 = 1;

        }

        if ((ChildElement22.transform.localRotation == Quaternion.Euler(ChildElement22.transform.localRotation.x, 0, 0)) && j22 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j22 = 1;

        }
        if ((ChildElement23.transform.localPosition == new Vector3(0, 0, 0)) && i23 == 0)
        {
            if (ChildElement23.transform.localRotation.z == 0)
            {

                ChildElement23.transform.localRotation = Quaternion.Euler(0, 0, 0);

            }
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i23 = 1;

        }

        if ((ChildElement23.transform.localRotation == Quaternion.Euler(ChildElement23.transform.localRotation.x, 0, 0)) && j23 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j23 = 1;

        }
        if ((ChildElement24.transform.localPosition == new Vector3(0, 0, 0)) && i24 == 0)
        {
            if (ChildElement24.transform.localRotation.z == 0)
            {

                ChildElement24.transform.localRotation = Quaternion.Euler(0, 0, 0);

            }
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i24 = 1;

        }

        if ((ChildElement24.transform.localRotation == Quaternion.Euler(ChildElement24.transform.localRotation.x, 0, 0)) && j24 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j24 = 1;

        }
        if ((ChildElement25.transform.localPosition == new Vector3(0, 0, 0)) && i25 == 0)
        {
            if (ChildElement25.transform.localRotation.z == 0)
            {

                ChildElement25.transform.localRotation = Quaternion.Euler(0, 0, 0);

            }
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i25 = 1;

        }

        if ((ChildElement25.transform.localRotation == Quaternion.Euler(ChildElement25.transform.localRotation.x, 0, 0)) && j25 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j25 = 1;

        }
        if ((ChildElement26.transform.localPosition == new Vector3(0, 0, 0)) && i26 == 0)
        {
            if (ChildElement26.transform.localRotation.z == 0)
            {

                ChildElement26.transform.localRotation = Quaternion.Euler(0, 0, 0);

            }
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i26 = 1;

        }

        if ((ChildElement26.transform.localRotation == Quaternion.Euler(ChildElement26.transform.localRotation.x, 0, 0)) && j26 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j26 = 1;

        }
        if ((ChildElement27.transform.localPosition == new Vector3(0, 0, 0)) && i27 == 0)
        {
            if (ChildElement27.transform.localRotation.z == 0)
            {

                ChildElement27.transform.localRotation = Quaternion.Euler(0, 0, 0);

            }
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i27 = 1;

        }

        if ((ChildElement27.transform.localRotation == Quaternion.Euler(ChildElement27.transform.localRotation.x, 0, 0)) && j27 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j27 = 1;

        }

        if ((ChildElement28.transform.localPosition == new Vector3(0, 0, 0)) && i28 == 0)
        {
            if (ChildElement28.transform.localRotation.z == 0)
            {

                ChildElement28.transform.localRotation = Quaternion.Euler(0, 0, 0);

            }
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i28 = 1;

        }

        if ((ChildElement28.transform.localRotation == Quaternion.Euler(ChildElement28.transform.localRotation.x, 0, 0)) && j28 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j28 = 1;

        }
        if ((ChildElement29.transform.localPosition == new Vector3(0, 0, 0)) && i29 == 0)
        {
            if (ChildElement29.transform.localRotation.z == 0)
            {

                ChildElement29.transform.localRotation = Quaternion.Euler(0, 0, 0);

            }
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i29 = 1;

        }

        if ((ChildElement29.transform.localRotation == Quaternion.Euler(ChildElement29.transform.localRotation.x, 0, 0)) && j29 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j29 = 1;

        }
        if ((ChildElement30.transform.localPosition == new Vector3(0, 0, 0)) && i30 == 0)
        {
            if (ChildElement30.transform.localRotation.z == 0)
            {

                ChildElement30.transform.localRotation = Quaternion.Euler(0, 0, 0);

            }
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i30 = 1;

        }

        if ((ChildElement30.transform.localRotation == Quaternion.Euler(ChildElement30.transform.localRotation.x, 0, 0)) && j30 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j30 = 1;

        }
        if ((ChildElement31.transform.localPosition == new Vector3(0, 0, 0)) && i31 == 0)
        {
            if (ChildElement31.transform.localRotation.z == 0)
            {

                ChildElement31.transform.localRotation = Quaternion.Euler(0, 0, 0);

            }
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i31 = 1;

        }

        if ((ChildElement31.transform.localRotation == Quaternion.Euler(ChildElement31.transform.localRotation.x, 0, 0)) && j31 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j31 = 1;

        }
        if ((ChildElement32.transform.localPosition == new Vector3(0, 0, 0)) && i32 == 0)
        {
            if (ChildElement32.transform.localRotation.z == 0)
            {

                ChildElement32.transform.localRotation = Quaternion.Euler(0, 0, 0);

            }
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i32 = 1;

        }

        if ((ChildElement32.transform.localRotation == Quaternion.Euler(ChildElement32.transform.localRotation.x, 0, 0)) && j32 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j32 = 1;

        }
        if ((ChildElement33.transform.localPosition == new Vector3(0, 0, 0)) && i33 == 0)
        {
            if (ChildElement33.transform.localRotation.z == 0)
            {

                ChildElement33.transform.localRotation = Quaternion.Euler(0, 0, 0);

            }
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i33 = 1;

        }

        if ((ChildElement33.transform.localRotation == Quaternion.Euler(ChildElement33.transform.localRotation.x, 0, 0)) && j33 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j33 = 1;

        }
        if ((ChildElement34.transform.localPosition == new Vector3(0, 0, 0)) && i34 == 0)
        {
            if (ChildElement34.transform.localRotation.z == 0)
            {

                ChildElement34.transform.localRotation = Quaternion.Euler(0, 0, 0);

            }
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i34 = 1;

        }

        if ((ChildElement34.transform.localRotation == Quaternion.Euler(ChildElement34.transform.localRotation.x, 0, 0)) && j34 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j34 = 1;

        }
        if ((ChildElement35.transform.localPosition == new Vector3(0, 0, 0)) && i35 == 0)
        {
            if (ChildElement35.transform.localRotation.z == 0)
            {

                ChildElement35.transform.localRotation = Quaternion.Euler(0, 0, 0);

            }
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i35 = 1;

        }

        if ((ChildElement35.transform.localRotation == Quaternion.Euler(ChildElement35.transform.localRotation.x, 0, 0)) && j35 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j35 = 1;

        }
        if ((ChildElement36.transform.localPosition == new Vector3(0, 0, 0)) && i36 == 0)
        {
            if (ChildElement36.transform.localRotation.z == 0)
            {

                ChildElement36.transform.localRotation = Quaternion.Euler(0, 0, 0);

            }
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i36 = 1;

        }

        if ((ChildElement36.transform.localRotation == Quaternion.Euler(ChildElement36.transform.localRotation.x, 0, 0)) && j36 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j36 = 1;

        }
        if ((ChildElement37.transform.localPosition == new Vector3(0, 0, 0)) && i37 == 0)
        {
            if (ChildElement37.transform.localRotation.z == 0)
            {

                ChildElement37.transform.localRotation = Quaternion.Euler(0, 0, 0);

            }
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i37 = 1;

        }

        if ((ChildElement37.transform.localRotation == Quaternion.Euler(ChildElement37.transform.localRotation.x, 0, 0)) && j37 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j37 = 1;

        }
        if ((ChildElement38.transform.localPosition == new Vector3(0, 0, 0)) && i38 == 0)
        {
            if (ChildElement38.transform.localRotation.z == 0)
            {

                ChildElement38.transform.localRotation = Quaternion.Euler(0, 0, 0);

            }
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i38 = 1;

        }

        if ((ChildElement38.transform.localRotation == Quaternion.Euler(ChildElement38.transform.localRotation.x, 0, 0)) && j38 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j38 = 1;

        }
        if ((ChildElement39.transform.localPosition == new Vector3(0, 0, 0)) && i39 == 0)
        {
            if (ChildElement39.transform.localRotation.z == 0)
            {

                ChildElement39.transform.localRotation = Quaternion.Euler(0, 0, 0);

            }
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i39 = 1;

        }

        if ((ChildElement39.transform.localRotation == Quaternion.Euler(ChildElement39.transform.localRotation.x, 0, 0)) && j39 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j39 = 1;

        }
        if ((ChildElement40.transform.localPosition == new Vector3(0, 0, 0)) && i40 == 0)
        {
            if (ChildElement40.transform.localRotation.z == 0)
            {

                ChildElement40.transform.localRotation = Quaternion.Euler(0, 0, 0);

            }
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i40 = 1;

        }

        if ((ChildElement40.transform.localRotation == Quaternion.Euler(ChildElement40.transform.localRotation.x, 0, 0)) && j40 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j40 = 1;

        }
        if ((ChildElement41.transform.localPosition == new Vector3(0, 0, 0)) && i41 == 0)
        {
            if (ChildElement41.transform.localRotation.z == 0)
            {

                ChildElement41.transform.localRotation = Quaternion.Euler(0, 0, 0);

            }
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i41 = 1;

        }

        if ((ChildElement41.transform.localRotation == Quaternion.Euler(ChildElement41.transform.localRotation.x, 0, 0)) && j41 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j41 = 1;

        }
        if ((ChildElement42.transform.localPosition == new Vector3(0, 0, 0)) && i42 == 0)
        {
            if (ChildElement42.transform.localRotation.z == 0)
            {

                ChildElement42.transform.localRotation = Quaternion.Euler(0, 0, 0);

            }
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i42 = 1;

        }

        if ((ChildElement42.transform.localRotation == Quaternion.Euler(ChildElement42.transform.localRotation.x, 0, 0)) && j42 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j42 = 1;

        }
        if ((ChildElement43.transform.localPosition == new Vector3(0, 0, 0)) && i43 == 0)
        {
            if (ChildElement43.transform.localRotation.z == 0)
            {

                ChildElement43.transform.localRotation = Quaternion.Euler(0, 0, 0);

            }
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i43 = 1;

        }

        if ((ChildElement43.transform.localRotation == Quaternion.Euler(ChildElement43.transform.localRotation.x, 0, 0)) && j43 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j43 = 1;

        }


    }
    public void Joker()
    {


        if ((ChildElement1.transform.localPosition != new Vector3(0, 0, 0)) &&
            (ChildElement1.transform.localRotation != Quaternion.Euler(0, 0, 0)))
        {
            ChildElement1.transform.localPosition = new Vector3(0, 0, 0);
            ChildElement1.transform.localRotation = Quaternion.Euler(0, 0, 0);
            lastScore = lastScore - 115;

        }
        else
        {
            if ((ChildElement2.transform.localPosition != new Vector3(0, 0, 0)) &&
               (ChildElement2.transform.localRotation != Quaternion.Euler(0, 0, 0)))
            {
                ChildElement2.transform.localPosition = new Vector3(0, 0, 0);
                ChildElement2.transform.localRotation = Quaternion.Euler(0, 0, 0);
                lastScore = lastScore - 115;

            }
            else
            {
                if ((ChildElement3.transform.localPosition != new Vector3(0, 0, 0)) &&
                   (ChildElement3.transform.localRotation != Quaternion.Euler(0, 0, 0)))
                {
                    ChildElement3.transform.localPosition = new Vector3(0, 0, 0);
                    ChildElement3.transform.localRotation = Quaternion.Euler(0, 0, 0);
                    lastScore = lastScore - 115;

                }
                else
                {
                    if ((ChildElement4.transform.localPosition != new Vector3(0, 0, 0)) &&
                       (ChildElement4.transform.localRotation != Quaternion.Euler(0, 0, 0)))
                    {
                        ChildElement4.transform.localPosition = new Vector3(0, 0, 0);
                        ChildElement4.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        lastScore = lastScore - 115;

                    }
                    else
                    {
                        if ((ChildElement5.transform.localPosition != new Vector3(0, 0, 0)) &&
                           (ChildElement5.transform.localRotation != Quaternion.Euler(0, 0, 0)))
                        {
                            ChildElement5.transform.localPosition = new Vector3(0, 0, 0);
                            ChildElement5.transform.localRotation = Quaternion.Euler(0, 0, 0);
                            lastScore = lastScore - 115;

                        }
                        else
                        {
                            if ((ChildElement6.transform.localPosition != new Vector3(0, 0, 0)) &&
                               (ChildElement6.transform.localRotation != Quaternion.Euler(0, 0, 0)))
                            {
                                ChildElement6.transform.localPosition = new Vector3(0, 0, 0);
                                ChildElement6.transform.localRotation = Quaternion.Euler(0, 0, 0);
                                lastScore = lastScore - 115;

                            }
                            else
                            {
                                if ((ChildElement7.transform.localPosition != new Vector3(0, 0, 0)) &&
                                   (ChildElement7.transform.localRotation != Quaternion.Euler(0, 0, 0)))
                                {
                                    ChildElement7.transform.localPosition = new Vector3(0, 0, 0);
                                    ChildElement7.transform.localRotation = Quaternion.Euler(0, 0, 0);
                                    lastScore = lastScore - 115;

                                }
                                else
                                {
                                    if ((ChildElement8.transform.localPosition != new Vector3(0, 0, 0)) &&
                                       (ChildElement8.transform.localRotation != Quaternion.Euler(0, 0, 0)))
                                    {
                                        ChildElement8.transform.localPosition = new Vector3(0, 0, 0);
                                        ChildElement8.transform.localRotation = Quaternion.Euler(0, 0, 0);
                                        lastScore = lastScore - 115;

                                    }
                                    else
                                    {
                                        if ((ChildElement9.transform.localPosition != new Vector3(0, 0, 0)) &&
                                           (ChildElement9.transform.localRotation != Quaternion.Euler(0, 0, 0)))
                                        {
                                            ChildElement9.transform.localPosition = new Vector3(0, 0, 0);
                                            ChildElement9.transform.localRotation = Quaternion.Euler(0, 0, 0);
                                            lastScore = lastScore - 115;

                                        }
                                        else
                                        {
                                            if ((ChildElement10.transform.localPosition != new Vector3(0, 0, 0)) &&
                                               (ChildElement10.transform.localRotation != Quaternion.Euler(0, 0, 0)))
                                            {
                                                ChildElement10.transform.localPosition = new Vector3(0, 0, 0);
                                                ChildElement10.transform.localRotation = Quaternion.Euler(0, 0, 0);
                                                lastScore = lastScore - 115;

                                            }
                                            else
                                            {
                                                if ((ChildElement11.transform.localPosition != new Vector3(0, 0, 0)) &&
                                                   (ChildElement11.transform.localRotation != Quaternion.Euler(0, 0, 0)))
                                                {
                                                    ChildElement11.transform.localPosition = new Vector3(0, 0, 0);
                                                    ChildElement11.transform.localRotation = Quaternion.Euler(0, 0, 0);
                                                    lastScore = lastScore - 115;

                                                }
                                                else
                                                {
                                                    if ((ChildElement12.transform.localPosition != new Vector3(0, 0, 0)) &&
                                                       (ChildElement12.transform.localRotation != Quaternion.Euler(0, 0, 0)))
                                                    {
                                                        ChildElement12.transform.localPosition = new Vector3(0, 0, 0);
                                                        ChildElement12.transform.localRotation = Quaternion.Euler(0, 0, 0);
                                                        lastScore = lastScore - 115;

                                                    }
                                                    else
                                                    {
                                                        if ((ChildElement13.transform.localPosition != new Vector3(0, 0, 0)) &&
                                                           (ChildElement13.transform.localRotation != Quaternion.Euler(0, 0, 0)))
                                                        {
                                                            ChildElement13.transform.localPosition = new Vector3(0, 0, 0);
                                                            ChildElement13.transform.localRotation = Quaternion.Euler(0, 0, 0);
                                                            lastScore = lastScore - 115;

                                                        }
                                                        else
                                                        {
                                                            if ((ChildElement14.transform.localPosition != new Vector3(0, 0, 0)) &&
                                                               (ChildElement14.transform.localRotation != Quaternion.Euler(0, 0, 0)))
                                                            {
                                                                ChildElement14.transform.localPosition = new Vector3(0, 0, 0);
                                                                ChildElement14.transform.localRotation = Quaternion.Euler(0, 0, 0);
                                                                lastScore = lastScore - 115;

                                                            }
                                                            else
                                                            {
                                                                if ((ChildElement15.transform.localPosition != new Vector3(0, 0, 0)) &&
                                                                   (ChildElement15.transform.localRotation != Quaternion.Euler(0, 0, 0)))
                                                                {
                                                                    ChildElement15.transform.localPosition = new Vector3(0, 0, 0);
                                                                    ChildElement15.transform.localRotation = Quaternion.Euler(0, 0, 0);
                                                                    lastScore = lastScore - 115;

                                                                }
                                                                else
                                                                {
                                                                    if ((ChildElement16.transform.localPosition != new Vector3(0, 0, 0)) &&
                                                                       (ChildElement16.transform.localRotation != Quaternion.Euler(0, 0, 0)))
                                                                    {
                                                                        ChildElement16.transform.localPosition = new Vector3(0, 0, 0);
                                                                        ChildElement16.transform.localRotation = Quaternion.Euler(0, 0, 0);
                                                                        lastScore = lastScore - 115;

                                                                    }
                                                                    else
                                                                    {
                                                                        if ((ChildElement17.transform.localPosition != new Vector3(0, 0, 0)) &&
                                                                           (ChildElement17.transform.localRotation != Quaternion.Euler(0, 0, 0)))
                                                                        {
                                                                            ChildElement17.transform.localPosition = new Vector3(0, 0, 0);
                                                                            ChildElement17.transform.localRotation = Quaternion.Euler(0, 0, 0);
                                                                            lastScore = lastScore - 115;

                                                                        }
                                                                        else
                                                                        {
                                                                            if ((ChildElement18.transform.localPosition != new Vector3(0, 0, 0)) &&
                                                                               (ChildElement18.transform.localRotation != Quaternion.Euler(0, 0, 0)))
                                                                            {
                                                                                ChildElement18.transform.localPosition = new Vector3(0, 0, 0);
                                                                                ChildElement18.transform.localRotation = Quaternion.Euler(0, 0, 0);
                                                                                lastScore = lastScore - 115;

                                                                            }
                                                                            else
                                                                            {
                                                                                if ((ChildElement19.transform.localPosition != new Vector3(0, 0, 0)) &&
                                                                                   (ChildElement19.transform.localRotation != Quaternion.Euler(0, 0, 0)))
                                                                                {
                                                                                    ChildElement19.transform.localPosition = new Vector3(0, 0, 0);
                                                                                    ChildElement19.transform.localRotation = Quaternion.Euler(0, 0, 0);
                                                                                    lastScore = lastScore - 115;

                                                                                }
                                                                                else
                                                                                {
                                                                                    if ((ChildElement20.transform.localPosition != new Vector3(0, 0, 0)) &&
                                                                                       (ChildElement20.transform.localRotation != Quaternion.Euler(0, 0, 0)))
                                                                                    {
                                                                                        ChildElement20.transform.localPosition = new Vector3(0, 0, 0);
                                                                                        ChildElement20.transform.localRotation = Quaternion.Euler(0, 0, 0);
                                                                                        lastScore = lastScore - 115;

                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        if ((ChildElement21.transform.localPosition != new Vector3(0, 0, 0)) &&
                                                                                           (ChildElement21.transform.localRotation != Quaternion.Euler(0, 0, 0)))
                                                                                        {
                                                                                            ChildElement21.transform.localPosition = new Vector3(0, 0, 0);
                                                                                            ChildElement21.transform.localRotation = Quaternion.Euler(0, 0, 0);
                                                                                            lastScore = lastScore - 115;

                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            if ((ChildElement22.transform.localPosition != new Vector3(0, 0, 0)) &&
                                                                                               (ChildElement22.transform.localRotation != Quaternion.Euler(0, 0, 0)))
                                                                                            {
                                                                                                ChildElement22.transform.localPosition = new Vector3(0, 0, 0);
                                                                                                ChildElement22.transform.localRotation = Quaternion.Euler(0, 0, 0);
                                                                                                lastScore = lastScore - 115;

                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                if ((ChildElement23.transform.localPosition != new Vector3(0, 0, 0)) &&
                                                                                                   (ChildElement23.transform.localRotation != Quaternion.Euler(0, 0, 0)))
                                                                                                {
                                                                                                    ChildElement23.transform.localPosition = new Vector3(0, 0, 0);
                                                                                                    ChildElement23.transform.localRotation = Quaternion.Euler(0, 0, 0);
                                                                                                    lastScore = lastScore - 115;

                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    if ((ChildElement24.transform.localPosition != new Vector3(0, 0, 0)) &&
                                                                                                       (ChildElement24.transform.localRotation != Quaternion.Euler(0, 0, 0)))
                                                                                                    {
                                                                                                        ChildElement24.transform.localPosition = new Vector3(0, 0, 0);
                                                                                                        ChildElement24.transform.localRotation = Quaternion.Euler(0, 0, 0);
                                                                                                        lastScore = lastScore - 115;

                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        if ((ChildElement25.transform.localPosition != new Vector3(0, 0, 0)) &&
                                                                                                           (ChildElement25.transform.localRotation != Quaternion.Euler(0, 0, 0)))
                                                                                                        {
                                                                                                            ChildElement25.transform.localPosition = new Vector3(0, 0, 0);
                                                                                                            ChildElement25.transform.localRotation = Quaternion.Euler(0, 0, 0);
                                                                                                            lastScore = lastScore - 115;

                                                                                                        }
                                                                                                        else
                                                                                                        {
                                                                                                            if ((ChildElement26.transform.localPosition != new Vector3(0, 0, 0)) &&
                                                                                                               (ChildElement26.transform.localRotation != Quaternion.Euler(0, 0, 0)))
                                                                                                            {
                                                                                                                ChildElement26.transform.localPosition = new Vector3(0, 0, 0);
                                                                                                                ChildElement26.transform.localRotation = Quaternion.Euler(0, 0, 0);
                                                                                                                lastScore = lastScore - 115;

                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                if ((ChildElement27.transform.localPosition != new Vector3(0, 0, 0)) &&
                                                                                                                   (ChildElement27.transform.localRotation != Quaternion.Euler(0, 0, 0)))
                                                                                                                {
                                                                                                                    ChildElement27.transform.localPosition = new Vector3(0, 0, 0);
                                                                                                                    ChildElement27.transform.localRotation = Quaternion.Euler(0, 0, 0);
                                                                                                                    lastScore = lastScore - 115;

                                                                                                                }
                                                                                                                else
                                                                                                                {
                                                                                                                    if ((ChildElement28.transform.localPosition != new Vector3(0, 0, 0)) &&
                                                                                                                       (ChildElement28.transform.localRotation != Quaternion.Euler(0, 0, 0)))
                                                                                                                    {
                                                                                                                        ChildElement28.transform.localPosition = new Vector3(0, 0, 0);
                                                                                                                        ChildElement28.transform.localRotation = Quaternion.Euler(0, 0, 0);
                                                                                                                        lastScore = lastScore - 115;

                                                                                                                    }
                                                                                                                    else
                                                                                                                    {
                                                                                                                        if ((ChildElement29.transform.localPosition != new Vector3(0, 0, 0)) &&
                                                                                                                           (ChildElement29.transform.localRotation != Quaternion.Euler(0, 0, 0)))
                                                                                                                        {
                                                                                                                            ChildElement29.transform.localPosition = new Vector3(0, 0, 0);
                                                                                                                            ChildElement29.transform.localRotation = Quaternion.Euler(0, 0, 0);
                                                                                                                            lastScore = lastScore - 115;

                                                                                                                        }
                                                                                                                        else
                                                                                                                        {
                                                                                                                            if ((ChildElement30.transform.localPosition != new Vector3(0, 0, 0)) &&
                                                                                                                               (ChildElement30.transform.localRotation != Quaternion.Euler(0, 0, 0)))
                                                                                                                            {
                                                                                                                                ChildElement30.transform.localPosition = new Vector3(0, 0, 0);
                                                                                                                                ChildElement30.transform.localRotation = Quaternion.Euler(0, 0, 0);
                                                                                                                                lastScore = lastScore - 115;

                                                                                                                            }
                                                                                                                            else
                                                                                                                            {
                                                                                                                                if ((ChildElement31.transform.localPosition != new Vector3(0, 0, 0)) &&
                                                                                                                                   (ChildElement31.transform.localRotation != Quaternion.Euler(0, 0, 0)))
                                                                                                                                {
                                                                                                                                    ChildElement31.transform.localPosition = new Vector3(0, 0, 0);
                                                                                                                                    ChildElement31.transform.localRotation = Quaternion.Euler(0, 0, 0);
                                                                                                                                    lastScore = lastScore - 115;

                                                                                                                                }
                                                                                                                                else
                                                                                                                                {
                                                                                                                                    if ((ChildElement32.transform.localPosition != new Vector3(0, 0, 0)) &&
                                                                                                                                       (ChildElement32.transform.localRotation != Quaternion.Euler(0, 0, 0)))
                                                                                                                                    {
                                                                                                                                        ChildElement32.transform.localPosition = new Vector3(0, 0, 0);
                                                                                                                                        ChildElement32.transform.localRotation = Quaternion.Euler(0, 0, 0);
                                                                                                                                        lastScore = lastScore - 115;

                                                                                                                                    }
                                                                                                                                    else
                                                                                                                                    {
                                                                                                                                        if ((ChildElement33.transform.localPosition != new Vector3(0, 0, 0)) &&
                                                                                                                                           (ChildElement33.transform.localRotation != Quaternion.Euler(0, 0, 0)))
                                                                                                                                        {
                                                                                                                                            ChildElement33.transform.localPosition = new Vector3(0, 0, 0);
                                                                                                                                            ChildElement33.transform.localRotation = Quaternion.Euler(0, 0, 0);
                                                                                                                                            lastScore = lastScore - 115;

                                                                                                                                        }
                                                                                                                                        else
                                                                                                                                        {
                                                                                                                                            if ((ChildElement34.transform.localPosition != new Vector3(0, 0, 0)) &&
                                                                                                                                               (ChildElement34.transform.localRotation != Quaternion.Euler(0, 0, 0)))
                                                                                                                                            {
                                                                                                                                                ChildElement34.transform.localPosition = new Vector3(0, 0, 0);
                                                                                                                                                ChildElement34.transform.localRotation = Quaternion.Euler(0, 0, 0);
                                                                                                                                                lastScore = lastScore - 115;

                                                                                                                                            }
                                                                                                                                            else
                                                                                                                                            {
                                                                                                                                                if ((ChildElement35.transform.localPosition != new Vector3(0, 0, 0)) &&
                                                                                                                                                   (ChildElement35.transform.localRotation != Quaternion.Euler(0, 0, 0)))
                                                                                                                                                {
                                                                                                                                                    ChildElement35.transform.localPosition = new Vector3(0, 0, 0);
                                                                                                                                                    ChildElement35.transform.localRotation = Quaternion.Euler(0, 0, 0);
                                                                                                                                                    lastScore = lastScore - 115;

                                                                                                                                                }
                                                                                                                                                else
                                                                                                                                                {
                                                                                                                                                    if ((ChildElement36.transform.localPosition != new Vector3(0, 0, 0)) &&
                                                                                                                                                       (ChildElement36.transform.localRotation != Quaternion.Euler(0, 0, 0)))
                                                                                                                                                    {
                                                                                                                                                        ChildElement36.transform.localPosition = new Vector3(0, 0, 0);
                                                                                                                                                        ChildElement36.transform.localRotation = Quaternion.Euler(0, 0, 0);
                                                                                                                                                        lastScore = lastScore - 115;

                                                                                                                                                    }
                                                                                                                                                    else
                                                                                                                                                    {
                                                                                                                                                        if ((ChildElement37.transform.localPosition != new Vector3(0, 0, 0)) &&
                                                                                                                                                           (ChildElement37.transform.localRotation != Quaternion.Euler(0, 0, 0)))
                                                                                                                                                        {
                                                                                                                                                            ChildElement37.transform.localPosition = new Vector3(0, 0, 0);
                                                                                                                                                            ChildElement37.transform.localRotation = Quaternion.Euler(0, 0, 0);
                                                                                                                                                            lastScore = lastScore -115;

                                                                                                                                                        }
                                                                                                                                                        else
                                                                                                                                                        {
                                                                                                                                                            if ((ChildElement38.transform.localPosition != new Vector3(0, 0, 0)) &&
                                                                                                                                                               (ChildElement38.transform.localRotation != Quaternion.Euler(0, 0, 0)))
                                                                                                                                                            {
                                                                                                                                                                ChildElement38.transform.localPosition = new Vector3(0, 0, 0);
                                                                                                                                                                ChildElement38.transform.localRotation = Quaternion.Euler(0, 0, 0);
                                                                                                                                                                lastScore = lastScore - 115;

                                                                                                                                                            }
                                                                                                                                                            else
                                                                                                                                                            {
                                                                                                                                                                if ((ChildElement39.transform.localPosition != new Vector3(0, 0, 0)) &&
                                                                                                                                                                   (ChildElement39.transform.localRotation != Quaternion.Euler(0, 0, 0)))
                                                                                                                                                                {
                                                                                                                                                                    ChildElement39.transform.localPosition = new Vector3(0, 0, 0);
                                                                                                                                                                    ChildElement39.transform.localRotation = Quaternion.Euler(0, 0, 0);
                                                                                                                                                                    lastScore = lastScore - 115;

                                                                                                                                                                }
                                                                                                                                                                else
                                                                                                                                                                {
                                                                                                                                                                    if ((ChildElement40.transform.localPosition != new Vector3(0, 0, 0)) &&
                                                                                                                                                                       (ChildElement40.transform.localRotation != Quaternion.Euler(0, 0, 0)))
                                                                                                                                                                    {
                                                                                                                                                                        ChildElement40.transform.localPosition = new Vector3(0, 0, 0);
                                                                                                                                                                        ChildElement40.transform.localRotation = Quaternion.Euler(0, 0, 0);
                                                                                                                                                                        lastScore = lastScore - 115;

                                                                                                                                                                    }
                                                                                                                                                                    else
                                                                                                                                                                    {
                                                                                                                                                                        if ((ChildElement41.transform.localPosition != new Vector3(0, 0, 0)) &&
                                                                                                                                                                           (ChildElement41.transform.localRotation != Quaternion.Euler(0, 0, 0)))
                                                                                                                                                                        {
                                                                                                                                                                            ChildElement41.transform.localPosition = new Vector3(0, 0, 0);
                                                                                                                                                                            ChildElement41.transform.localRotation = Quaternion.Euler(0, 0, 0);
                                                                                                                                                                            lastScore = lastScore - 115;

                                                                                                                                                                        }
                                                                                                                                                                        else
                                                                                                                                                                        {
                                                                                                                                                                            if ((ChildElement42.transform.localPosition != new Vector3(0, 0, 0)) &&
                                                                                                                                                                               (ChildElement42.transform.localRotation != Quaternion.Euler(0, 0, 0)))
                                                                                                                                                                            {
                                                                                                                                                                                ChildElement42.transform.localPosition = new Vector3(0, 0, 0);
                                                                                                                                                                                ChildElement42.transform.localRotation = Quaternion.Euler(0, 0, 0);
                                                                                                                                                                                lastScore = lastScore - 115;

                                                                                                                                                                            }
                                                                                                                                                                            else
                                                                                                                                                                            {
                                                                                                                                                                                if ((ChildElement43.transform.localPosition != new Vector3(0, 0, 0)) &&
                                                                                                                                                                                   (ChildElement43.transform.localRotation != Quaternion.Euler(0, 0, 0)))
                                                                                                                                                                                {
                                                                                                                                                                                    ChildElement43.transform.localPosition = new Vector3(0, 0, 0);
                                                                                                                                                                                    ChildElement43.transform.localRotation = Quaternion.Euler(0, 0, 0);
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

    IEnumerator Score()
    {
        if ((ChildElement1.transform.localPosition == new Vector3(0, 0, 0)) &&
          (ChildElement1.transform.localRotation == Quaternion.Euler(0, 0, 0)) &&
          (ChildElement2.transform.localPosition == new Vector3(0, 0, 0)) &&
          (ChildElement2.transform.localRotation == Quaternion.Euler(0, 0, 0)) &&
          (ChildElement3.transform.localPosition == new Vector3(0, 0, 0)) &&
          (ChildElement3.transform.localRotation == Quaternion.Euler(0, 0, 0)) &&
          (ChildElement4.transform.localPosition == new Vector3(0, 0, 0)) &&
          (ChildElement4.transform.localRotation == Quaternion.Euler(0, 0, 0)) &&
          (ChildElement5.transform.localPosition == new Vector3(0, 0, 0)) &&
          (ChildElement5.transform.localRotation == Quaternion.Euler(0, 0, 0)) &&
          (ChildElement6.transform.localPosition == new Vector3(0, 0, 0)) &&
          (ChildElement6.transform.localRotation == Quaternion.Euler(0, 0, 0)) &&
          (ChildElement7.transform.localPosition == new Vector3(0, 0, 0)) &&
          (ChildElement7.transform.localRotation == Quaternion.Euler(0, 0, 0)) &&
          (ChildElement8.transform.localPosition == new Vector3(0, 0, 0)) &&
          (ChildElement8.transform.localRotation == Quaternion.Euler(0, 0, 0)) &&
          (ChildElement9.transform.localPosition == new Vector3(0, 0, 0)) &&
          (ChildElement9.transform.localRotation == Quaternion.Euler(0, 0, 0)) &&
          (ChildElement10.transform.localPosition == new Vector3(0, 0, 0)) &&
          (ChildElement10.transform.localRotation == Quaternion.Euler(0, 0, 0)) &&
          (ChildElement11.transform.localPosition == new Vector3(0, 0, 0)) &&
          (ChildElement11.transform.localRotation == Quaternion.Euler(0, 0, 0)) &&
          (ChildElement12.transform.localPosition == new Vector3(0, 0, 0)) &&
          (ChildElement12.transform.localRotation == Quaternion.Euler(0, 0, 0)) &&
          (ChildElement13.transform.localPosition == new Vector3(0, 0, 0)) &&
          (ChildElement13.transform.localRotation == Quaternion.Euler(0, 0, 0)) &&
          (ChildElement14.transform.localPosition == new Vector3(0, 0, 0)) &&
          (ChildElement14.transform.localRotation == Quaternion.Euler(0, 0, 0)) &&
          (ChildElement15.transform.localPosition == new Vector3(0, 0, 0)) &&
          (ChildElement15.transform.localRotation == Quaternion.Euler(0, 0, 0)) &&
          (ChildElement16.transform.localPosition == new Vector3(0, 0, 0)) &&
          (ChildElement16.transform.localRotation == Quaternion.Euler(0, 0, 0)) &&
          (ChildElement17.transform.localPosition == new Vector3(0, 0, 0)) &&
          (ChildElement17.transform.localRotation == Quaternion.Euler(0, 0, 0)) &&
          (ChildElement18.transform.localPosition == new Vector3(0, 0, 0)) &&
          (ChildElement18.transform.localRotation == Quaternion.Euler(0, 0, 0)) &&
          (ChildElement19.transform.localPosition == new Vector3(0, 0, 0)) &&
          (ChildElement19.transform.localRotation == Quaternion.Euler(0, 0, 0)) &&
          (ChildElement20.transform.localPosition == new Vector3(0, 0, 0)) &&
          (ChildElement20.transform.localRotation == Quaternion.Euler(0, 0, 0)) &&
          (ChildElement21.transform.localPosition == new Vector3(0, 0, 0)) &&
          (ChildElement21.transform.localRotation == Quaternion.Euler(0, 0, 0)) &&
          (ChildElement22.transform.localPosition == new Vector3(0, 0, 0)) &&
          (ChildElement22.transform.localRotation == Quaternion.Euler(0, 0, 0)) &&
          (ChildElement23.transform.localPosition == new Vector3(0, 0, 0)) &&
          (ChildElement23.transform.localRotation == Quaternion.Euler(0, 0, 0)) &&
          (ChildElement24.transform.localPosition == new Vector3(0, 0, 0)) &&
          (ChildElement24.transform.localRotation == Quaternion.Euler(0, 0, 0)) &&
          (ChildElement25.transform.localPosition == new Vector3(0, 0, 0)) &&
          (ChildElement25.transform.localRotation == Quaternion.Euler(0, 0, 0)) &&
          (ChildElement26.transform.localPosition == new Vector3(0, 0, 0)) &&
          (ChildElement26.transform.localRotation == Quaternion.Euler(0, 0, 0)) &&
          (ChildElement27.transform.localPosition == new Vector3(0, 0, 0)) &&
          (ChildElement27.transform.localRotation == Quaternion.Euler(0, 0, 0)) &&
          (ChildElement28.transform.localPosition == new Vector3(0, 0, 0)) &&
          (ChildElement28.transform.localRotation == Quaternion.Euler(0, 0, 0)) &&
          (ChildElement29.transform.localPosition == new Vector3(0, 0, 0)) &&
          (ChildElement29.transform.localRotation == Quaternion.Euler(0, 0, 0)) &&
          (ChildElement30.transform.localPosition == new Vector3(0, 0, 0)) &&
          (ChildElement30.transform.localRotation == Quaternion.Euler(0, 0, 0)) &&
          (ChildElement31.transform.localPosition == new Vector3(0, 0, 0)) &&
          (ChildElement31.transform.localRotation == Quaternion.Euler(0, 0, 0)) &&
          (ChildElement32.transform.localPosition == new Vector3(0, 0, 0)) &&
          (ChildElement32.transform.localRotation == Quaternion.Euler(0, 0, 0)) &&
          (ChildElement33.transform.localPosition == new Vector3(0, 0, 0)) &&
          (ChildElement33.transform.localRotation == Quaternion.Euler(0, 0, 0)) &&
          (ChildElement34.transform.localPosition == new Vector3(0, 0, 0)) &&
          (ChildElement34.transform.localRotation == Quaternion.Euler(0, 0, 0)) &&
          (ChildElement35.transform.localPosition == new Vector3(0, 0, 0)) &&
          (ChildElement35.transform.localRotation == Quaternion.Euler(0, 0, 0)) &&
          (ChildElement36.transform.localPosition == new Vector3(0, 0, 0)) &&
          (ChildElement36.transform.localRotation == Quaternion.Euler(0, 0, 0)) &&
          (ChildElement37.transform.localPosition == new Vector3(0, 0, 0)) &&
          (ChildElement37.transform.localRotation == Quaternion.Euler(0, 0, 0)) &&
          (ChildElement38.transform.localPosition == new Vector3(0, 0, 0)) &&
          (ChildElement38.transform.localRotation == Quaternion.Euler(0, 0, 0)) &&
          (ChildElement39.transform.localPosition == new Vector3(0, 0, 0)) &&
          (ChildElement39.transform.localRotation == Quaternion.Euler(0, 0, 0)) &&
          (ChildElement40.transform.localPosition == new Vector3(0, 0, 0)) &&
          (ChildElement40.transform.localRotation == Quaternion.Euler(0, 0, 0)) &&
          (ChildElement41.transform.localPosition == new Vector3(0, 0, 0)) &&
          (ChildElement41.transform.localRotation == Quaternion.Euler(0, 0, 0)) &&
          (ChildElement42.transform.localPosition == new Vector3(0, 0, 0)) &&
          (ChildElement42.transform.localRotation == Quaternion.Euler(0, 0, 0)) &&
          (ChildElement43.transform.localPosition == new Vector3(0, 0, 0)) &&
          (ChildElement43.transform.localRotation == Quaternion.Euler(0, 0, 0))
           )
        {
            ZPlayerPrefs.SetString("level", "level7");
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



}
