using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ScoreEiffel : MonoBehaviour
{

    [SerializeField]
    private int lastScore;
    public Text score,score1,time;
    public Button joker;
    public GameObject ChildElement3, ChildElement2, ChildElement, ChildElement4, ChildElement5, ChildElement6, ChildElement7,
        ChildElement8, ChildElement9, ChildElement10, ChildElement11, imageVect,image2;
    int i = 0, j = 0, i1 = 0, j1 = 0, i2 = 0, j2 = 0, i3 = 0, j3 = 0, i4 = 0, j4 = 0, i5 = 0, j5 = 0, i6 = 0, j6 = 0,
        i7 = 0, j7 = 0, i8 = 0, j8 = 0, i9 = 0, j9 = 0, i10 = 0, j10 = 0,
        imgv=0,imghist=0;
   
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


        if ((ChildElement.transform.localPosition == new Vector3((float)0.2829627, (float)0.4781862, (float)0.5602344)) && i == 0)
        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i = 1;

        }

        if ((ChildElement.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) && j == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j = 1;

        }

        if ((ChildElement2.transform.localPosition == new Vector3((float)0.2829627, (float)0.4781862, (float)0.5602344)) && i1 == 0)
        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i1 = 1;

        }

        if ((ChildElement2.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) && j1 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j1 = 1;

        }

        if ((ChildElement3.transform.localPosition == new Vector3((float)0.2829627, (float)0.4781862, (float)0.5602344)) && i2 == 0)
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

        if ((ChildElement4.transform.localPosition == new Vector3((float)0.2829627, (float)0.4781862, (float)0.5602344)) && i3 == 0)
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

        if ((ChildElement5.transform.localPosition == new Vector3((float)0.2829627, (float)0.4781862, (float)0.5602344)) && i4 == 0)
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

        if ((ChildElement6.transform.localPosition == new Vector3((float)0.2829627, (float)0.4781862, (float)0.5602344)) && i5 == 0)
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

        if ((ChildElement7.transform.localPosition == new Vector3((float)0.2829627, (float)0.4781862, (float)0.5602344)) && i6 == 0)
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
        if ((ChildElement8.transform.localPosition == new Vector3((float)0.2829627, (float)0.4781862, (float)0.5602344)) && i7 == 0)
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

        if ((ChildElement9.transform.localPosition == new Vector3((float)0.2829627, (float)0.4781862, (float)0.5602344)) && i8 == 0)
        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 5;
            i8 = 1;

        }

        if ((ChildElement9.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) && j8 == 0)

        {
            source.PlayOneShot(clipshortVic);
            lastScore = lastScore + 10;
            j8= 1;

        }

        if ((ChildElement10.transform.localPosition == new Vector3((float)0.2829627, (float)0.4781862, (float)0.5602344)) && i9 == 0)
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

        if ((ChildElement11.transform.localPosition == new Vector3((float)0.2829627, (float)0.4781862, (float)0.5602344)) && i10 == 0)
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

   
     
    }
    public void Joker()
    {


        if ((ChildElement.transform.localPosition != new Vector3((float)0.2829627, (float)0.4781862, (float)0.5602344)) &&
            (ChildElement.transform.localRotation != Quaternion.Euler((float)-89.98, 0, 0)))
        {
            ChildElement.transform.localPosition = new Vector3((float)0.2829627, (float)0.4781862, (float)0.5602344);
            ChildElement.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
            lastScore = lastScore - 115;

        }
        else
        {


            if ((ChildElement2.transform.localPosition != new Vector3((float)0.2829627, (float)0.4781862, (float)0.5602344)) &&
            (ChildElement2.transform.localRotation != Quaternion.Euler((float)-89.98, 0, 0)))
            {
                ChildElement2.transform.localPosition = new Vector3((float)0.2829627, (float)0.4781862, (float)0.5602344);
                ChildElement2.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                lastScore = lastScore - 115;

            }
            else
            {

                if ((ChildElement3.transform.localPosition != new Vector3((float)0.2829627, (float)0.4781862, (float)0.5602344)) &&
             (ChildElement3.transform.localRotation != Quaternion.Euler((float)-89.98, 0, 0)))
                {
                    ChildElement3.transform.localPosition = new Vector3((float)0.2829627, (float)0.4781862, (float)0.5602344);
                    ChildElement3.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                    lastScore = lastScore - 115;

                }
                else
                {

                    if ((ChildElement4.transform.localPosition != new Vector3((float)0.2829627, (float)0.4781862, (float)0.5602344)) &&
                 (ChildElement4.transform.localRotation != Quaternion.Euler((float)-89.98, 0, 0)))
                    {
                        ChildElement4.transform.localPosition = new Vector3((float)0.2829627, (float)0.4781862, (float)0.5602344);
                        ChildElement4.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                        lastScore = lastScore - 115;

                    }
                    else
                    {

                        if ((ChildElement5.transform.localPosition != new Vector3((float)0.2829627, (float)0.4781862, (float)0.5602344)) &&
                     (ChildElement5.transform.localRotation != Quaternion.Euler((float)-89.98, 0, 0)))
                        {
                            ChildElement5.transform.localPosition = new Vector3((float)0.2829627, (float)0.4781862, (float)0.5602344);
                            ChildElement5.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                            lastScore = lastScore - 115;

                        }
                        else
                        {

                            if ((ChildElement6.transform.localPosition != new Vector3((float)0.2829627, (float)0.4781862, (float)0.5602344)) &&
                         (ChildElement6.transform.localRotation != Quaternion.Euler((float)-89.98, 0, 0)))
                            {
                                ChildElement6.transform.localPosition = new Vector3((float)0.2829627, (float)0.4781862, (float)0.5602344);
                                ChildElement6.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                                lastScore = lastScore - 115;

                            }
                            else
                            {

                                if ((ChildElement7.transform.localPosition != new Vector3((float)0.2829627, (float)0.4781862, (float)0.5602344)) &&
                             (ChildElement7.transform.localRotation != Quaternion.Euler((float)-89.98, 0, 0)))
                                {
                                    ChildElement7.transform.localPosition = new Vector3((float)0.2829627, (float)0.4781862, (float)0.5602344);
                                    ChildElement7.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                                    lastScore = lastScore - 115;

                                }
                                else
                                {

                                    if ((ChildElement8.transform.localPosition != new Vector3((float)0.2829627, (float)0.4781862, (float)0.5602344)) &&
                                 (ChildElement8.transform.localRotation != Quaternion.Euler((float)-89.98, 0, 0)))
                                    {
                                        ChildElement8.transform.localPosition = new Vector3((float)0.2829627, (float)0.4781862, (float)0.5602344);
                                        ChildElement8.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                                        lastScore = lastScore - 115;

                                    }
                                    else
                                    {

                                        if ((ChildElement9.transform.localPosition != new Vector3((float)0.2829627, (float)0.4781862, (float)0.5602344)) &&
                                     (ChildElement9.transform.localRotation != Quaternion.Euler((float)-89.98, 0, 0)))
                                        {
                                            ChildElement9.transform.localPosition = new Vector3((float)0.2829627, (float)0.4781862, (float)0.5602344);
                                            ChildElement9.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                                            lastScore = lastScore - 115;

                                        }
                                        else
                                        {

                                            if ((ChildElement10.transform.localPosition != new Vector3((float)0.2829627, (float)0.4781862, (float)0.5602344)) &&
                                         (ChildElement10.transform.localRotation != Quaternion.Euler((float)-89.98, 0, 0)))
                                            {
                                                ChildElement10.transform.localPosition = new Vector3((float)0.2829627, (float)0.4781862, (float)0.5602344);
                                                ChildElement10.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
                                                lastScore = lastScore - 115;

                                            }
                                            else
                                            {

                                                if ((ChildElement11.transform.localPosition != new Vector3((float)0.2829627, (float)0.4781862, (float)0.5602344)) &&
                                             (ChildElement11.transform.localRotation != Quaternion.Euler((float)-89.98, 0, 0)))
                                                {
                                                    ChildElement11.transform.localPosition = new Vector3((float)0.2829627, (float)0.4781862, (float)0.5602344);
                                                    ChildElement11.transform.localRotation = Quaternion.Euler((float)-89.98, 0, 0);
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

    IEnumerator Score()
    {
        if ((ChildElement.transform.localPosition == new Vector3((float)0.2829627, (float)0.4781862, (float)0.5602344)) &&
          (ChildElement.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) &&
          (ChildElement2.transform.localPosition == new Vector3((float)0.2829627, (float)0.4781862, (float)0.5602344)) &&
          (ChildElement2.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) &&
          (ChildElement3.transform.localPosition == new Vector3((float)0.2829627, (float)0.4781862, (float)0.5602344)) &&
          (ChildElement3.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) &&
          (ChildElement4.transform.localPosition == new Vector3((float)0.2829627, (float)0.4781862, (float)0.5602344)) &&
          (ChildElement4.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) &&
          (ChildElement5.transform.localPosition == new Vector3((float)0.2829627, (float)0.4781862, (float)0.5602344)) &&
          (ChildElement5.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) &&
          (ChildElement6.transform.localPosition == new Vector3((float)0.2829627, (float)0.4781862, (float)0.5602344)) &&
          (ChildElement6.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) &&
          (ChildElement7.transform.localPosition == new Vector3((float)0.2829627, (float)0.4781862, (float)0.5602344)) &&
          (ChildElement7.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) &&
          (ChildElement8.transform.localPosition == new Vector3((float)0.2829627, (float)0.4781862, (float)0.5602344)) &&
          (ChildElement8.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) &&
          (ChildElement9.transform.localPosition == new Vector3((float)0.2829627, (float)0.4781862, (float)0.5602344)) &&
          (ChildElement9.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) &&
          (ChildElement10.transform.localPosition == new Vector3((float)0.2829627, (float)0.4781862, (float)0.5602344)) &&
          (ChildElement10.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) &&
          (ChildElement11.transform.localPosition == new Vector3((float)0.2829627, (float)0.4781862, (float)0.5602344)) &&
          (ChildElement11.transform.localRotation == Quaternion.Euler((float)-89.98, 0, 0)) 
         )
        {
            ZPlayerPrefs.SetString("level", "level4");
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
