using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEiffel : MonoBehaviour
{
    public GameObject child;
    void Start()
    {
      child.transform.localPosition = new Vector3(Random.Range((float)-0.5,(float)-0.2), Random.Range((float)0.5,(float) 0.6), child.transform.localPosition.z);
        
    }

}
