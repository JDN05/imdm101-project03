using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaffRoll : MonoBehaviour
{
    public Vector3 rightwardVector, leftwardVector;
    public float leftBound, rightBound;

    public float bufferTime;
    float buffer;

    public float downTime;
    float down = 0f;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (buffer <= 0)
        {
            if (transform.position.x < leftBound)
            {
                rb.AddForce(rightwardVector, ForceMode.Impulse);

                startBuffer();
            }
            else if (transform.position.x > rightBound)
            {
                rb.AddForce(leftwardVector, ForceMode.Impulse);

                startBuffer();
            }
        } 
        else
        {
            buffer -= Time.deltaTime;
        }


        down += Time.deltaTime;

        if (down > downTime)
        {
            if (transform.position.x < 0)
            {
                rb.AddForce(rightwardVector, ForceMode.Impulse);
            }
            else
            {
                rb.AddForce(leftwardVector, ForceMode.Impulse);
            }
            startBuffer();
        }
    }

    void startBuffer()
    {
        buffer = bufferTime;
        down = 0f;
    }
}
