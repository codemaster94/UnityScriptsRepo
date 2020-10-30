using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using TMPro;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class ReachSeat : MonoBehaviour
{

    //public GameObject Seat;
    //private NavMeshAgent navmeshAgent;
    //private Animator anim;

    private bool isAtBooth;
    public GameObject thisCanvas;

    public Image myImage;
    public TextMeshProUGUI[] allbusstops;
    private int busstopIndex;

    public bool accepted;
    public bool denied;
    public bool isReached;
    // Start is called before the first frame update
    void Start()
    {
        //navmeshAgent = GetComponent<NavMeshAgent>();
        //anim = GetComponent<Animator>();
        isAtBooth = false;
        accepted = false;
        denied = false;
    }

    // Update is called once per frame
    void Update()
    {   /*
        if (navmeshAgent.enabled == true)
        {
            //Debug.Log("Enabled Nav Mesh");
            gameObject.GetComponent<NavMeshAgent>().SetDestination(Seat.transform.position);
        }*/

        if (Input.GetKeyDown(KeyCode.E) && isAtBooth)
        {
            //Do Something
            thisCanvas.SetActive(true);
            myImage.enabled=true;
            busstopIndex = Random.Range(0, 5);
            allbusstops[busstopIndex].enabled=true;

            if (accepted && !denied)
            { 
                
            }
        }
       
    }
    

    /* void OnTriggerEnter(Collider other)
     {
         if (other.gameObject.tag == "Place")
         {
             navmeshAgent.enabled = false;
             Debug.Log("Place Reached trigger detected");
             anim.SetBool("isSitting", true);
         }
     }*/

    public void AcceptButtonClick()
    {
        accepted = true;
        denied = false;
        thisCanvas.SetActive(false);
    }

    public void DenyButtonClick()
    {
        denied = true;
        accepted = false;
        thisCanvas.SetActive(false);
    }

    private void myUIdisable()
    {
        myImage.enabled=false;
        allbusstops[busstopIndex].enabled=false;
    }
}
