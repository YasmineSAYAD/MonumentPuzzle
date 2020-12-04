using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class offSounds : MonoBehaviour, IPointerClickHandler
{
    public GameObject isOff, isON;

    void Start()
    {
        ZPlayerPrefs.Initialize("y1a2s3", "8745dsdfE7D8df8425SDmjgh4fgtR");
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        isOff.SetActive(true);
        isON.SetActive(false);
        ZPlayerPrefs.SetString("sounds", "off");
    }
    }
