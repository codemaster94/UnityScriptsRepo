using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Data.Common;

public class CraftingScript : MonoBehaviour
{
    public Image butterfly;
    public Image bunny;
    public Image penguin;

    public Image elephant;
    public Image parrot;
    public Image swan;

    /*
    public Image penguin;
    public Image bunny;
    public Image butterfly;

    public Image elephant;
    public Image parrot;
    public Image swan;
    */
    public Image bronzeDiamond;
    public Image silverDiamond;
    public Image goldDiamond;

    private ShootingScript myshot;

    public GameObject squirrelshot;
    public GameObject butterflyshot;
    public GameObject bunnyflyshot;
    public GameObject penguinflyshot;
    public GameObject elephantflyshot;
    public GameObject parrotflyshot;
    public GameObject swanflyshot;
    /*
    public GameObject Bullet1;
    public GameObject Bullet2;
    public GameObject Bullet3;
    public GameObject Bullet4;
    public GameObject Bullet5;
    public GameObject Bullet6;
    public GameObject Bullet7;
    */
    public bool canCraft1;
    public bool canCraft2;
    public bool canCraft3;
    public TextMeshProUGUI hoverText1;
    public TextMeshProUGUI hoverText2;
    public TextMeshProUGUI hoverText3;
    // Start is called before the first frame update
    void Start()
    {
        canCraft1 = false;
        canCraft2 = false;
        canCraft3 = false;
        hoverText1.gameObject.SetActive(false);
        hoverText2.gameObject.SetActive(false);
        hoverText3.gameObject.SetActive(false);
        myshot = GetComponentInChildren<ShootingScript>();
        myshot.shot = squirrelshot;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canCraft1)
        {
            AllowCrafting1();
        }
        if (canCraft2)
        {
            AllowCrafting2();
        }
        if (canCraft3)
        {
            AllowCrafting3();
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (canCraft1)
        {
            AllowCrafting1();
        }
        if (canCraft2)
        {
            AllowCrafting2();
        }
        if (canCraft3)
        {
            AllowCrafting3();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("CraftStation1"))
        {
            canCraft1 = true;
            hoverText1.gameObject.SetActive(true);
        }

        if (collision.gameObject.CompareTag("CraftStation2"))
        {
            canCraft2 = true;
            hoverText2.gameObject.SetActive(true);
        }

        if (collision.gameObject.CompareTag("CraftStation3"))
        {
            canCraft3 = true;
            hoverText3.gameObject.SetActive(true);
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("CraftStation1"))
        {
            canCraft1 = false;
            hoverText1.gameObject.SetActive(false);
        }

        if (collision.gameObject.CompareTag("CraftStation2"))
        {
            canCraft2 = false;
            hoverText2.gameObject.SetActive(false);
        }

        if (collision.gameObject.CompareTag("CraftStation3"))
        {
            canCraft3 = false;
            hoverText3.gameObject.SetActive(false);
        }
    }

    void AllowCrafting1()
    {
        if (bronzeDiamond.gameObject.activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.Keypad0))
            {
                Debug.Log("Your pressed 0");
                //BulletsDeactivate();
                myshot.shot = squirrelshot;
            }
        }
    }
    void AllowCrafting2()
    {
        if (silverDiamond.gameObject.activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.Keypad1) && butterfly.gameObject.activeSelf)
            {
                Debug.Log("Your pressed 1");
                //BulletsDeactivate();
                AnimalsDeactivate();
                myshot.shot = butterflyshot;
                silverDiamond.gameObject.SetActive(false);
            }
            else if (Input.GetKeyDown(KeyCode.Keypad2) && bunny.gameObject.activeSelf)
            {
                Debug.Log("Your pressed 2");
                //BulletsDeactivate();
                AnimalsDeactivate();
                myshot.shot = bunnyflyshot;
                silverDiamond.gameObject.SetActive(false);
            }
            else if (Input.GetKeyDown(KeyCode.Keypad3) && penguin.gameObject.activeSelf)
            {
                Debug.Log("Your pressed 3");
                //BulletsDeactivate();
                AnimalsDeactivate();
                myshot.shot = penguinflyshot;
                silverDiamond.gameObject.SetActive(false);
            }
            else {
                return;
            }
        }
    }

    void AllowCrafting3()
    {
        if (goldDiamond.gameObject.activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.Keypad4) && elephant.gameObject.activeSelf)
            {
                Debug.Log("Your pressed 4");
                //BulletsDeactivate();
                AnimalsDeactivate();
                myshot.shot = elephantflyshot;
                goldDiamond.gameObject.SetActive(false);
            }
            else if (Input.GetKeyDown(KeyCode.Keypad5) && parrot.gameObject.activeSelf)
            {
                Debug.Log("Your pressed 6");
                //BulletsDeactivate();
                AnimalsDeactivate();
                myshot.shot = parrotflyshot;
                goldDiamond.gameObject.SetActive(false);
            }
            else if (Input.GetKeyDown(KeyCode.Keypad6) && swan.gameObject.activeSelf)
            {
                Debug.Log("Your pressed 7");
                //BulletsDeactivate();
                AnimalsDeactivate();
                myshot.shot = swanflyshot;
                goldDiamond.gameObject.SetActive(false);
            }
            else
            {
                return;
            }
        }
    }
    /*
    void BulletsDeactivate() 
    {
        Bullet1.gameObject.SetActive(false);
        Bullet2.gameObject.SetActive(false);
        Bullet3.gameObject.SetActive(false);
        Bullet4.gameObject.SetActive(false);
        Bullet5.gameObject.SetActive(false);
        Bullet6.gameObject.SetActive(false);
        Bullet7.gameObject.SetActive(false);
    }*/

    void AnimalsDeactivate()
    {
        penguin.gameObject.SetActive(false);
        bunny.gameObject.SetActive(false);
        butterfly.gameObject.SetActive(false);
        elephant.gameObject.SetActive(false);
        parrot.gameObject.SetActive(false);
        swan.gameObject.SetActive(false);
    }
}
