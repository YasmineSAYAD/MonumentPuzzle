using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Reprendre : MonoBehaviour, IPointerClickHandler
{
    public GameObject menuPause, imagePause, imagePlay, ButtonShow;

    public void OnPointerClick(PointerEventData eventData)
    {
        
        imagePlay.SetActive(true);
        Time.timeScale = 1;
       // imageSocialMedia.SetActive(false);
        imagePause.SetActive(false);
        menuPause.SetActive(false);
        if (Time.timeScale == 1)
        {
            ButtonShow.SetActive(true);
        }

    }
}
