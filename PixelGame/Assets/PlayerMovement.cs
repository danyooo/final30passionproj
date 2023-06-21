using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerMovement : MonoBehaviour { 
    // declare variables
    public float speed;
    private float Move;
    public float jump;
    // add a variable to determine if the player is jumping
    public bool IsJumping;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(speed * Move, rb.velocity.y);
        // if space is pressed and jumping is false, add vertical force
        if (Input.GetButtonDown("Jump") && IsJumping == false)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        // if colliding with anything with the "ground" tag, set jumping to false
        if (other.gameObject.CompareTag("Ground"))
            {
            IsJumping = false;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        // if not touching ground, jumping is true
        if (other.gameObject.CompareTag("Ground"))
        {
            IsJumping = true;
        }
    }

}
