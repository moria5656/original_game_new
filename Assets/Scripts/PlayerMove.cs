using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody playerBody;

    Vector3 inputDirection;

    float moveSpeed = 4.0f;

    Animator walkAnimator;


    // Start is called before the first frame update
    void Start()
    {
        inputDirection = new Vector3(1, 0, 0);
        playerBody = this.gameObject.GetComponent<Rigidbody>();
        walkAnimator = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        inputDirection = new Vector3(
            Input.GetAxis("Horizontal"),
            Input.GetAxis("Vertical")
            , 0
            );

        if (inputDirection == Vector3.zero)
        {
            walkAnimator.speed = 0;

        }
        else
        {
            walkAnimator.speed = 1;

            walkAnimator.SetFloat("x", inputDirection.x);
            walkAnimator.SetFloat("y", inputDirection.y);

        }
    }

    internal void Move(float h, float v1, float v2, float v3)
    {
        throw new NotImplementedException();
    }

    private void FixedUpdate()
    {
        playerBody.velocity = inputDirection * moveSpeed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "kusa")
        {
            GameManager.gm.SendMessage("Upscore");
            Destroy(this)
        }

        else if (other.gameObject.tag == "enemy")
        {

        }
    }
}
