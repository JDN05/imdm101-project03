    using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class bookRotation : MonoBehaviour
{

    public float rotateSpeed = 30f;
    

    void Start()
    {
      
    }

    void Update()

    {
        transform.Rotate(Vector3.forward, rotateSpeed * Time.deltaTime);

    }
}
