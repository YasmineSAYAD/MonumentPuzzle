using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloquerSurZMC : MonoBehaviour
{
    public GameObject gobj;
    void Update()
    {
        if (gobj.transform.localPosition.z != -0.4158702)
        {
            gobj.transform.localPosition = new Vector3(gobj.transform.localPosition.x, gobj.transform.localPosition.y, (float)-0.4158702);
        }
    }
}
