using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupScript : MonoBehaviour
{
    public bool pinkPaint;
    public bool orangePaint;
    public bool purplePaint;
    public bool turquoisePaint;
    public int paintIndex;
    // Start is called before the first frame update
    void Start()
    {
        SetAllInactive();
        paintIndex = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if(pinkPaint)
            {
                paintIndex = 1;
            }            
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (orangePaint)
            {
                paintIndex = 2;
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if (purplePaint)
            {
                paintIndex = 3;
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            if (turquoisePaint)
            {
                paintIndex = 4;
            }
        }
    }

    void SetAllInactive()
    {
        pinkPaint = false;
        orangePaint = false;
        purplePaint = false;
        turquoisePaint = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("pinkPickup"))
        {
            //SetAllInactive();
            pinkPaint = true;
            paintIndex = 1;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("orangePickup"))
        {
            //SetAllInactive();
            orangePaint = true;
            paintIndex = 2;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("purplePickup"))
        {
            //SetAllInactive();
            purplePaint = true;
            paintIndex = 3;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("turquoisePickup"))
        {
            //SetAllInactive();
            turquoisePaint = true;
            paintIndex = 4;
            Destroy(collision.gameObject);
        }
    }

}
