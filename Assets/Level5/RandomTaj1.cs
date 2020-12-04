using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTaj1 : MonoBehaviour
{
    public GameObject child;
    void Start()
    {
        child.transform.localPosition = new Vector3(Random.Range(-20, -10), Random.Range(1, 8), child.transform.localPosition.z);

    }
}
