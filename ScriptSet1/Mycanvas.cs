using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Mycanvas : MonoBehaviour
{
    public GameObject myCanvas;
    public Image img;
    public TextMeshProUGUI[] myStops;
    private int myseatno;

    private MySeat mySeat;

    public bool accepted;
    public bool denied;

    public TicketAssign ticketAssign;
    
    // Start is called before the first frame update
    void Start()
    {
        mySeat = GetComponent<MySeat>();
        myCanvas.SetActive(false);
        img.enabled = false;
        for (int i = 0; i < myStops.Length; i++)
        {
            myStops[i].enabled = false;
        }
        myseatno = Random.Range(0, 5);
        accepted = false;
        denied = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && mySeat.isAtBooth)
        {
            myCanvas.SetActive(true);
            img.enabled = true;
            myStops[myseatno].enabled = true;
        }

        /*if (Input.GetKeyDown(KeyCode.E))
        { 
            //ShowTicket to the Ticket Checker
        }*/
    }

    public void OnAcceptButtonClick()
    {
        accepted = true;
        denied = false;
        myCanvas.SetActive(false);
        ticketAssign.setSeat(this.gameObject);
        mySeat.myNavMeshAgent.enabled = true;
        ticketAssign.isReady = true;
    }
    public void OnDenyButtonClick()
    {
        denied = true;
        accepted = false;
        myCanvas.SetActive(false);
        ticketAssign.donotsetSeat(this.gameObject);
        mySeat.myNavMeshAgent.enabled = true;
        ticketAssign.isReady = true;
    }
}
