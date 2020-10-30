using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public bool startFollowing;
    [SerializeField] private string enemyShot;
    
    void Start()
    {
        startFollowing = false;
    }

    public bool IsEnemyFollowing()
    {
        return startFollowing;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Chef"))
        {
            startFollowing = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Chef"))
        {
            startFollowing = false;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Chef"))
        {
            startFollowing = true;
        }
    }
}
