using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloquerSurZEiffel : MonoBehaviour
{
    public GameObject gobj;
    void Update()
    {
        if (gobj.transform.localPosition.z != 0.5602344)
        {
            gobj.transform.localPosition = new Vector3(gobj.transform.localPosition.x, gobj.transform.localPosition.y,(float) 0.5602344);
        }
    }
}
