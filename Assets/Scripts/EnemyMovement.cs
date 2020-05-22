﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(-200,rb.velocity.y);
    }


    void OnCollisionEnter2D(Collision2D col){

        if(col.gameObject.name == "mario"){
            Debug.Log("Collided with mario");
        }
    }
}
