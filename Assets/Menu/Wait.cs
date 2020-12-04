using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wait : MonoBehaviour
{
    public Image img;
    public float maxTime = 3f;
    float timeLeft;
  

    void Start()
    {
        img = GetComponent<Image>();
        timeLeft = maxTime;

    }

  public void Update()
    {
       
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            img.fillAmount = timeLeft / maxTime;
        }
       

    }

    }
