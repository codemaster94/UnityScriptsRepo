using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BronzeObjectPickup : MonoBehaviour
{
    private bool canPickBronze;
    public TextMeshProUGUI bronzepickuptext;
    public Image bronzeDiamond;

    // Start is called before the first frame update
    void Start()
    {
        canPickBronze = false;
        bronzeDiamond.gameObject.SetActive(false);
        bronzepickuptext.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (canPickBronze && Input.GetKeyDown(KeyCode.E))
        {
            bronzeDiamond.gameObject.SetActive(true);
            bronzepickuptext.gameObject.SetActive(false);
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            canPickBronze = true;
            bronzepickuptext.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            canPickBronze = false;
            bronzepickuptext.gameObject.SetActive(false);
        }
    }
}
