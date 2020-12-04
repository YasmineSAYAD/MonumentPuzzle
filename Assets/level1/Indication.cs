using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Indication : MonoBehaviour
{
    public Text indicationText;
    public GameObject flecheIndication;

    void Start()
    {
        indicationText.gameObject.SetActive(true);
        flecheIndication.SetActive(false);
        StartCoroutine(indication());
    }
  
    IEnumerator indication()
    {
        flecheIndication.SetActive(true);
        yield return new WaitForSeconds(1);
        flecheIndication.SetActive(false);
        yield return new WaitForSeconds(1);
        flecheIndication.SetActive(true);
        yield return new WaitForSeconds(1);
        flecheIndication.SetActive(false);
        indicationText.gameObject.SetActive(false);
    }

}
