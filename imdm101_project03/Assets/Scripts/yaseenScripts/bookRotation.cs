using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bookRotation : MonoBehaviour
{
    public GameObject pivot;
    public Vector3 direction;
    public float angle;
    public float radius = 10;
    public float degreesPerSecond_rotate = 20;
    public float degreesPerSecond_orbit = 30;
    // Start is called before the first frame update
    void Start()
    {
        direction = (transform.position - pivot.transform.position).normalized;
        radius = Vector3.Distance(pivot.transform.position, transform.position);
    }

    // Update is called once per frame
    
    private void Update()
    {
        transform.Rotate(new Vector3(0, degreesPerSecond_rotate, 0) * Time.deltaTime);
        angle += degreesPerSecond_orbit * Time.deltaTime;
        if(angle > 360)
        {
            angle -= 360;
        }
        Vector3 orbit = Vector3.forward * radius;
        orbit = Quaternion.LookRotation(direction) * Quaternion.Euler(0, angle, 0) * orbit;
        transform.position = pivot.transform.position + orbit;
    }
}
