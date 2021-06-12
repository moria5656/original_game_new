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
            scoreR = scoreR - 500;
        }
        else if (this.gameObject.tag == "PlayerL")
        {
            scoreL = scoreL - 500;
        };
    }

    public void DownScoreObstacle2()
    {
        if (this.gameObject.tag == "PlayerR")
        {
            scoreR = scoreR - 250;
        }
        else if (this.gameObject.tag == "PlayerL")
        {
            scoreL = scoreL - 250;
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
        Debug.Log(scoreR);
        Debug.Log(scoreL);
        scoreTextR.text = "Score:" + scoreR.ToString(); //ScoreTextの文字をScore:Scoreの値にする
        scoreTextL.text = "Score:" + scoreL.ToString();


    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Kusa1")
        {
            UpScore1();

        }

        else if (collider.gameObject.tag == "Kusa2")
        {

            UpScore2();

        }
        else if (collider.gameObject.tag == "Kusa3")
        {
            UpScore3();

        }

        else if (collider.gameObject.tag == "Kusa4")
        {

            UpScore4();

        }

        else if (collider.gameObject.tag == "Kusa5")
        {

            UpScore5();

        }

        else if (collider.gameObject.tag == "Obstacle1")
        {

            DownScoreObstacle1();

        }

        else if (collider.gameObject.tag == "Obstacle2")
        {

            DownScoreObstacle2();

        }
    }   
}

