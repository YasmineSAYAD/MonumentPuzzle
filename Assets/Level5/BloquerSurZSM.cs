using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloquerSurZSM : MonoBehaviour
{
    public GameObject gobj;
    void Update()
    {
        if (gobj.transform.localPosition.z != -3.052516)
        {
            gobj.transform.localPosition = new Vector3(gobj.transform.localPosition.x, gobj.transform.localPosition.y, (float)-3.052516);
        }
    }
}
