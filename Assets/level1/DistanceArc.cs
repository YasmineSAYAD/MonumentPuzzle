using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceArc : MonoBehaviour
{
    public GameObject child;
    float distance;
    Vector3 rightPoistion = new Vector3((float)0.008040782, (float)0.2740375, 0);
  



    void Update()
    {

        distance = Vector3.Distance(child.transform.localPosition, rightPoistion);
        if (distance < 1f)
        {
            child.transform.localPosition = rightPoistion;

        }


    }
}
