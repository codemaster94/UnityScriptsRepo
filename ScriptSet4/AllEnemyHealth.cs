using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AllEnemyHealth : MonoBehaviour
{
    [SerializeField] private HealthBar enemy;
    [SerializeField] private int maxHealth;
    public int noOfEnemies;
    private int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = noOfEnemies * 40;
        enemy.SetMaxHealth(maxHealth);
        currentHealth = maxHealth;
    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            if (currentHealth >= maxHealth)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else if (currentHealth <= 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
        else if (currentHealth <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        { 
            //do nothing
        }
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        enemy.SetHealth(currentHealth);
    }
}
