using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public string level;
    public AudioSource source;
    public AudioClip clip;
    public void Lancer()
    {
        source.PlayOneShot(clip);
        SceneManager.LoadScene(level);
    }
    
   
}
