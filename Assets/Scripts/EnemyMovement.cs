using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Rigidbody2D enemyRb;
    private float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MoveToPlayer();
    }

    void MoveToPlayer()
    {
        enemyRb.AddForce(Vector2.left * speed);
    }
}
