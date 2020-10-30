using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBarScript healthbar;

    private Animator anim;
    private AudioSource audioSource;
    private TotalEnemies tot;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        tot = GetComponent<TotalEnemies>();
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0)
        {
            anim.SetBool("isDestroyed", true);
            StartCoroutine(EnemyDestroyed());
            healthbar.gameObject.SetActive(false);
            tot.Reduce();
            if (tot.AliveEnemies() == 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            }
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            Destroy(this.gameObject);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthbar.SetHealth(currentHealth);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Shot"))
        {
            audioSource.Play();
            TakeDamage(10);
        }
        if (collision.gameObject.CompareTag("Shot1"))
        {
            audioSource.Play();
            TakeDamage(15);
        }
        if (collision.gameObject.CompareTag("Shot2"))
        {
            audioSource.Play();
            TakeDamage(20);
        }
        if (collision.gameObject.CompareTag("Shot3"))
        {
            audioSource.Play();
            TakeDamage(25);
        }
        if (collision.gameObject.CompareTag("Shot4"))
        {
            audioSource.Play();
            TakeDamage(30);
        }
        if (collision.gameObject.CompareTag("Shot5"))
        {
            audioSource.Play();
            TakeDamage(50);
        }
        if (collision.gameObject.CompareTag("Shot6"))
        {
            audioSource.Play();
            TakeDamage(70);
        }


    }

    IEnumerator EnemyDestroyed()
    {
        yield return new WaitForSeconds(2);
    }
}
