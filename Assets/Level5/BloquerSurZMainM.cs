using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloquerSurZMainM : MonoBehaviour
{
    public GameObject gobj;
    void Update()
    {
        if (gobj.transform.localPosition.z != -4.353579)
        {
            gobj.transform.localPosition = new Vector3(gobj.transform.localPosition.x, gobj.transform.localPosition.y,(float) -4.353579);
        }
    }
}
