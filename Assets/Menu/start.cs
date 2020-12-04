using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{
    public GameObject isONmusique, isOffmusique, isONsounds, isOffsounds;
    string musique, sound;
   
    void Start()
    {
        ZPlayerPrefs.Initialize("y1a2s3", "8745dsdfE7D8df8425SDmjgh4fgtR");
        sound = ZPlayerPrefs.GetString("sounds");
        musique = ZPlayerPrefs.GetString("musiques");
       
        //sounds
        if (sound == "off") 
        {
            isOffsounds.SetActive(true);
            isONsounds.SetActive(false);
        }
        else
        {
            isOffsounds.SetActive(false);
            isONsounds.SetActive(true);
        }

        //musique
        if (musique == "off")
        {
            isOffmusique.SetActive(true);
            isONmusique.SetActive(false);
        }
        else
        {
            isOffmusique.SetActive(false);
            isONmusique.SetActive(true);
        }

        if (isONmusique.activeInHierarchy)
        { 
       ZPlayerPrefs.SetString("musiques", "ON");
        }
        if (isONsounds.activeInHierarchy)
        {

            ZPlayerPrefs.SetString("sounds", "ON");
          
        }
    }
  
   
}
