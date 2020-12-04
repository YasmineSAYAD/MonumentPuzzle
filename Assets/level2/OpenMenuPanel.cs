using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMenuPanel : MonoBehaviour
{



    public GameObject image;

    public void OpenClose()
    {
       
        if (image != null && image.activeSelf)
        {
            
            image.SetActive(false);
        }
        else
        {
            if(image != null && !image.activeSelf)
          
            image.SetActive(true);
            
        }
    }
}

