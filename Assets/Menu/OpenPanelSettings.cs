using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPanelSettings : MonoBehaviour
{
    public GameObject settings;  
  public void open()
    {
        settings.SetActive(true);
    }
}
