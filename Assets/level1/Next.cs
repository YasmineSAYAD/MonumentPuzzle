using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Next : MonoBehaviour
{
    public GameObject image;
    public string MapACharger;
    public AudioSource source;
    public AudioClip clip;
    public void next()
        {
       
        SceneManager.LoadScene(MapACharger);
        source.PlayOneShot(clip);
        }
   
}
