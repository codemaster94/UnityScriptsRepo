using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public HealthBar chefHealthBar;
    private int playerCurrentHealth;
    [SerializeField] private int playerMaxHealth=100;


    private CharacterController2D controller;
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;

    void Start()
    {
        playerCurrentHealth = playerMaxHealth;
        chefHealthBar.SetMaxHealth(playerMaxHealth);
        controller = GetComponent<CharacterController2D>();
    }

    
    void Update()
    {
        horizontalMove=Input.GetAxisRaw("Horizontal")*runSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;            
        }
        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
    }

    void FixedUpdate()
    {
        if (playerCurrentHealth <= 0)
        {
            Debug.Log("Chef died");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

            //Show the game over screen
        }
        controller.Move(horizontalMove*Time.fixedDeltaTime,crouch,jump);
        jump = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("FireShot"))
        {
            playerCurrentHealth -= 10;
            chefHealthBar.SetHealth(playerCurrentHealth);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            playerCurrentHealth -= 20;
            chefHealthBar.SetHealth(playerCurrentHealth);
        }
    }

}
