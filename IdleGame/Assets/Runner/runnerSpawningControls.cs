using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class runnerSpawningControls : MonoBehaviour
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
        if(collision.gameObject.name.Contains("Runner"))
        {
            switch(this.gameObject.tag)
            {
                case "DeletePart":
                    {

                        GM.spawnedParts.Remove(collision.gameObject);
                        Destroy(collision.gameObject);
                        break;
                    }
                case "SpawnNew":
                    {
                        GM.spawnNewRunnerSegment();
                        collision.gameObject.tag = "AlreadySpawned";
                        break;
                    }
            }
        }
    }
}
