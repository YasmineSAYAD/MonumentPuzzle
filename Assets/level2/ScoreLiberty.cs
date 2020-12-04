using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;




public class ScoreLiberty : MonoBehaviour
{
    [SerializeField]
    private int points,counter;
    public Text score, score1,time;
    public GameObject child2, ChildElement, image2, imageVect;
    int i = 0, j = 0,i1=0,j1=0,imgv=0,imghist=0;
    public string MapAChanger;
    public AudioSource source, sourceshortVic;
    public AudioClip clip, clipshortVic;


    void Start()
    {
        ZPlayerPrefs.Initialize("y1a2s3", "8745dsdfE7D8df8425SDmjgh4fgtR");
        points = ZPlayerPrefs.GetInt("Score");
        ZPlayerPrefs.SetString("succes", "no");

    }


    void Update()
    {
        StartCoroutine(Scorefin());
        score.text = points + "";

        if ((ChildElement.transform.localPosition == new Vector3(0, 0, 0)) && i == 0)
        {
            source.PlayOneShot(clipshortVic);
            points = points + 5;
            counter++;
            i = 1;



        }

        if ((ChildElement.transform.localRotation == Quaternion.Euler((float)-90.5, (float)25.3, 90))
              && j == 0)
         {
            source.PlayOneShot(clipshortVic);
            points = points + 10;
            counter++;
            j = 1;

         }
        if ((child2.transform.localPosition == new Vector3(0, 0, 0))  && i1 == 0)
        {
            source.PlayOneShot(clipshortVic);
            points = points + 5;
            counter++;
            i1 = 1;



        }

        if ((child2.transform.localRotation == Quaternion.Euler((float)-90.5, (float)25.3, 90))
              && j1 == 0)
        {
            source.PlayOneShot(clipshortVic);
            points = points + 10;
            counter++;
            j1 = 1;

        }

    }
    IEnumerator Scorefin()
    {
        if (counter==4)
        {
            ZPlayerPrefs.SetString("level", "level3");
            ZPlayerPrefs.SetInt("Score", points);
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
