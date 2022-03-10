using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingGameCageScr : MonoBehaviour
{
    GMScript GM;
    public float scorePerCatch, moveSpeed;
    public GameObject fish, walls;
    GameObject L, R, WL, WR;
    bool catchingFish = false;

    // Start is called before the first frame update
    void Start()
    {
        GM = GameObject.Find("GameManager").GetComponent<GMScript>();
        L = gameObject.transform.GetChild(0).gameObject;
        R = gameObject.transform.GetChild(1).gameObject;
        WL = walls.transform.GetChild(0).gameObject;
        WR = walls.transform.GetChild(1).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (GM.minigame3)
        {
            if (catchingFish)
                GM.score += scorePerCatch;

            if (L.transform.position.x < fish.transform.position.x && R.transform.position.x > fish.transform.position.x)
                catchingFish = true;
            else
                catchingFish = false;

            if (Input.GetKey(KeyCode.W))
            {
                gameObject.transform.position += new Vector3(moveSpeed, 0, 0);
            }
            if (Input.GetKey(KeyCode.S))
            {
                gameObject.transform.position -= new Vector3(moveSpeed, 0, 0);
            }

            if (L.transform.position.x < WL.transform.position.x)
            {
                gameObject.transform.position += new Vector3(moveSpeed, 0, 0);
            }
            if (R.transform.position.x > WR.transform.position.x)
            {
                gameObject.transform.position -= new Vector3(moveSpeed, 0, 0);
            }
        }
    }
}
