using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AcceptOrDeny
{
    public ReachSeat reachSeat;
    
    
    public void AcceptButtonClicked()
    {
        reachSeat.accepted = true;
        reachSeat.denied = false;
    }
    public void DenyButtonClicked()
    {
        reachSeat.denied = true;
        reachSeat.accepted = false;
    }
}
