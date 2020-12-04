using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceMainMinaret : MonoBehaviour
{
    public GameObject child;
    float distance;
    Vector3 rightPoistion = new Vector3((float)-0.08180511, (float)-0.1923621, (float)-4.353579);




    void Update()
    {

        distance = Vector3.Distance(child.transform.localPosition, rightPoistion);
        if (distance < 0.51f)
        {
            child.transform.localPosition = rightPoistion;

        }


    }
}
