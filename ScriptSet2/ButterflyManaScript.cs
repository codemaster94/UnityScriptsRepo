using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButterflyManaScript : MonoBehaviour
{
    public bool wantButterfly;
    public TextMeshProUGUI ButterflyHoverText;
    public Image Butterfly;
    private ManaDeactivation manaDeactivationButterfly;
    
    void Start()
    {
        Butterfly.gameObject.SetActive(false);
        ButterflyHoverText.gameObject.SetActive(false);
        wantButterfly = false;
        manaDeactivationButterfly = GetComponent<ManaDeactivation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (wantButterfly && Input.GetKeyDown(KeyCode.E))
        {
            ButterflyHoverText.gameObject.SetActive(false);
            manaDeactivationButterfly.DeactivateAllManaImages();
            Butterfly.gameObject.SetActive(true);
            //Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            wantButterfly = true;
            ButterflyHoverText.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            wantButterfly = false;
            ButterflyHoverText.gameObject.SetActive(false);
        }
    }
}
