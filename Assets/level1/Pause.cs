using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Pause : MonoBehaviour, IPointerClickHandler
{
    public GameObject menuPause, imagePause,imagePlay, ButtonShow;

    public void OnPointerClick(PointerEventData eventData)
    {
      
        imagePause.SetActive(true);
        Time.timeScale = 0;
        imagePlay.SetActive(false);
        menuPause.SetActive(true);
        if (Time.timeScale == 0)
        {
            ButtonShow.SetActive (false);
        }
       
    }
}
