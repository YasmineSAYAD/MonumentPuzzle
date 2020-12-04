using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopSounds : MonoBehaviour
{
    public AudioSource sourceFailing, sourceLevelUp, sourceTransition, sourceVictory, sourceShortVictory;
    public GameObject toggleSound;

    string sound;
    void Start()
    {
        ZPlayerPrefs.Initialize("y1a2s3", "8745dsdfE7D8df8425SDmjgh4fgtR");
        sound = ZPlayerPrefs.GetString("sounds");
    }

    
    void Update()
    {
        if(sound== "off")
        {
            sourceFailing.mute=true;
            sourceLevelUp.mute = true;
            sourceTransition.mute = true;
            sourceVictory.mute = true;
            sourceShortVictory.mute = true;
            toggleSound.SetActive(false);
        }
        
    }
}
