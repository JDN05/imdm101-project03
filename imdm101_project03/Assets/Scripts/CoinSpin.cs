using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpin : MonoBehaviour
{
    public Vector3 spinVector;
    public Vector3 maxSpin, minSpin;
    public float spinPeriod;

    public Vector3 rotationProgress;

    float timeProgress;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        updateSpinSpeed();
        spin();
    }

    void spin()
    {
        transform.rotation = Quaternion.Euler(rotationProgress);
    }

    void updateSpinSpeed()
    {
        timeProgress += Time.deltaTime;
        float progress = sineProgress((timeProgress/ spinPeriod) % 1f);
        spinVector = Vector3.Lerp(minSpin, maxSpin, progress);
        rotationProgress += spinVector;
    }

    float sineProgress(float progress)
    {
        progress = Mathf.Lerp(0, 2 * Mathf.PI, progress);
        progress = Mathf.Sin(progress);
        progress = (progress / 2f) + 0.5f;
        return progress;
    }
}
