using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GMScript : MonoBehaviour
{
    float timeNow = 0f;
    //[HideInInspector]
    public float score = 0f, SPS = 0f;
    public TextMeshProUGUI scoreText, SPSText;
    public bool minigame1 = false, minigame2 = false, minigame3 = false;


    GameObject pongBall;
    public int pongStreak = 0, pongScore = 0;
    public float pongMult = 1;
    public TextMeshProUGUI pongScoreText;
    // Start is called before the first frame update
    void Start()
    {
        pongBall = GameObject.Find("PongBall");
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

        if(minigame1)
        {
            pongScoreText.text = (pongStreak * pongMult).ToString();
        }

    }

    public void startPong()
    {
        pongBall.GetComponent<PongBallScr>().resetBall();
    }
}
