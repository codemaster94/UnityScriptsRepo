using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MySeat : MonoBehaviour
{
    public NavMeshAgent myNavMeshAgent;
    public GameObject seatToSit;
    private Animator anim;

    public bool isAtBooth;
    private Mycanvas mycanvasscript;

    // Start is called before the first frame update
    void Start()
    {
        mycanvasscript = GetComponent<Mycanvas>();
        mycanvasscript.enabled = false;
        myNavMeshAgent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        isAtBooth = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (myNavMeshAgent.enabled)
        {
            myNavMeshAgent.SetDestination(seatToSit.transform.position);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Place"))
        {
            if (other.name == seatToSit.name)
            {
                myNavMeshAgent.enabled = false;
                Debug.Log("Place Reached trigger detected");

                /*Vector3 targetDir = new Vector3(other.transform.position.x - transform.position.x, 0f, other.transform.position.z - transform.position.z);
                Quaternion rot = Quaternion.LookRotation(targetDir);
                transform.rotation = Quaternion.Slerp(transform.rotation, rot, 1f);
                */
                transform.rotation = other.transform.rotation;
                anim.SetBool("isSitting", true);
                Destroy(other.gameObject);
            }

        }

        if (other.gameObject.CompareTag("Ticket"))
        {
            myNavMeshAgent.enabled = false;
            isAtBooth = true;
            Debug.Log("Ticket Booth reached!");
            anim.SetBool("isIdle", true);
            mycanvasscript.enabled = true;
        }

        if (other.gameObject.name == "SpawnPointOutside")
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Ticket")
        {
            isAtBooth = false;
            Debug.Log("Exited Booth");
            anim.SetBool("isIdle", false);
            mycanvasscript.enabled = false;
        }
    }
}
