using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGroundScript : MonoBehaviour
{
    private bool isGrounded;
    private Rigidbody2D rb2d;
    public float jumpSpeed=100f;
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponentInParent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.W)|| Input.GetKeyDown(KeyCode.UpArrow)) && isGrounded)
        {
            //rb2d.AddForce(Vector2.up);
            rb2d.velocity = Vector2.up * jumpSpeed;
            isGrounded = false;
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            
        }
        else
        {
            isGrounded = false;
        }
        Debug.Log(isGrounded);
    }

}
