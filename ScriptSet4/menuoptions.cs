using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuoptions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ReplayTutorial()
    {
        SceneManager.LoadScene("Tutorial1");
    }
    public void ReplayGame()
    {
        SceneManager.LoadScene("Level1");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void StartGamer()
    {
        SceneManager.LoadScene("Tutorial1");
    }

}
