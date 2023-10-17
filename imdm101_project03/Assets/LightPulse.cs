using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightPulse : MonoBehaviour
{
    public float max, min;
    public float period;

    float progress = 0f;

    Light light;
    
    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();    
    }

    // Update is called once per frame
    void Update()
    {
        progress += Time.deltaTime;
        light.intensity = Mathf.Lerp(min, max, sineProgress((progress % period) / 10));
    }

    float sineProgress(float progress)
    {
        progress = Mathf.Lerp(0, 2 * Mathf.PI, progress);
        progress = Mathf.Sin(progress);
        progress = (progress / 2f) + 0.5f;
        return progress;
    }
}
