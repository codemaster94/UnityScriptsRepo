using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BunnyManaScript : MonoBehaviour
{
    public bool wantBunny;
    public TextMeshProUGUI BunnyHoverText;
    public Image Bunny;

    private ManaDeactivation manaDeactivationBunny;
    void Start()
    {
        Bunny.gameObject.SetActive(false);
        BunnyHoverText.gameObject.SetActive(false);
        wantBunny = false;
        manaDeactivationBunny = GetComponent<ManaDeactivation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (wantBunny && Input.GetKeyDown(KeyCode.E))
        {
            BunnyHoverText.gameObject.SetActive(false);
            manaDeactivationBunny.DeactivateAllManaImages();
            Bunny.gameObject.SetActive(true);
            //Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            wantBunny = true;
            BunnyHoverText.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            wantBunny = false;
            BunnyHoverText.gameObject.SetActive(false);
        }
    }
}
