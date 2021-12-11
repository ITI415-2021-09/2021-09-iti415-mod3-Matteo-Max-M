using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_MoveUpDown : MonoBehaviour
{

    public float speed;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rb.velocity = Vector2.right * speed;
    }
}
