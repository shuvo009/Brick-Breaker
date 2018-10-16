using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScripts : MonoBehaviour
{

    public Rigidbody2D rb;
    public int Spreed;
    public float maxX;
    void Start()
    {

    }

    // Update is called once per frame22434
    void Update()
    {
        var x = Input.GetAxis("Horizontal");
        if (x < 0)
        {
            MoveLeft();
        }

        if (x > 0)
        {
            MoveRight();
        }

        if (x == 0)
        {
            Stop();
        }
        Console.WriteLine("XX:" + x);
        var pos = transform.position;

        pos.x =  Mathf.Clamp(pos.x, -maxX, maxX);
        transform.position = pos;
    }

    void MoveLeft()
    {
        rb.velocity = new Vector2(-Spreed, 0);
    }

    void MoveRight()
    {
        rb.velocity = new Vector2(Spreed, 0);
    }

    void Stop()
    {
        rb.velocity =Vector2.zero;
    }
}
