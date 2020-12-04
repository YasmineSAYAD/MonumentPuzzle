using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Close : MonoBehaviour
{
    public GameObject image,image2;
   public void fermer()
    {

     image.SetActive(false);
     image2.SetActive(true);

    }

   
}
