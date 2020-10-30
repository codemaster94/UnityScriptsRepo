using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SwanManaScript : MonoBehaviour
{
    public bool wantSwan;
    public TextMeshProUGUI SwanHoverText;
    public Image Swan;
    private ManaDeactivation manaDeactivationSwan;

    void Start()
    {
        Swan.gameObject.SetActive(false);
        SwanHoverText.gameObject.SetActive(false);
        wantSwan = false;
        manaDeactivationSwan = GetComponent<ManaDeactivation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (wantSwan && Input.GetKeyDown(KeyCode.E))
        {
            SwanHoverText.gameObject.SetActive(false);
            manaDeactivationSwan.DeactivateAllManaImages();
            Swan.gameObject.SetActive(true);
            //Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            wantSwan = true;
            SwanHoverText.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            wantSwan = false;
            SwanHoverText.gameObject.SetActive(false);
        }
    }
}
