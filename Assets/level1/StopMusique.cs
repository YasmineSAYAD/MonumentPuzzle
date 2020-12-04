using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopMusique : MonoBehaviour
{
    public AudioSource source;
    public GameObject toggleMusique;
    string musique;

    void Start()
    {
        ZPlayerPrefs.Initialize("y1a2s3", "8745dsdfE7D8df8425SDmjgh4fgtR");
        musique = ZPlayerPrefs.GetString("musiques");
    }
    void Update()
    {
        if (musique == "off")
        {
            source.mute = true;
            toggleMusique.SetActive(false);
        }

    }
}
