using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenBoundsArc : MonoBehaviour
{
    public GameObject gobj;
    void Update()
    {
        gobj.transform.localPosition = new Vector3(Mathf.Clamp(gobj.transform.localPosition.x,-4, (float)3.5),
        Mathf.Clamp(gobj.transform.localPosition.y, (float)0.2740375, (float)2.1), gobj.transform.localPosition.z);
      
    }
}
