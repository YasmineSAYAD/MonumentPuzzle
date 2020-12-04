using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceSmalMinaret : MonoBehaviour
{
    public GameObject child;
    float distance;
    Vector3 rightPoistion = new Vector3((float)1.252619, (float)-0.3987826, (float)-3.052516);




    void Update()
    {

        distance = Vector3.Distance(child.transform.localPosition, rightPoistion);
        if (distance < 0.51f)
        {
            child.transform.localPosition = rightPoistion;

        }


    }
}
