using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TotalEnemies : MonoBehaviour
{
    public static int totalEnemies;
    public int myret;
    public int enemies;

    private void Start()
    {
        totalEnemies = enemies;

    }
    public static void ReduceEnemies()
    {
        totalEnemies -= 1;
    }
    public int AliveEnemies()
    {
        return totalEnemies;
    }

    

    public void Reduce()
    {
        ReduceEnemies();
    }
  
}
