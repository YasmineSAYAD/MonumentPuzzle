using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceMinaretCorners : MonoBehaviour
{
    public GameObject child;
    float distance;
    Vector3 rightPoistion = new Vector3((float)-4.176812, (float)-2.527007, (float)-0.4158702);




    void Update()
    {

        distance = Vector3.Distance(child.transform.localPosition, rightPoistion);
        if (distance < 0.51f)
        {
            child.transform.localPosition = rightPoistion;

        }


    }
}
