using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static ZPlayerPrefs;

public class Continue : MonoBehaviour
{
    string level;
    public AudioSource source;
    public AudioClip clip;
    void Start()
    {
        ZPlayerPrefs.Initialize("y1a2s3", "8745dsdfE7D8df8425SDmjgh4fgtR");
        level = ZPlayerPrefs.GetString("level");
    }

   
   public void Load()
    {
        if (level.Length==0)
        {
            source.PlayOneShot(clip);
            SceneManager.LoadScene("level1");
        }
        else
        {
            source.PlayOneShot(clip);
            SceneManager.LoadScene(level);
        }
    }
}
