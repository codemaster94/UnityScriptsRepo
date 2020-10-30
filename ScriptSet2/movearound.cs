using System.Collections;
using System.Collections.Generic;
//using UnityEditorInternal;
using UnityEngine;

public class movearound : MonoBehaviour
{
    public Transform place1;
    public Transform place2;
    //private Vector3 pos1 = new Vector3(-4, 0, 0);
    //private Vector3 pos2 = new Vector3(4, 0, 0);
    public float speed = 1.0f;
    private SpriteRenderer spr1;


    // Start is called before the first frame update
    void Start()
    {
        spr1 = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(place1.position,place2.position , Mathf.PingPong(Time.time * speed, 1.0f));
        if (transform.position == place1.position)
        {
            spr1.flipX = true;
        }
        if (transform.position == place2.position)
        {
            spr1.flipX = false;
        }
    }
}