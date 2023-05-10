using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField]float dropTimer = 4f;
     MeshRenderer renderer;
     Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        //caching a reference
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();
        renderer.enabled = false;
        rigidbody.useGravity = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > dropTimer)
        {
            renderer.enabled = true;
            rigidbody.useGravity = true;
        }
        
    }
}
