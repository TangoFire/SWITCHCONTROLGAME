using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float runSpeed = 5f;
    public float jumpHeight = 5f;

    private bool isGrounded;

    public Rigidbody2D rb;
    
    void Start()
    {
     rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"),0);
        Vector2 moveAmount = (input.normalized * runSpeed) * Time.deltaTime;

        transform.Translate(moveAmount);


        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity += (Vector2.up * jumpHeight);
        }
        
        
        
    }
}

    


