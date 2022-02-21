using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongBallScr : MonoBehaviour
{
    public float ballSpeed = 3;
    Vector2 resetPoint;
    // Start is called before the first frame update
    void Start()
    {
        resetPoint = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void resetBall()
    {
        gameObject.transform.position = resetPoint;

        Vector2 vel = new Vector2(Random.Range(-.8f, .8f), Random.Range(-.8f, .8f));
        vel.Normalize();
        vel = new Vector2(vel.x * ballSpeed, vel.y * ballSpeed);
        gameObject.GetComponent<Rigidbody2D>().velocity = vel;
    }
}
