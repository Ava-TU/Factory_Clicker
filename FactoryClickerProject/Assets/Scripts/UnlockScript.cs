using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class UnlockScript : MonoBehaviour
{

    public UnityEvent remove, show, interacted;

    private bool insideTrigger;

    // Update is called once per frame
    void Update()
    {
        if (insideTrigger && Input.GetKeyDown(KeyCode.Mouse0))
        {
            interacted?.Invoke();
        }
    }
}
