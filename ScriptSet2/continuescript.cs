using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class continuescript : MonoBehaviour
{

    public Image craftimg;
    // Start is called before the first frame update
    void Start()
    {
        craftimg.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            craftimg.gameObject.SetActive(true);
            this.gameObject.SetActive(false);
            
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("FirstPage");
        }
    }
}
