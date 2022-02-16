using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GMScript : MonoBehaviour
{
    float timeNow = 0f;
    [HideInInspector]
    public float score = 0f, SPS = 0f;
    public TextMeshProUGUI scoreText, SPSText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeNow += Time.deltaTime;
        if(timeNow >= 1f)
        {
            score += SPS;
            timeNow = 0.0f;
        }

        scoreText.text = "Score: " + score.ToString("F0");
        SPSText.text = "Per Second: " + SPS.ToString("F1");

    }
}
