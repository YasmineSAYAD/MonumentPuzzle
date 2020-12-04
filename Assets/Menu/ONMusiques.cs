using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ONMusiques : MonoBehaviour, IPointerClickHandler
{
    public GameObject isOff, isON;

    void Start()
    {
        ZPlayerPrefs.Initialize("y1a2s3", "8745dsdfE7D8df8425SDmjgh4fgtR");
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        isOff.SetActive(false);
        isON.SetActive(true);
        ZPlayerPrefs.SetString("musiques", "ON");
    }
}
