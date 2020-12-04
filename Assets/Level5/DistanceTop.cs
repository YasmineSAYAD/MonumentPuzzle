using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceTop : MonoBehaviour
{
    public GameObject child;
    float distance;
    Vector3 rightPoistion = new Vector3((float)-0.07838482, (float)2.271985, (float)-4.344925);




    void Update()
    {

        distance = Vector3.Distance(child.transform.localPosition, rightPoistion);
        if (distance < 0.31f)
        {
            child.transform.localPosition = rightPoistion;

        }


    }
}
