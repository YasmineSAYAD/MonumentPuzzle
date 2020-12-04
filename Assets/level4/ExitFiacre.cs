using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitFiacre : MonoBehaviour
{
    void Start()
    {
        ZPlayerPrefs.Initialize("y1a2s3", "8745dsdfE7D8df8425SDmjgh4fgtR");
    }
    public void quitter()
    {
        ZPlayerPrefs.SetString("level", "level4");
        Application.Quit();
        Time.timeScale = 1;
    }
}
