using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceEiffel : MonoBehaviour
{
    public GameObject child;
    float distance;
    Vector3 rightPoistion = new Vector3((float)0.2829627,(float) 0.4781862,(float) 0.5602344);




    void Update()
    {

        distance = Vector3.Distance(child.transform.localPosition, rightPoistion);
        if (distance < 0.11f)
        {
            child.transform.localPosition = rightPoistion;

        }


    }
}
