using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopSoundMenu : MonoBehaviour
{
    public AudioSource  sourceLevelUp;
    public GameObject toggleSound;

    string sound;
    void Start()
    {
        ZPlayerPrefs.Initialize("y1a2s3", "8745dsdfE7D8df8425SDmjgh4fgtR");
        sound = ZPlayerPrefs.GetString("sounds");
    }


    void Update()
    {
        if (sound == "off")
        {
           
           sourceLevelUp.mute = true;
           
        }

    }
}
