using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    internal static object gm;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    public void StartGame()
    {
        if (SceneManager.GetActiveScene().name == "Title")
        {
            ToMain();
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void ToMain()
    {
        SceneManager.LoadScene("Main");
    }

    public void ToResult()
    {
        SceneManager.LoadScene("Result");   
    }

   
}
