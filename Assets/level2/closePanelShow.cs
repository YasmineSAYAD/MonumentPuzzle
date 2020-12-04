using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class closePanelShow : MonoBehaviour, IPointerClickHandler
{



    public GameObject image;

    public void OnPointerClick(PointerEventData eventData)
    {

        if (image != null)
        {
            image.SetActive(false);
        }
    }
}

