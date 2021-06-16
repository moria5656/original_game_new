using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //UI機能を扱うときに追記する

public class ScoreScript : MonoBehaviour
{
    public int scoreR;//得点の変数
    public int scoreL;
    public Text scoreTextR; //得点の文字の変数
    public Text scoreTextL;
    public GameObject playerR;
    public GameObject playerL;

    public AudioSource audioSource;
    public AudioClip soundEffect01;
    public AudioClip soundEffect02;
    public AudioClip soundEffect03;
    public AudioClip soundEffect04;
    public AudioClip soundEffect05;
    public AudioClip soundEffect06;
    public AudioClip soundEffect07;
    public AudioClip soundEffect08;



    public void UpScore1()
    {
        if(gameObject.tag == "PlayerR")
        {
            scoreR = scoreR + 100;
        }
        else if(gameObject.tag == "PlayerL")
        {
            scoreL = scoreL + 100;
        }
    }

    public void UpScore2()
    {
        if (gameObject.tag == "PlayerR")
        {
            scoreR = scoreR + 200;
        }
        else if (gameObject.tag == "PlayerL")
        {
            scoreL = scoreL + 200;
        }
    }

    public void UpScore3()
    {
        if (this.gameObject.tag == "PlayerR")
        {
            scoreR = scoreR + 300;
        }
        else if (this.gameObject.tag == "PlayerL")
        {
            scoreL = scoreL + 300;
        }
    }

    public void UpScore4()
    {
        if (this.gameObject.tag == "PlayerR")
        {
            scoreR = scoreR + 400;
        }
        else if (this.gameObject.tag == "PlayerL")
        {
            scoreL = scoreL + 400;
        }
    }

    public void UpScore5()
    {
        if (this.gameObject.tag == "PlayerR")
        {
            scoreR = scoreR + 500;
        }
        else if (this.gameObject.tag == "PlayerL")
        {
            scoreL = scoreL + 500;
        }
    }

    public void DownScoreObstacle1()
    {
        if (this.gameObject.tag == "PlayerR")
        {
            scoreR = scoreR - 200;
        }
        else if (this.gameObject.tag == "PlayerL")
        {
            scoreL = scoreL - 200;
        };
    }

    public void DownScoreObstacle2()
    {
        if (this.gameObject.tag == "PlayerR")
        {
            scoreR = scoreR - 100;
        }
        else if (this.gameObject.tag == "PlayerL")
        {
            scoreL = scoreL - 100;
        }
    }

    public void DownScoreFlower()
    {
        if (this.gameObject.tag == "PlayerR")
        {
            scoreR = scoreR - 1000;
        }
        else if (this.gameObject.tag == "PlayerL")
        {
            scoreL = scoreL - 1000;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        scoreR = 0; //得点を0にする
        scoreL = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("ScoreScript.R = " + scoreR);
        Debug.Log("ScoreScript.L = " + scoreL);
        if(this.gameObject.tag == "PlayerR")
        {
            scoreTextR.text = "Score:" + scoreR.ToString(); //ScoreTextの文字をScore:Scoreの値にする
        }
        else if(this.gameObject.tag == "PlayerL")
        {
            scoreTextL.text = "Score:" + scoreL.ToString();
        }


    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Kusa1")
        {
            UpScore1();
            audioSource.PlayOneShot(soundEffect01);
        }

        else if (collider.gameObject.tag == "Kusa2")
        {

            UpScore2();
            audioSource.PlayOneShot(soundEffect02);
        }
        else if (collider.gameObject.tag == "Kusa3")
        {
            UpScore3();
            audioSource.PlayOneShot(soundEffect03);
        }

        else if (collider.gameObject.tag == "Kusa4")
        {

            UpScore4();
            audioSource.PlayOneShot(soundEffect04);
        }

        else if (collider.gameObject.tag == "Kusa5")
        {

            UpScore5();
            audioSource.PlayOneShot(soundEffect05);
        }

        else if (collider.gameObject.tag == "Obstacle1")
        {

            DownScoreObstacle1();
            audioSource.PlayOneShot(soundEffect06);

        }

        else if (collider.gameObject.tag == "Obstacle2")
        {

            DownScoreObstacle2();
            audioSource.PlayOneShot(soundEffect07);

        }

        else if (collider.gameObject.tag == "Flower")
        {

            DownScoreFlower();
            audioSource.PlayOneShot(soundEffect08);

        }
    }   
}

