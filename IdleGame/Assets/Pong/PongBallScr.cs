using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongBallScr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-.8f, .8f), Random.Range(-.8f, .8f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
