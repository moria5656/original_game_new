using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildController : MonoBehaviour
{ 
    public GameObject _parent;
    public GameObject _child;
    

    // Start is called before the first frame update
    void Start()
    {
        _parent = transform.root.gameObject;
        Debug.Log("Parent:" + _parent.name);
    }

    // Update is called once per frame
    void Update()
    {
        _child.transform.parent = _parent.transform;
    }
}
