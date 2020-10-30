using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public GameObject shot;
    public float shotSpeed = 6000f;
    public PlayerMovement playerMovement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject newshot;
            if (playerMovement.isFacingRight)
            {
                newshot = Instantiate(shot, transform.position, Quaternion.Euler(0, 0, -90));
                newshot.GetComponent<Rigidbody2D>().velocity = Vector2.right * shotSpeed;
            }
            else {
                newshot = Instantiate(shot, transform.position, Quaternion.Euler(0, 0, 90));
                newshot.GetComponent<Rigidbody2D>().velocity = Vector2.left * shotSpeed;
            }
            
            //newshot.GetComponent<Rigidbody2D>().AddForce(Vector2.right * shotSpeed * Time.deltaTime);
            Destroy(newshot, 1f);
        }
    }
}
