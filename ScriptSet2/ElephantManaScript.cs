using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ElephantManaScript : MonoBehaviour
{
    public bool wantElephant;
    public TextMeshProUGUI ElephantHoverText;
    public Image Elephant;

    private ManaDeactivation manaDeactivationElephant;
    void Start()
    {
        Elephant.gameObject.SetActive(false);
        ElephantHoverText.gameObject.SetActive(false);
        wantElephant = false;
        manaDeactivationElephant = GetComponent<ManaDeactivation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (wantElephant && Input.GetKeyDown(KeyCode.E))
        {
            ElephantHoverText.gameObject.SetActive(false);
            manaDeactivationElephant.DeactivateAllManaImages();
            Elephant.gameObject.SetActive(true);
            //Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            wantElephant = true;
            ElephantHoverText.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            wantElephant = false;
            ElephantHoverText.gameObject.SetActive(false);
        }
    }
}
