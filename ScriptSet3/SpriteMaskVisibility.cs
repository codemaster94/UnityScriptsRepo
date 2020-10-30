using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMaskVisibility : MonoBehaviour
{
    private SpriteMask spr;
    public bool isMaskEnabled;
    public GameObject painter;
    private int myStage;
    public GameObject set;

    public Sprite pinkSprite;
    public Sprite orangeSprite;
    public Sprite purpleSprite;
    public Sprite turquoiseSprite;
    public SpriteRenderer sprToChange;
    public PickupScript pickUpScript;


    // Start is called before the first frame update
    void Start()
    {
        spr = GetComponent<SpriteMask>();
        spr.enabled = false;
        isMaskEnabled = false;
        myStage = set.GetComponent<Set>().getSetNumber();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && Input.GetKeyDown(KeyCode.B)) //CanPaint()
        {
            spr.enabled = true;
            isMaskEnabled = true;
            SetTheColouredSprite();
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && Input.GetKeyDown(KeyCode.B)) //CanPaint()
        {
            spr.enabled = true;
            isMaskEnabled = true;
            SetTheColouredSprite();
        }
    }
    private bool CanPaint()
    {
        switch (myStage)
        {
            case 1: return painter.GetComponent<PickupScript>().pinkPaint;
            case 2: return painter.GetComponent<PickupScript>().orangePaint;
            case 3: return painter.GetComponent<PickupScript>().purplePaint;
            case 4: return painter.GetComponent<PickupScript>().turquoisePaint;
            case 5: return true;
            default:return false;
        }
    }
    public void SetTheColouredSprite()
    {
        switch (pickUpScript.paintIndex)
        {
            case 1: sprToChange.sprite = pinkSprite;
                break;
            case 2: sprToChange.sprite = orangeSprite;
                break;
            case 3: sprToChange.sprite = purpleSprite;
                break;
            case 4: sprToChange.sprite = turquoiseSprite;
                break;
            default: break;

        }
    }
}
