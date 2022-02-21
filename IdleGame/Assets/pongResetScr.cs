using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pongResetScr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void onCollisionEnter2D(Collider col)
    {
        if(col.gameObject.name == "PongBall")
        {
            col.gameObject.GetComponent<PongBallScr>().resetBall();
        }
    }
}
