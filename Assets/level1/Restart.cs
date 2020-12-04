using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
public class Restart : MonoBehaviour
{
    public string MapAChanger;
    public GameObject  imagePause, imagePlay, menuPause;
  public void restart()
    {
        SceneManager.LoadScene(MapAChanger);
        imagePlay.SetActive(true);
        Time.timeScale = 1;
        imagePause.SetActive(false);
        menuPause.SetActive(false);
    }
}
