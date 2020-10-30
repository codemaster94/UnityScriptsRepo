using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    public GameObject shot;
    public GameObject shotPoint;
    public float shotSpeed=100f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.activeInHierarchy)
        {
            if (Input.GetButtonDown("Space"))
            {
                GameObject newshot =  Instantiate(shot, shotPoint.transform.position, Quaternion.identity);
                newshot.GetComponent<Rigidbody2D>().AddForce(Vector2.right*shotSpeed*Time.deltaTime);
                Destroy(newshot, 1f);
                
            }
        }
    }
}
