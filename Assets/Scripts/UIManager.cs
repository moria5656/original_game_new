using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public Text timerText;
    public Text resultText;
    public ScoreScript scoreScript;
    public float timer;
    float gameTime = 20.0f;
    public GameObject gameController;

    int ScoreR;
    int ScoreL;

    // Start is called before the first frame update
    void Start()
    {
        timer = gameTime;
        int ScoreR;
        int ScoreL;
        ScoreR = scoreScript.scoreR;
        ScoreL = scoreScript.scoreL;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= 0.0f)
        {
            timer -= Time.deltaTime;
            timerText.text = "残り時間:" + timer.ToString("f1");
        }
        else
        {
            timerText.text = "タイムアップ";
            Invoke("sendMessage", 0.5f);
            if (ScoreR > ScoreL)
            {
                resultText.text = "Winner is PlayerRight" + ScoreR.ToString("f1");
            }
            else if (ScoreL > ScoreR)
            {
                resultText.text = "Winner is PlayerLeft" + ScoreL.ToString("f1");
            }
            else if (ScoreR == ScoreL)
            {
                resultText.text = "DRAW";
            }

            //scoreText.text = "スコア:" + score.ToString("f0");
        }
    }

    void sendMessage()
    {
        if (SceneManager.GetActiveScene().name == "Main")
        {
            gameController.SendMessage("ToResult");
        }

    }
}


