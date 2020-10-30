using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ObjectScript : MonoBehaviour
{

    
    public Text hovertext;
    public bool canPickup;

    // Start is called before the first frame update
    void Start()
    {
        hovertext.gameObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canPickup && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Pickup() called");
            Pickup(); 
        }
    }

    void Pickup()
    {
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("enterred trigger collider");
            canPickup = true;
            hovertext.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("exited trigger collider");
            canPickup = false;
            hovertext.gameObject.SetActive(false);
        }
    }
}
