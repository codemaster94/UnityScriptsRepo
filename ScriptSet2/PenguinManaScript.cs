using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PenguinManaScript : MonoBehaviour
{
    public bool wantPenguin;
    public TextMeshProUGUI PenguinHoverText;
    public Image Penguin;
    private ManaDeactivation manaDeactivationPenguin;

    void Start()
    {
        Penguin.gameObject.SetActive(false);
        PenguinHoverText.gameObject.SetActive(false);
        wantPenguin = false;
        manaDeactivationPenguin = GetComponent<ManaDeactivation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (wantPenguin && Input.GetKeyDown(KeyCode.E))
        {
            PenguinHoverText.gameObject.SetActive(false);
            manaDeactivationPenguin.DeactivateAllManaImages();
            Penguin.gameObject.SetActive(true);
            //Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            wantPenguin = true;
            PenguinHoverText.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            wantPenguin = false;
            PenguinHoverText.gameObject.SetActive(false);
        }
    }
}
