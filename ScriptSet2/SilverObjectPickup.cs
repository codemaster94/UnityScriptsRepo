using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SilverObjectPickup : MonoBehaviour
{
    private bool canPickSilver;
    public TextMeshProUGUI silverpickuptext;
    public Image silverDiamond;

    // Start is called before the first frame update
    void Start()
    {
        canPickSilver = false;
        silverDiamond.gameObject.SetActive(false);
        silverpickuptext.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (canPickSilver && Input.GetKeyDown(KeyCode.E))
        {
            silverDiamond.gameObject.SetActive(true);
            silverpickuptext.gameObject.SetActive(false);
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            canPickSilver = true;
            silverpickuptext.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            canPickSilver = false;
            silverpickuptext.gameObject.SetActive(false);
        }
    }
}
