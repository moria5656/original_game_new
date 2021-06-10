using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //UI機能を扱うときに追記する

public class ScoreScript : MonoBehaviour
{
    private int score; //得点の変数
    public Text ScoreText; //得点の文字の変数

    public void UpScore1()
    {
        score = score + 100;
    }

    public void UpScore2()
    {
        score = score + 200;
    }

    public void UpScore3()
    {
        score = score + 300;
    }

    public void UpScore4()
    {
        score = score + 400;
    }

    public void UpScore5()
    {
        score = score + 500;
    }

    public void DownScoreObstacle1()
    {
        score = score - 500;
    }

    public void DownScoreObstacle2()
    {
        score = score - 250;
    }

    // Start is called before the first frame update
    void Start()
    {
        score = 0; //得点を0にする
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(score);
        ScoreText.text = "Score:" + score.ToString(); //ScoreTextの文字をScore:Scoreの値にする

        
    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Kusa1")
        {
            score += 100;

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

