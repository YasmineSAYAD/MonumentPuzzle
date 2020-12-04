using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloquerSurZTopM : MonoBehaviour
{

    public GameObject gobj;
    void Update()
    {
        if (gobj.transform.localPosition.z != -4.344925)
        {
            gobj.transform.localPosition = new Vector3(gobj.transform.localPosition.x, gobj.transform.localPosition.y, (float)-4.344925);
        }
    }
}
