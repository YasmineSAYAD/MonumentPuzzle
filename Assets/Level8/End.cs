using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    public GameObject history, end;
    string succes;
    void Start()
    {
       succes = ZPlayerPrefs.GetString("succes");
    }
    void Update()
    {
        if (!history.activeInHierarchy && succes=="yes")
        {
            end.SetActive(true);
            StartCoroutine(wait());
        }
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(3);
        ZPlayerPrefs.SetString("level", "level1");
        SceneManager.LoadScene("Menu");
        end.SetActive(false);


    }
}
