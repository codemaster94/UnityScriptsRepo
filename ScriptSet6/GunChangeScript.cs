using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunChangeScript : MonoBehaviour
{

    public GameObject RedGun;
    public GameObject BlueGun;
    public GameObject GreenGun;
    public GameObject YellowGun;
    public GameObject SpecialGun;
    // Start is called before the first frame update
    void Start()
    {
        HideGuns();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("RedGunPickup"))
        {
            HideGuns();
            RedGun.SetActive(true);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("BlueGunPickup"))
        {
            HideGuns();
            BlueGun.SetActive(true);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("YellowGunPickup"))
        {
            HideGuns();
            YellowGun.SetActive(true);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("GreenGunPickup"))
        {
            HideGuns();
            GreenGun.SetActive(true);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("SpecialGunPickup"))
        {
            HideGuns();
            SpecialGun.SetActive(true);
            Destroy(collision.gameObject);
        }
    }
    /*
    private void OnCollisionEnter2D(Collision2D collision)
    {
             


        if (collision.gameObject.CompareTag("RedGunPickup"))
        {
            HideGuns();
            RedGun.SetActive(true);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("BlueGunPickup"))
        {
            HideGuns();
            BlueGun.SetActive(true);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("YellowGunPickup"))
        {
            HideGuns();
            YellowGun.SetActive(true);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("GreenGunPickup"))
        {
            HideGuns();
            GreenGun.SetActive(true);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("SpecialGunPickup"))
        {
            HideGuns();
            SpecialGun.SetActive(true);
            Destroy(collision.gameObject);
        }

    }*/

    void HideGuns()
    {
        RedGun.SetActive(false);
        BlueGun.SetActive(false);
        YellowGun.SetActive(false);
        GreenGun.SetActive(false);
        SpecialGun.SetActive(false);
    }

}
