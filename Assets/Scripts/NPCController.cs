using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;
    public bool isLeft = true;

    private void Start()
    {
        movement = new Vector2();
    }

    private void Update()
    {
        movement.y = 0;
        if(isLeft)
        {
            movement.x = -1;
        }
        else
        {
            movement.x = 1;
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
