using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{

    public GameObject shot;
    public float shotSpeed = 1000f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject obj = Instantiate(shot, transform.position, Quaternion.identity);
            obj.GetComponent<Rigidbody2D>().velocity = obj.transform.position * shotSpeed;
            //obj.GetComponent<Rigidbody2D>().velocity.x = 100f;

            if (obj == null)
            {
                return;
            }
            else {
                Destroy(obj, 3f);
            }
            
        }
    }
}
