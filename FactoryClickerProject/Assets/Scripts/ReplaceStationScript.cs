using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class ReplaceStationScript : MonoBehaviour
{
    public UnityEvent changeDesign, changePrototype, changeMolding, changeProduction, changeAssembly, getDialogue;

    public TimerScript timerScript;

    public string sceneName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



        //After the timer reaches the selected times shown, it'll invoke the chosen event in the if statement.

        //In this case, when the time reaches 20 seconds, the button on the Design Station game object will switch off.
        if (timerScript.elapsedTime >= 20)
        {
            changeDesign.Invoke();
        }

        if (timerScript.elapsedTime >= 40)
        {
            changePrototype.Invoke();
        }

        if (timerScript.elapsedTime >= 60)
        {
            changeMolding.Invoke();
        }

        if (timerScript.elapsedTime >= 80)
        {
            changeProduction.Invoke();
        }

        if (timerScript.elapsedTime >= 100)
        {
            changeAssembly.Invoke();
        }
    }


    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneName);
    }


}
