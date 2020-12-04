using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceDameDeFrance : MonoBehaviour
{
    public GameObject child;
    float distance;
    Vector3 rightPoistion = new Vector3(0, 0, 0);

    void Start()
    {
        
    }

   
    void Update()
    {
      
        distance = Vector3.Distance(child.transform.localPosition, rightPoistion);
       if(distance< 16f)
        {
          child.transform.localPosition = rightPoistion;
         
        }

    }
}
