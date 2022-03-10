using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class runnerResetScr : MonoBehaviour
{
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name.Contains("Player"))
        {
            GM.scoreRunner();
            GM.resetRunner();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Player"))
        {
            GM.scoreRunner();
            GM.resetRunner();
        }
    }
}
