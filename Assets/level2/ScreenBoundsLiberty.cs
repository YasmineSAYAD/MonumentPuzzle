using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenBoundsLiberty : MonoBehaviour
{
    public GameObject gobj,gobj1;
    void Update()
    {
        gobj.transform.localPosition = new Vector3(Mathf.Clamp(gobj.transform.localPosition.x, -620, (float)627),
        Mathf.Clamp(gobj.transform.localPosition.y, -178, 227), gobj.transform.localPosition.z);

        gobj1.transform.localPosition = new Vector3(Mathf.Clamp(gobj1.transform.localPosition.x, -635, (float)575),
        Mathf.Clamp(gobj1.transform.localPosition.y, -350, 60), gobj1.transform.localPosition.z);
    }
}
