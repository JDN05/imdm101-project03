using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bookOrbit : MonoBehaviour
{

    public GameObject pivot;
    public float orbitSpeed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(pivot.transform.position, Vector3.up, orbitSpeed * Time.deltaTime);
    }
}
