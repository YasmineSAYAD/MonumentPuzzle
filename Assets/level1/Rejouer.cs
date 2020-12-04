using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rejouer : MonoBehaviour
{
    public string MapAChanger;
   public void rejouer()
    {
        SceneManager.LoadScene(MapAChanger);
    }
}
