using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerPartControllerScr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < gameObject.transform.childCount; ++i)
        {
            gameObject.transform.GetChild(i).GetComponent<Rigidbody2D>().velocity = new Vector2(-3, 0);
        }
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(-3, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
