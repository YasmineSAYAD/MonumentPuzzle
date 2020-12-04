using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ScoreArc : MonoBehaviour
{
    public Text score1 ,score2,time, indicationMove, indicationRotate;
    public GameObject Child,image2,imageVect;
    int a = 0, b = 0, i = 0,j=0;
    public int points;
    public string MapAChanger;
    public AudioSource source, sourceshortVic;
    public AudioClip clip, clipshortVic;
    void Start()
    {
        ZPlayerPrefs.Initialize("y1a2s3", "8745dsdfE7D8df8425SDmjgh4fgtR");
        points = 0;
        ZPlayerPrefs.SetString("succes", "no");

    }


   void Update() {
        StartCoroutine(Score());
        score1.text = points + "";
        if ((Child.transform.localPosition == new Vector3((float)0.008040782, (float)0.2740375, 0))
             && a == 0)
        {
          
            points = points + 5;
            source.PlayOneShot(clipshortVic);
            a = 1;



        }

        if (Child.transform.localRotation == Quaternion.Euler((float)-89.98,180, 0)
              && b == 0)

        {
            
           points = points + 10;
           source.PlayOneShot(clipshortVic);
            b = 1;

        }
    }
    IEnumerator Score()
    {

        if ((Child.transform.localPosition == new Vector3((float)0.008040782, (float)0.2740375, 0)) &&
        (Child.transform.localRotation == Quaternion.Euler((float)-89.98, 180, 0)))
        {
            ZPlayerPrefs.SetString("level", "level2");
            ZPlayerPrefs.SetInt("Score", points);
            score2.text = "Score: " + ZPlayerPrefs.GetInt("Score");
            indicationMove.gameObject.SetActive(false);
            indicationRotate.gameObject.SetActive(false);
            time.gameObject.SetActive(false);
            // victoire
            if (j == 0) {
                source.PlayOneShot(clip);
                imageVect.SetActive(true);
                j = 1;
            }
            yield return new WaitForSeconds(2);

            imageVect.SetActive(false);
            //afficher l'histoire
            if (i == 0)
            {

                image2.SetActive(true);
                i = 1;
            }


        }

    }

}
