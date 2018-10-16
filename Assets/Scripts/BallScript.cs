using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{

    public Rigidbody2D rb;
    public float ballForce;
    private bool gameStarted = false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && !gameStarted)
        {
            gameStarted = true;
            transform.SetParent(null);
            rb.isKinematic = false;
            rb.AddForce(new Vector2(ballForce, ballForce));
        }
    }
}
