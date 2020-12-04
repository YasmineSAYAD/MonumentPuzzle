using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class chrono30s : MonoBehaviour
{
    public Image img;

    public float maxTime = 30f;
    float timeLeft;
    public GameObject imgshow;
    public GameObject ButtonShow;

    void Start()
    {
        img = GetComponent<Image>();
        timeLeft = maxTime;

    }

    void Update()
    {

        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            img.fillAmount = timeLeft / maxTime;
        }
        else
        {
            imgshow.SetActive(false);
            ButtonShow.GetComponent<Button>().interactable = false;


        }

    }
}
