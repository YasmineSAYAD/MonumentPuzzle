using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceTaj : MonoBehaviour
{
    public GameObject child;
    float distance;
    Vector3 rightPoistion = new Vector3((float)2.00975, (float)-1.551666, (float)-4.396697);




    void Update()
    {

        distance = Vector3.Distance(child.transform.localPosition, rightPoistion);
        if (distance < 0.51f)
        {
            child.transform.localPosition = rightPoistion;

        }


    }
}
