using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderController2 : MonoBehaviour
{

    public float Speed = 5f;
    public float JumpHeight = 2f;
    public float Gravity = -9.81f;
    public float GroundDistance = 0.2f;
    //public float DashDistance = 5f;
    public LayerMask Ground;
    //public Vector3 Drag;

    private Animator anim;

    private CharacterController _controller;
    private Vector3 _velocity;
    private bool _isGrounded = true;
    public Transform _groundChecker;


    void Start()
    {
        _controller = GetComponent<CharacterController>();
        anim = GetComponentInChildren<Animator>();
        //_groundChecker = transform.GetChild(0);
    }

    void Update()
    {
        _isGrounded = Physics.CheckSphere(_groundChecker.position, GroundDistance, Ground, QueryTriggerInteraction.Ignore);
        if (_isGrounded && _velocity.y < 0)
            _velocity.y = 0f;

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        _controller.Move(move * Time.deltaTime * Speed);
        if (move != Vector3.zero)
        {
            transform.forward = move;
            anim.SetBool("isWalking", true);
        }
        else {
            anim.SetBool("isWalking", false);
        }
            

        /*if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
            _velocity.y += Mathf.Sqrt(JumpHeight * -2f * Gravity);
        if (Input.getkey(KeyCode.LeftShift))
        {
            Debug.Log("Dash");
            _velocity += Vector3.Scale(transform.forward, DashDistance * new Vector3((Mathf.Log(1f / (Time.deltaTime * Drag.x + 1)) / -Time.deltaTime), 0, (Mathf.Log(1f / (Time.deltaTime * Drag.z + 1)) / -Time.deltaTime)));
        }*/


        _velocity.y += Gravity * Time.deltaTime;

        /*_velocity.x /= 1 + Drag.x * Time.deltaTime;
        _velocity.y /= 1 + Drag.y * Time.deltaTime;
        _velocity.z /= 1 + Drag.z * Time.deltaTime;
        */
        _controller.Move(_velocity * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Place"))
        {
            Debug.Log("SittingPlace Destroyed");
            //Destroy(collision.gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Place"))
        {
            Debug.Log("Reached");
        } 
    }




    /* private CharacterController controller;
    public float moveSpeed = 6f;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;


    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        Vector3 moveDirection = new Vector3(moveHorizontal, 0.0f, moveVertical).normalized;

        if (moveDirection.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(moveDirection.x, moveDirection.z)*Mathf.Rad2Deg;

            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity,turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            
            controller.Move(moveDirection * moveSpeed * Time.deltaTime);
        }
    }*/
}
