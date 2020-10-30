using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    public CharacterController2D mycontroller;
    public GameObject shot;
    public GameObject shotPoint;
    [SerializeField] private float shotSpeed=12.5f;
    private AudioSource shootSound;

    private void Start()
    {
        shootSound = GetComponent<AudioSource>();
    }


    void Update()
    {
        if (this.gameObject.activeInHierarchy)
        {
            if (Input.GetMouseButtonDown(0))
            {
                GameObject newshot =  Instantiate(shot, shotPoint.transform.position, Quaternion.identity);
                shootSound.Play();
                if (mycontroller.GetFacingDirection())
                {
                    newshot.GetComponent<Rigidbody2D>().velocity = Vector2.right * shotSpeed;
                }
                else {
                    newshot.GetComponent<Rigidbody2D>().velocity = Vector2.left * shotSpeed;
                }
                Destroy(newshot, 0.125f);
                
            }
        }
    }
}
