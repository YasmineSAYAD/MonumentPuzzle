using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPanelColor : MonoBehaviour
{
    public GameObject imageColor, ImageMenu;
   public void Open()
    {
        imageColor.SetActive(true);
        ImageMenu.SetActive(false);
    }
}
