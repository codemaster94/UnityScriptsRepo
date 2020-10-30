using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class nextscript : MonoBehaviour
{
    public Image backtocontrols;
    public Image additionalhints;
    // Start is called before the first frame update
    void Start()
    {
        backtocontrols.gameObject.SetActive(false);
        additionalhints.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            additionalhints.gameObject.SetActive(true);
            this.gameObject.SetActive(false);
            //SceneManager.LoadScene("Level1");
            

        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            backtocontrols.gameObject.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }
}
