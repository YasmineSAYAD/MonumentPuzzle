using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResponsiveCamera : MonoBehaviour
{
    public Camera PortraitCamera;
    public Camera LandscapeCamera;

  
    void Update()
    {

        PortraitCamera.enabled = Screen.width <= Screen.height;
        PortraitCamera.GetComponent<AudioListener>().enabled = PortraitCamera.enabled;
        LandscapeCamera.enabled = Screen.width > Screen.height;
        LandscapeCamera.GetComponent<AudioListener>().enabled = LandscapeCamera.enabled;

    }
}
