using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class squirrel : MonoBehaviour
{

    float moveX;
    public float moveSpeed = 5f;
    public bool isRight;
    private SpriteRenderer spr;
    private Rigidbody2D rb2d;

    Vector3 movement;

    // Start is called before the first frame update
    void Start()
    {
        spr = GetComponent<SpriteRenderer>();
        isRight = false;
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal");

        if (moveX < 0 && isRight)
        {
            isRight = false;
            spr.flipX=true;
            
        }

        if (moveX > 0 && !isRight)
        {
            isRight = true;
            spr.flipX = false;
            
        }
        movement = new Vector3(moveX, 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;

    }

}
