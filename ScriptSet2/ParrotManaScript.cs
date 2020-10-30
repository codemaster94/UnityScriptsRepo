using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ParrotManaScript : MonoBehaviour
{
    public bool wantParrot;
    public TextMeshProUGUI ParrotHoverText;
    public Image Parrot;

    private ManaDeactivation manaDeactivationParrot;

    void Start()
    {
        Parrot.gameObject.SetActive(false);
        ParrotHoverText.gameObject.SetActive(false);
        wantParrot = false;
        manaDeactivationParrot = GetComponent<ManaDeactivation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (wantParrot && Input.GetKeyDown(KeyCode.E))
        {
            ParrotHoverText.gameObject.SetActive(false);
            manaDeactivationParrot.DeactivateAllManaImages();
            Parrot.gameObject.SetActive(true);
            //Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            wantParrot = true;
            ParrotHoverText.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            wantParrot = false;
            ParrotHoverText.gameObject.SetActive(false);
        }
    }
}
