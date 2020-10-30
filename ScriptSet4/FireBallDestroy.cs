using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallDestroy : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private Transform chef;
    private float shotSpeed=7f;
    private Vector2 shootDirection;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        chef = GameObject.FindGameObjectWithTag("Chef").transform;
        shootDirection = (chef.transform.position - transform.position).normalized*shotSpeed;
        float angle = Mathf.Atan2(Mathf.Abs(chef.position.y), Mathf.Abs(chef.position.x))*Mathf.Rad2Deg;
        //Debug.Log(angle);
        if (shootDirection.x < 0)
        {
            transform.Rotate(0, 0, angle-90);
        }
        else
        {
            transform.Rotate(0, 0, 90 - angle);
        }
        
        /*
        Vector2 diffDirection = (chef.transform.position - transform.position);
        Vector2 fireballDirection = Vector2.right - diffDirection;
        

        float angle = Mathf.Atan2(relative.x, relative.z) * Mathf.Rad2Deg;
        transform.Rotate(0, angle, 0);
        
         */
        rb2d.velocity = new Vector2(shootDirection.x, shootDirection.y);
        Destroy(gameObject, 3f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Chef"))
        {
            Destroy(gameObject);
        }
    }
}
