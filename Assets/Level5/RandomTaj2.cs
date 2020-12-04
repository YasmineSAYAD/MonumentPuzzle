using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTaj2 : MonoBehaviour
{
    public GameObject child;
    void Start()
    {
        child.transform.localPosition = new Vector3(Random.Range(8, (float)8.1), Random.Range(-2, 3), child.transform.localPosition.z);

    }
}
