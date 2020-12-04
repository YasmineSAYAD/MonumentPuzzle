using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimerDameDeFrance : MonoBehaviour
{
    float totalTime = 180f;
    public Text timer;
    public GameObject Panelrestart;
    public AudioClip clip;
    public AudioSource source;
    int minutes, seconds;
    bool stop = false;

    private void Update()
    {


        UpdateTimer(totalTime);
    }

    public void UpdateTimer(float totalSeconds)
    {


        minutes = Mathf.FloorToInt(totalSeconds / 60f);
        seconds = Mathf.RoundToInt(totalSeconds % 60f);
        totalTime -= Time.deltaTime;
        StartCoroutine(Fail());
        if (!stop)
        {
            string formatedSeconds = seconds.ToString();
            if (seconds == 60)
            {
                seconds = 0;
                minutes += 1;
            }
            timer.text = minutes.ToString("00") + ":" + seconds.ToString("00");
        }



    }
    IEnumerator Fail()
    {
        if (minutes == 0 && seconds == 1)
        {
            timer.text = "00:00";
            stop = true;
            source.PlayOneShot(clip);
            yield return new WaitForSeconds(1);
            Panelrestart.SetActive(true);

        }

    }

}
