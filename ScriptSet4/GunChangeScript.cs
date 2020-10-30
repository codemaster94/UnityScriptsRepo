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
    public GameObject MuffinGun;
    public GameObject Slot1;
    public GameObject Slot2;
    public GameObject Slot3;
    public GameObject Slot4;
    public GameObject Slot5;
    public GameObject Slot6;


    void Start()
    {
        HideGuns();
        HideAllSlots();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)&&Slot1.activeInHierarchy)
        {
            HideGuns();
            RedGun.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2)&&Slot2.activeInHierarchy)
        {
            HideGuns();
            BlueGun.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3)&&Slot3.activeInHierarchy)
        {
            HideGuns();
            GreenGun.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4)&&Slot4.activeInHierarchy)
        {
            HideGuns();
            YellowGun.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5)&&Slot5.activeInHierarchy)
        {
            HideGuns();
            SpecialGun.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha6)&&Slot6.activeInHierarchy)
        {
            HideGuns();
            MuffinGun.SetActive(true);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("RedGunPickup"))
        {
            HideGuns();
            RedGun.SetActive(true);
            Slot1.SetActive(true);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("BlueGunPickup"))
        {
            HideGuns();
            BlueGun.SetActive(true);
            Slot2.SetActive(true);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("GreenGunPickup"))
        {
            HideGuns();
            GreenGun.SetActive(true);
            Slot3.SetActive(true);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("YellowGunPickup"))
        {
            HideGuns();
            YellowGun.SetActive(true);
            Slot4.SetActive(true);
            Destroy(collision.gameObject);
        }
       
        if (collision.gameObject.CompareTag("SpecialGunPickup"))
        {
            HideGuns();
            SpecialGun.SetActive(true);
            Slot5.SetActive(true);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("MuffinGunPickup"))
        {
            HideGuns();
            MuffinGun.SetActive(true);
            Slot6.SetActive(true);
            Destroy(collision.gameObject);
        }
    }
   
    void HideGuns()
    {
        RedGun.SetActive(false);
        BlueGun.SetActive(false);
        YellowGun.SetActive(false);
        GreenGun.SetActive(false);
        SpecialGun.SetActive(false);
        MuffinGun.SetActive(false);
    }

    void HideAllSlots()
    {
        Slot1.SetActive(false);
        Slot2.SetActive(false);
        Slot3.SetActive(false);
        Slot4.SetActive(false);
        Slot5.SetActive(false);
        Slot6.SetActive(false);
    }
}
