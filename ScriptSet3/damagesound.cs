using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damagesound : MonoBehaviour
{
    public AudioSource audiosrc;
    // Start is called before the first frame update
    void Start()
    {
        audiosrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        audiosrc.Play();
    }
}
