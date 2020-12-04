using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceKing : MonoBehaviour
{
    public GameObject child;
    float distance;
    Vector3 rightPoistion = new Vector3(0, 0, 0);



    void Update()
    {
        if (Vector3.Distance(child.transform.localPosition, rightPoistion) < 21f)
        {
            child.transform.localPosition = rightPoistion;

        }

    }
}
