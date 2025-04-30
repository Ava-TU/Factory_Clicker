using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ReplaceStationScript : MonoBehaviour
{
    public UnityEvent changeDesign, changePrototype, changeMolding, changeProduction, changeAssembly;

    public TimerScript timerScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timerScript.elapsedTime >= 20)
        {
            changeDesign.Invoke();
        }

        if (timerScript.elapsedTime >= 40)
        {
            changePrototype.Invoke();
        }
    }
}
