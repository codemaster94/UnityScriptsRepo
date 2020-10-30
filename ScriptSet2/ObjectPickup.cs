using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class ObjectPickup : MonoBehaviour
{
    public bool canPick;
    public TextMeshProUGUI hoverText;
    //public bool isDiamond;
    public Image img;

    //public Text hoverText;
    // Start is called before the first frame update
    void Start()
    {
        //isDiamond = false;
        img.gameObject.SetActive(false);
        hoverText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (canPick && Input.GetKeyDown(KeyCode.E))
        {
            hoverText.gameObject.SetActive(false);
            //isDiamond = true;
            img.gameObject.SetActive(true);
            Destroy(this.gameObject);
        }
    }
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            canPick = true;
            hoverText.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            canPick = true;
            hoverText.gameObject.SetActive(false);
        }
    }


}
