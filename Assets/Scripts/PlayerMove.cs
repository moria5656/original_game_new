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
    /*
    // Update is called once per frame
    void Update()
    {
        inputDirection = new Vector3(
            Input.GetAxis("Horizontal"),
            Input.GetAxis("Vertical")
            , 0
            );
    //inputDirectionの代入はPlayerIDによって移動の値が変化するため、ここの代入はいらない

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
    */

    /*
     internal void Move(float h, float v1, float v2, float v3)
     {
         throw new NotImplementedException();
     }
     */

    public void Move(float v1, float v2, float v3)
    {
        inputDirection = new Vector3(v1, v2, v3);
    }
    //これはプレイヤーの移動する方向を定義しています。実際の移動は`FixedUpdate()`で行っているので代入だけで大丈夫です。

    private void FixedUpdate()
    {
        playerBody.velocity = inputDirection * moveSpeed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "kusa")
        {
            /*
            GameManager.gm.SendMessage("Upscore");
            GameObject 
            Destroy(this)
            */
        }

        else if (other.gameObject.tag == "enemy")
        {

        }
    }
}
