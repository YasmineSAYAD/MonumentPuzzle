using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTaj3 : MonoBehaviour
{
    public GameObject child;
    void Start()
    {
        child.transform.localPosition = new Vector3(Random.Range(-10, -8), Random.Range(-2, 0), child.transform.localPosition.z);

    }
}
