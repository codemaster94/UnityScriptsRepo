using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform place1;
    public Transform place2;
    //private Vector3 pos1 = new Vector3(-4, 0, 0);
    //private Vector3 pos2 = new Vector3(4, 0, 0);
    public float speed = 1.0f;
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(place1.position, place2.position, Mathf.PingPong(Time.time * speed, 1.0f));

    }
}
