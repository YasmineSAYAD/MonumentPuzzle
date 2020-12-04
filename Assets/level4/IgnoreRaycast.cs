using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreRaycast : MonoBehaviour
{
    public GameObject gobj;
    void Start()
    {
        
    }

  
    void Update()
    {
        if(gobj.transform.localPosition==new Vector3(0,0,0) && gobj.transform.localRotation == Quaternion.Euler(0, 0, 0))
        {
            gobj.layer = LayerMask.NameToLayer("Ignore Raycast");
        }
        
    }
}
