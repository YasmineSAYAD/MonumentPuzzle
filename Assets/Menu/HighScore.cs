using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Text score;
    int points;
    void Start()
    {
        ZPlayerPrefs.Initialize("y1a2s3", "8745dsdfE7D8df8425SDmjgh4fgtR");
        points = ZPlayerPrefs.GetInt("Score");  
    }

  
    void Update()
    {
        score.text = points + "";
    }
}
