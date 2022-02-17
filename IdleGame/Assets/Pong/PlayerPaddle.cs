using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            gameObject.transform.position += new Vector3(0f, 0.001f, 0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.position -= new Vector3(0f, 0.001f, 0f);
        }
    }

    void OnCollisionStay2D(Collision2D col)
    {
        if(col.gameObject.transform.parent.gameObject.name == "Walls")
        {
            if (col.gameObject.name == "Up")
                gameObject.transform.position -= new Vector3(0f, 0.002f, 0f);
            else if (col.gameObject.name == "Down")
                gameObject.transform.position += new Vector3(0f, 0.002f, 0f);
        }
    }

}
