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

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().name == "Title")
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                ToMain();
            }
        }
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
