using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPanels : MonoBehaviour
{
    public GameObject image;
    public void OpenPanel()
    {
        if (image != null)
        {
            image.SetActive(true);
        }
    }
}
