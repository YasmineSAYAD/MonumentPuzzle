using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLiberty : MonoBehaviour
{
    public GameObject child,child2;
    void Start()
    {

       child.transform.localPosition = new Vector3(Random.Range(90, 200), Random.Range(-180, 180), child.transform.localPosition.z);
       child2.transform.localPosition = new Vector3(Random.Range(-400, -90), Random.Range(-320,20), child.transform.localPosition.z);
        // child.transform.localPosition = new Vector3(0, 0, 0);
    }

}
