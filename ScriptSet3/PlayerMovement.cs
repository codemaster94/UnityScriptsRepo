using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float moveSpeed = 10;
    public float jumpSpeed = 12;
    public bool isGrounded;

    public bool isFacingRight;

    public AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        audioSrc.Play();
        rb2d = GetComponent<Rigidbody2D>();
        isGrounded = false;
        isFacingRight = true;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Jump();
        float move = Input.GetAxis("Horizontal");   //this line added
        Vector3 movement = new Vector3(move, 0.0f, 0.0f); //here instead of move just leave it as input.getaxis(...)
        transform.position += movement * Time.deltaTime * moveSpeed;
        if (move > 0 && !isFacingRight)     //from here onwards new stuff
        {
            Flip();
        }
        else if (move < 0 && isFacingRight)
        {
            Flip();
        }
        else { 
            
        }
    }
    private void Flip()         //added after seeing the tutorial
    {
        isFacingRight = !isFacingRight;
        Vector3 thescale = transform.localScale;
        thescale.x *= -1;
        transform.localScale = thescale;
        
    }
    void Jump()     //this function was in the old code it is needed
    {
        if (Input.GetKeyDown(KeyCode.Space)&& isGrounded)
        {
            rb2d.AddForce(Vector2.up*jumpSpeed, ForceMode2D.Impulse);
            //rb2d.AddForce(new Vector2(0.0f, jumpSpeed), ForceMode2D.Impulse);
        }
    }    
}
