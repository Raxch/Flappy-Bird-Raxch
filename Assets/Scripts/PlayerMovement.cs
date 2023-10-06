using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float jump;
    int score = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * jump;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Point")
        {
            score++;
        }

        if(collision.gameObject.tag == "Pipe")
        {
            jump = 0;
        }

        if (collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
}
