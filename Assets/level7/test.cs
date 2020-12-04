using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public GameObject gobj;

    // Update is called once per frame
    void Update()
    {
        if (gobj.transform.localPosition == new Vector3(0, 0, 0))
        {
            gobj.transform.localPosition = new Vector3(80, 0, 0);
        }
    }
}
