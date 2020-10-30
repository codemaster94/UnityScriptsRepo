using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeTextScript : MonoBehaviour
{
    public TextMeshProUGUI changeText;
    public string textToShow="";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Chef"))
        {
            changeText.text = textToShow;
        }
    }
}
