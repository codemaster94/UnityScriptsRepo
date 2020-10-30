using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public string enemyShot;
    [SerializeField] private int maxHealth = 40;
    [SerializeField] private int currentHealth;
    public AllEnemyHealth allEnemyHealthScript;
    private void Start()
    {
        currentHealth = maxHealth;
    }
    void Update()
    {
        if(currentHealth<=0)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(enemyShot))
        {
            allEnemyHealthScript.TakeDamage(20);
            currentHealth -= 20;
            Debug.Log(currentHealth);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("MuffinShot"))
        {
            allEnemyHealthScript.TakeDamage(-20);
            if (currentHealth != maxHealth)
            {
                currentHealth += 20;
                Debug.Log(currentHealth);
            }
            Debug.Log(currentHealth);
            Destroy(collision.gameObject);
        }
        
    }
   
}
