using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text timerText;
    public Text scoreText;
    public PlayerMove player;
    public float timer;
    float gameTime = 20.0f;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        timer = gameTime;
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
        }

        scoreText.text = "スコア:" + score.ToString("f0");
    }
}
