using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HintScript : MonoBehaviour
{
    public bool wantHint;
    public TextMeshProUGUI hintText;
    public Image tutorialimage;
    
    // Start is called before the first frame update
    void Start()
    {
        wantHint = false;
        hintText.gameObject.SetActive(false);
        tutorialimage.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (wantHint && Input.GetKeyDown(KeyCode.E))
        {
            tutorialimage.gameObject.SetActive(true);
        }
        /*
        if (wantHint && Input.GetKeyDown(KeyCode.Escape))
        {
            tutorialimage.gameObject.SetActive(false);
        }*/
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            wantHint = true;
            hintText.gameObject.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            wantHint = false;
            hintText.gameObject.SetActive(false);
            tutorialimage.gameObject.SetActive(false);
        }
    }
}
