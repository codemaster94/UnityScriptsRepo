using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaDeactivation : MonoBehaviour
{
    public Image penguin;
    public Image bunny;
    public Image butterfly;

    public Image elephant;
    public Image parrot;
    public Image swan;

    public void DeactivateAllManaImages()
    {
        penguin.gameObject.SetActive(false);
        bunny.gameObject.SetActive(false);
        butterfly.gameObject.SetActive(false);
        elephant.gameObject.SetActive(false);
        parrot.gameObject.SetActive(false);
        swan.gameObject.SetActive(false);
    }
}
