using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakScript : MonoBehaviour
{
    private UiManager uiManager;
    void Start()
    {
        uiManager = GameObject.FindWithTag("UI").GetComponent<UiManager>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        
        if (col.gameObject.tag == "Ball")
        {
            uiManager.UpdateScore();
            Destroy(gameObject);
        }
    }
}
