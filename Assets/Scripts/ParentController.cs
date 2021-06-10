using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentController : MonoBehaviour
{
    public GameObject _parent;
    public GameObject[] _child;
    private float forInstantiateTime = 3.0f;
    private int number;
    //public int score = 0;

    public object RootObject { get; private set; }


    // Start is called before the first frame update

    void Start()
    {
        InstantiateChild();
        /*
        int count = 0;
        foreach (Transform _child in transform)
        {
            count++;
            Debug.Log("children");
        }
        */
    }



    // Update is called once per frame
    void Update()
    { 
        forInstantiateTime -= Time.deltaTime;
        if (forInstantiateTime <= 0.0f)
        {
            DestroyAllChildren();
            InstantiateChild();
            forInstantiateTime = 3.0f;
        }
      
    }

    void InstantiateChild()
    {
        number = Random.Range(0, _child.Length);
        Transform ParentPosition = _parent.transform;
        Instantiate(_child[number], transform.position, Quaternion.identity, ParentPosition);
    }

    void DestroyAllChildren()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Destroy(transform.GetChild(i).gameObject);
        }
        transform.DetachChildren();
    }
}