using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D playerRb;
    private float speed = 10.0f;
    private float jumpForce = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MoveAround();
        Jump();
    }

    void MoveAround()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        playerRb.AddForce(Vector2.right * horizontalInput * speed);
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            playerRb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
