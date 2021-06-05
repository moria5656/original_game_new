using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    public GameObject[] obstacle;
    private float forInstantiateTime = 1.0f;
    private int number;
    

    // Start is called before the first frame update
   
    void Start()
    {
        forInstantiateTime = 1.0f;
        //Destroy(gameObject, time);
    }
   
    /*
    private IEnumerator Start()
    {
        while (true)
        {
            Instantiate(obstacle[number], transform.position, Quaternion.identity);

            yield return new WaitForSeconds(time);
        }
    }
    */

    // Update is called once per frame
    void Update()
    {
        forInstantiateTime -= Time.deltaTime;
        if(forInstantiateTime <= 0.0f)
        { 
            number = Random.Range(0, obstacle.Length);
            Instantiate(obstacle[number], transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    

    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            
        }
    }
}
