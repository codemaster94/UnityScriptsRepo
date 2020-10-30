using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggershot : MonoBehaviour
{
    public GameObject myshot;
    public Vector2 toPlayer;
    public GameObject Player;
    public float travellingSpeed=10f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            GameObject temp= Instantiate(myshot, transform.position, Quaternion.identity);
            toPlayer = transform.position - Player.transform.position;
            temp.GetComponent<Rigidbody2D>().AddForce(toPlayer.normalized*travellingSpeed*Time.deltaTime);
        }
    }
}
