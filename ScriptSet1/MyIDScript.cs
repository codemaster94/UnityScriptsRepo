using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyIDScript : MonoBehaviour
{
    public GameObject myPicture;
    public GameObject[] busStops;
    public GameObject myIDPopUp;

    private int index;
    // Start is called before the first frame update
    void Start()
    {
        myPicture.SetActive(false);
        
        for (int i = 0; i < busStops.Length; i++)
        {
            busStops[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.E))
        {
            myIDPopUp.SetActive(true);
            index = Random.Range(1, 6);
            busStops[index].SetActive(true);
        }*/
    }

    private void myIDDeactivate()
    {
        
        
        for (int i = 0; i < busStops.Length; i++)
        {
            busStops[i].SetActive(false);
        }
    }
}
