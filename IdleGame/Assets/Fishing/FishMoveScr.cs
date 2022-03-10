using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMoveScr : MonoBehaviour
{
    public float moveDelay;
    public GameObject walls;
    float timeNow;
    float startY;
    // Start is called before the first frame update
    void Start()
    {
        startY = gameObject.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        timeNow += Time.deltaTime;
        if (timeNow > moveDelay)
            move();
    }

    void move()
    {
        timeNow = 0.0f;
        float rng = Random.Range(walls.transform.GetChild(0).gameObject.transform.position.x + 1.5f, walls.transform.GetChild(1).gameObject.transform.position.x - 1.6f);
        gameObject.transform.position = new Vector3(rng, startY, 0);
    }
}
