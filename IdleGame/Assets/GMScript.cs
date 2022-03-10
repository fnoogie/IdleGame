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

    [Header("Pong")]
    GameObject pongBall;
    public int pongStreak = 0, pongScore = 0;
    public float pongMult = 1;
    public TextMeshProUGUI pongScoreText;

    [Header("Runner")]
    GameObject runnerPlayer;
    float runnerStartTime;
    public int runnerScore;
    public GameObject runnerStart;
    public List<GameObject> runnerPrefabs, spawnedParts;
    // Start is called before the first frame update
    void Start()
    {
        pongBall = GameObject.Find("PongBall");
        runnerPlayer = GameObject.Find("RunnerPlayer");
    }

    // Update is called once per frame
    void Update()
    {
        timeNow += Time.deltaTime;
        runnerStartTime += Time.deltaTime;
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

    public void resetRunner()
    {
        if (minigame2)
        {
            if(spawnedParts.Count > 0)
            {
                for (int i = 0; i < spawnedParts.Count; ++i)
                    Destroy(spawnedParts[i]);
            }
            runnerPlayer.GetComponent<Rigidbody2D>().gravityScale = 1;
            runnerStartTime = 0.0f;
            runnerPlayer.GetComponent<RunnerPlayerScr>().canJump = true;
            runnerPlayer.transform.position = runnerPlayer.GetComponent<RunnerPlayerScr>().startPos;
            GameObject part = Instantiate(runnerStart);
            spawnedParts.Add(part);
            
        }
    }
    public void scoreRunner()
    {
        if(minigame2)
            score += (int)runnerStartTime / 2f;
    }
    public void spawnNewRunnerSegment()
    {
        if (minigame2)
        {
            int rng = Random.Range(0, runnerPrefabs.Count);
            GameObject part = Instantiate(runnerPrefabs[rng]);
            spawnedParts.Add(part);
        }
    }
}
