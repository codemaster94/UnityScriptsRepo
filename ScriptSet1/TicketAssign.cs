using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicketAssign : MonoBehaviour
{
    public GameObject[] mypassengers;
    public bool[] isMyPassengerPresent;

    public GameObject[] myseats;
    public bool[] isMySeatPresent;

    private int myTotalPassengers;
    public int myLevel;
    private int seatCount=0;
    private int myPassengerIndex;
    private int mySeatIndex;

    public bool isReady;

    //public GameObject myMenu;
    public GameObject mySpawnPoint;
    public GameObject myTicketBooth;
    public GameObject exitPoint;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < isMyPassengerPresent.Length; i++)
        {
            isMyPassengerPresent[i] = false;
        }
        for (int i = 0; i < isMySeatPresent.Length; i++)
        {
            isMySeatPresent[i] = false;
        }

        if (myLevel == 1)
        {
            myTotalPassengers = Random.Range(2, 4);
        }
        else if (myLevel == 2)
        {
            myTotalPassengers = Random.Range(4, 6);
        }
        else if (myLevel == 3)
        {
            myTotalPassengers = Random.Range(6, 12);
        }
        else 
        {
            myTotalPassengers = Random.Range(3, 7);
        }



        PassengerAssign();

        //myMenu.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (seatCount >= myTotalPassengers)
        {
            //StopAssigningSeats and begin level
            this.enabled = false;
            
        }
        if (Input.GetKeyDown(KeyCode.Return) && isReady)
        {
            PassengerAssign();
        }
        
    }

    public void PassengerAssign()
    {
        myPassengerIndex = Random.Range(0, 7);       
        GameObject myobj = Instantiate(mypassengers[myPassengerIndex], mySpawnPoint.transform.position, Quaternion.identity);
        MySeat mySeat = myobj.GetComponent<MySeat>();
        mySeat.seatToSit = myTicketBooth;
    }

    private int GetAvailableSeat()
    {
        mySeatIndex = Random.Range(0, 11);
        if (!isMySeatPresent[mySeatIndex])
        {
            return mySeatIndex;
        }
        else
            return GetAvailableSeat();

    }

    public void setSeat(GameObject obj)
    {
        obj.GetComponent<MySeat>().seatToSit = myseats[GetAvailableSeat()];
    }

    public void donotsetSeat(GameObject obj)
    {
        obj.GetComponent<MySeat>().seatToSit = exitPoint;
    }

    /*void StartAssigningSeats()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Assigning Passenger");
            myPassengerIndex = Random.Range(0, 7);
            mySeatIndex = Random.Range(0, 11);
            if (!isMySeatPresent[mySeatIndex])
            {
                Debug.Log("Passenger no " + myPassengerIndex + " instantiated at seat no " + mySeatIndex);
                GameObject obj = Instantiate(mypassengers[myPassengerIndex], mySpawnPoint.transform.position, Quaternion.identity);
                obj.GetComponent<ReachSeat>().Seat = myseats[mySeatIndex];
                seatCount++;
            }
        }
    }*/


}
