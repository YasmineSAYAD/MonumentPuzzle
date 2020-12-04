using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLevel5 : MonoBehaviour
{
    public GameObject child;
    void Start()
    {

      child.transform.localPosition = new Vector3(Random.Range(-100, 100), Random.Range(-80, 10), child.transform.localPosition.z);
    }
}
