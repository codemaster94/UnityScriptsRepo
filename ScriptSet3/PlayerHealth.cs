using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int playerMaxHealth;
    private int playerCurrentHealth;
    // Start is called before the first frame update
    void Start()
    {
        playerCurrentHealth = playerMaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if(playerCurrentHealth<=0)
        {
            SceneManager.LoadScene("LoseScreen");
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Boundary"))
        {
            SceneManager.LoadScene("LoseScreen");
        }
    }
}
