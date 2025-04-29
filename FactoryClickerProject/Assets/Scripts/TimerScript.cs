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
        AddMachines();
    }

    private void AddMachines()
    {
        if (myResources.resourcesAvailable == 1000)
        {
            elapsedTime += Time.deltaTime;

            print(elapsedTime);
        }
    }

}
