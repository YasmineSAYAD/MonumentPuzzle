using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloquerSurY : MonoBehaviour
{
    public GameObject gobj;
    void Update()
    {
        if (gobj.transform.localPosition.y != 0)
        {
            gobj.transform.localPosition = new Vector3(gobj.transform.localPosition.x, 0, gobj.transform.localPosition.z);
        }
    }
}
