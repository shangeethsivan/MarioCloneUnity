using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlScript : MonoBehaviour
{
    public Rigidbody2D rb;
    // public Transform groundCheck;
    // public float groundCheckRadius;
    // public LayerMask whatIsGround;
    // private bool onGround;
    // Start is called before the first frame update

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    { 
        // rb.velocity = new Vector2(3,rb.velocity.y);
        // onGround = Physics2D.OverlapCircle(groundCheck.position,groundCheckRadius,whatIsGround);

        if(Input.GetMouseButtonDown(0) || Input.GetKey("space")) {
            rb.velocity = new Vector2(rb.velocity.x,400);
        }
        
        
            Debug.Log(System.Convert.ToString(transform.position.y));
        if (transform.position.y > 800 || transform.position.y < 10)
        {
            Death();
        }

    }

    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.tag == "Enemy"){
            Death();
        }
    }

    public void Death()
    {
        rb.velocity = Vector3.zero;
        transform.position = new Vector2(0, 0);
    }
}
