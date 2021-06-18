using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    Rigidbody playerBody;
    Vector3 inputDirection;
    float moveSpeed = 4.0f;
    Animator walkAnimator;
    public GameObject particleObject;


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
    

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Kusa1")
        {
            GameObject k1 = collider.gameObject;
            Instantiate(particleObject, this.transform.position, Quaternion.identity); //パーティクル用ゲームオブジェクト生成
            Destroy(k1, 0.01f);
        }

        else if (collider.gameObject.tag == "Kusa2")
        {
            GameObject k2 = collider.gameObject;
            Instantiate(particleObject, this.transform.position, Quaternion.identity); //パーティクル用ゲームオブジェクト生成
            Destroy(k2, 0.01f);
        }

        else if (collider.gameObject.tag == "Kusa3")
        {
            GameObject k3 = collider.gameObject;
            Instantiate(particleObject, this.transform.position, Quaternion.identity); //パーティクル用ゲームオブジェクト生成
            Destroy(k3, 0.01f);
        }

        else if (collider.gameObject.tag == "Kusa4")
        {
            GameObject k4 = collider.gameObject;
            Instantiate(particleObject, this.transform.position, Quaternion.identity); //パーティクル用ゲームオブジェクト生成
            Destroy(k4, 0.01f);
        }

        else if (collider.gameObject.tag == "Kusa5")
        {
            GameObject k5 = collider.gameObject;
            Instantiate(particleObject, this.transform.position, Quaternion.identity); //パーティクル用ゲームオブジェクト生成
            Destroy(k5, 0.01f);
        }

        else if (collider.gameObject.tag == "Obstacle1")
        {
            GameObject o1 = collider.gameObject;
            
            Destroy(o1, 0.01f);
        }

        else if (collider.gameObject.tag == "Obstacle2")
        {
            GameObject o2 = collider.gameObject;
            
            Destroy(o2, 0.01f);
        }

        else if (collider.gameObject.tag == "Flower")
        {
            GameObject f = collider.gameObject;

            Destroy(f, 0.01f);
        }
    }

    
    
}
