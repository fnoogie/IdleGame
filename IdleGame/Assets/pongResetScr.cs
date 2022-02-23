using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum whichSide
{
    playerScored = 0,
    enemyScored
};

public class pongResetScr : MonoBehaviour
{
    public whichSide mySide;
    GMScript GM;
    // Start is called before the first frame update
    void Start()
    {
        GM = GameObject.Find("GameManager").GetComponent<GMScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name == "PongBall")
        {
            col.gameObject.GetComponent<PongBallScr>().resetBall();

            switch(mySide)
            {
                case whichSide.playerScored:
                    {
                        GM.pongStreak++;
                        GM.startPong();
                        break;
                    }
                case whichSide.enemyScored:
                    {
                        GM.score += GM.pongStreak * GM.pongMult;
                        GM.pongStreak = 0;
                        GM.startPong();
                        break;
                    }
            }
        }
    }
}
