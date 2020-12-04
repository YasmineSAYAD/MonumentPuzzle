using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TimerArc : MonoBehaviour
{
    private float totalTime = 20f;
    public Text timer;
    public GameObject Panelrestart;
    public AudioClip clip;
    public AudioSource source;
    int minutes, seconds;
    bool stop = false;
    private void Update()
    {
        totalTime -= Time.deltaTime;
        UpdateTimer(totalTime);
    }

    public void UpdateTimer(float totalSeconds)
    {
        seconds = Math.Abs(Mathf.RoundToInt(totalSeconds % 60f));
        StartCoroutine(Fail());
      if (!stop)
       {

            string formatedSeconds = seconds.ToString();
            timer.text = minutes.ToString("00") + ":" + seconds.ToString("00");
        }


    }
    IEnumerator Fail()
    {
        if (minutes == 0 && seconds == 0)
        {
            timer.text = "00:00";
           stop = true;
            source.PlayOneShot(clip);
            yield return new WaitForSeconds(1);
            Panelrestart.SetActive(true);

        }
    
    }
}
