using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerScript : MonoBehaviour
{
    public float elapsedTime;
    public ResourceTracker myResources;

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        print(elapsedTime);
    }
}
