using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEifel2 : MonoBehaviour
{
    public GameObject child;
        void Start()
        {
            child.transform.localPosition = new Vector3(Random.Range(1, (float)2.5), Random.Range((float)0.5, 1), child.transform.localPosition.z);

        }

    
}
