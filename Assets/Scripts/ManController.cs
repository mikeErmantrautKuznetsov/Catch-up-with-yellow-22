using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManController : MonoBehaviour, IControllbleMan
{
    private float speed = 10f;
    private float RangeX = 4.4f;
    private float powerJump = 7.2f;
    private Rigidbody playerRB;
    [SerializeField]
    private Animator animator;
    [SerializeField]
    private Joystick joystick;
    [SerializeField]
    private GameObject sceneLoseGame;
    private bool isGround = false;

    private void Awake()
    {
        sceneLoseGame.SetActive(false);
    }

    private void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }

    public void ControllerMan()
    {
        float horizontal = joystick.Horizontal;
        float horizontal2 = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * horizontal * speed * Time.deltaTime);
        transform.Translate(Vector3.right * horizontal2 * speed * Time.deltaTime);
    }

    //public void Jump()
    //{

    //    if (Input.GetKeyDown(KeyCode.Space) && isGround == true)
    //    {
    //        playerRB.AddForce(Vector3.up * powerJump, ForceMode.Impulse);
    //        isGround = false;
    //        animator.SetBool("isGround", isGround);
    //    }
    //}

    private void RangePlay()
    {
        if (transform.position.x > RangeX)
        {
            transform.position = new Vector3(RangeX, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -RangeX)
        {
            transform.position = new Vector3(-RangeX, transform.position.y, transform.position.z);
        }
    }

    private void Update()
    {
        ControllerMan();
        RangePlay();
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PoliceCar"))
        {
            sceneLoseGame.gameObject.SetActive(true);
        }
        //if (collision.gameObject.CompareTag("isGround"))
        //{
        //    isGround = true;
        //    animator.SetBool("isGround", isGround);
        //}
        //else
        //{
        //    isGround = false;
        //    animator.SetBool("isGround", isGround);
        //}

    }

}
