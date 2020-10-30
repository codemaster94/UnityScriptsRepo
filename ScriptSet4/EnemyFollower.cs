using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollower : MonoBehaviour
{
    public Transform spawnPoint;
    [SerializeField] private float enemySpeed=3.0f;
    public Transform chef;
    [SerializeField] private EnemyAttack enemyAttackScript;
    private float fireRate;
    private float nextFire;
    //private float shotSpeed = 1f;
    public Transform fireBallSpawnPoint;
    [SerializeField] private GameObject fireBall;
    private void Start()
    {
        fireRate = 2f;
        nextFire = Time.time;
    }

    void Update()
    {
        
        if (enemyAttackScript.IsEnemyFollowing())
        {
            transform.position = Vector2.MoveTowards(transform.position, chef.position, enemySpeed * Time.deltaTime);
            if (Time.time>nextFire)
            {
                Instantiate(fireBall, fireBallSpawnPoint.position, Quaternion.identity);
                /*
                 * Vector3 shootDirection = (chef.position- fireBallInstance.transform.position).normalized * shotSpeed;
                Destroy(fireBallInstance, 2);
                */
                nextFire = Time.time + fireRate;
            }
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, spawnPoint.position, enemySpeed * Time.deltaTime);
        }
    }
}
