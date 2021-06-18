using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public Text timerText;
    public Text resultText;
    public Text resultScoreText;
    //public Text countDownText;

    //public static UIManager instance;
    public ScoreScript scoreScript;
    public float timer;
    float gameTime = 20.0f;
   


    public GameObject gameController;
    public GameObject playerR;
    public GameObject playerL;
    public GameObject panel;
    public AudioSource audioSource;

    public bool isPlaying;

    public AudioClip soundEffectClear;

    int ScoreR;
    int ScoreL;

    // Start is called before the first frame update
    void Start()
    {
        isPlaying = false;
        timer = gameTime;
        //countDownText.text = "";
        //StartCoroutine(CountDown());
    }

    // Update is called once per frame
    void Update()
    {
        ScoreR = playerR.gameObject.GetComponent<ScoreScript>().scoreR;
        ScoreL = playerL.gameObject.GetComponent<ScoreScript>().scoreL;
        //ScoreR = scoreScript.scoreR;ばつ
        //ScoreL = scoreScript.scoreL;ばつ
        //変数を保存しているのはgameobjectである
        Debug.Log("ScoreR is " + ScoreR);
        Debug.Log("ScoreL is " + ScoreL);
        if (timer >= 0.0f)
        {
            timer -= Time.deltaTime;
            timerText.text = "TIME :" + timer.ToString("f1");
        }
        else
        {
            timerText.text = "TIMEUP";
            audioSource.PlayOneShot(soundEffectClear);
            //isPlaying = false;
            Invoke("startFadeOut", 0.5f);
            Invoke("sendMessage", 1.8f);
            if (ScoreR > ScoreL)
            {
                resultText.text = "Winner is PlayerRight";
                resultScoreText.text = ScoreR.ToString("f0");
            }
            else if (ScoreL > ScoreR)
            {
                resultText.text = "Winner is PlayerLeft";
                resultScoreText.text = ScoreL.ToString("f0");
            }
            else if (ScoreR == ScoreL)
            {
                resultText.text = "DRAW";
            }
        }

        /*
        if (timer > 15.0f)
        {
            audioSource.clip = bgm01;
            audioSource.Play();
        }
        else if (timer == 15.0f)
        {
            audioSource.Stop();
        }
        else if (15.0f > timer & timer > 0.0f)
        {
            audioSource.clip = bgm02;
            audioSource.Play();
        }

        else if (timer == 0.0f)
        {
            audioSource.Stop();
        }
        */

        //scoreText.text = "スコア:" + score.ToString("f0");
    }



    void sendMessage()
    {
        if (SceneManager.GetActiveScene().name == "Main")
        {
            gameController.SendMessage("ToResult");
        }

    }

    void startFadeOut()
    {
        panel.SendMessage("StartFadeOut");
    }

    /*
    IEnumerator CountDown()
    {
        countDownText.text = "3";
        yield return new WaitForSeconds(1.0f);

        countDownText.text = "2";
        yield return new WaitForSeconds(1.0f);

        countDownText.text = "1";
        yield return new WaitForSeconds(1.0f);

        countDownText.text = "START";
        yield return new WaitForSeconds(1.0f);

        countDownText.text = "";
        isPlaying = true;
    }
    */
}


