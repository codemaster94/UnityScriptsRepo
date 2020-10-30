using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{

    public GameObject shootRight;
    public GameObject shootLeft;
    private bool isRight;

    public GameObject shot;
    public float shotSpeed = 125f;
    // Start is called before the first frame update
    void Start()
    {
        isRight = GetComponentInParent<squirrel>().isRight;

    }

    // Update is called once per frame
    void Update()
    {
        isRight = GetComponentInParent<squirrel>().isRight;
        if (isRight)
        {
            shootRight.gameObject.SetActive(true);
            shootLeft.gameObject.SetActive(false);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                GameObject obj = Instantiate(shot, shootRight.transform.position, Quaternion.identity);
                obj.GetComponent<Rigidbody2D>().velocity = obj.transform.right * shotSpeed;
                
            }

        }
        else 
        {
            shootRight.gameObject.SetActive(false);
            shootLeft.gameObject.SetActive(true);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                GameObject obj = Instantiate(shot, shootLeft.transform.position, Quaternion.identity);
                obj.GetComponent<Rigidbody2D>().velocity = obj.transform.right * -shotSpeed;

            }
        }
    }
}
