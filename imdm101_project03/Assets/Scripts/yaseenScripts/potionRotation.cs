using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potionRotation : MonoBehaviour
{
    public float angle;
    public float angleVar=9;
    public float degreesPerSecond_rotate = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        angle = Mathf.Sin(Time.time*degreesPerSecond_rotate) * angleVar;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
