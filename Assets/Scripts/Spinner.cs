using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float rotationValueX = 0;
    [SerializeField] float rotationValueY =0.5f;
  
    [SerializeField] float rotationValueZ = 0;

    // Update is called once per frame
    void Update()
    {
      transform.Rotate(rotationValueX, rotationValueY, rotationValueZ);  
    }
}
