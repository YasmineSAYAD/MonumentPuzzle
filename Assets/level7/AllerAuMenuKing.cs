using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AllerAuMenuKing : MonoBehaviour
{
    void Start()
    {
        ZPlayerPrefs.Initialize("y1a2s3", "8745dsdfE7D8df8425SDmjgh4fgtR");
    }
    public void AllerAuMenu()
    {
        ZPlayerPrefs.SetString("level", "level7");
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
    }
}
