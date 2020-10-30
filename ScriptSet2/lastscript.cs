using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class lastscript : MonoBehaviour
{
    public Image back;
    // Start is called before the first frame update
    void Start()
    {
        back.gameObject.SetActive(false);  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("TutorialLevel");
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            back.gameObject.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }
}
