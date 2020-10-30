using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GoldObjectPickup : MonoBehaviour
{
    private bool canPickGold;
    public TextMeshProUGUI goldpickuptext;
    public Image goldDiamond;

    // Start is called before the first frame update
    void Start()
    {
        canPickGold = false;
        goldDiamond.gameObject.SetActive(false);
        goldpickuptext.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (canPickGold && Input.GetKeyDown(KeyCode.E))
        {
            goldDiamond.gameObject.SetActive(true);
            goldpickuptext.gameObject.SetActive(false);
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            canPickGold = true;
            goldpickuptext.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            canPickGold = false;
            goldpickuptext.gameObject.SetActive(false);
        }
    }
}
