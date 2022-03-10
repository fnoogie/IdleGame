using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerPlayerScr : MonoBehaviour
{
    public Vector3 startPos;
    Rigidbody2D rb;
    public float jumpForce = 1.5f;
    public bool canJump = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        startPos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W) && canJump)
        {
            rb.velocity = new Vector2(0, jumpForce);
            canJump = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        canJump = true;
    }
}
