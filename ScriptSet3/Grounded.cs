using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour
{
    GameObject Player;
    private bool tempIsGrounded;
    [SerializeField] private LayerMask platformLayerMask;
    // Start is called before the first frame update
    void Start()
    {
        Player = gameObject.transform.parent.gameObject;   
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        tempIsGrounded = collision != null && (((1 << collision.gameObject.layer) & platformLayerMask) != 0);
        Player.GetComponent<PlayerMovement>().isGrounded = tempIsGrounded;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        tempIsGrounded = false;
        Player.GetComponent<PlayerMovement>().isGrounded = tempIsGrounded;
    }
}


/*
 *
 *original code
GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = gameObject.transform.parent.gameObject;   
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Player.GetComponent<PlayerMovement>().isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Player.GetComponent<PlayerMovement>().isGrounded = false;
        }
    } 


 */
