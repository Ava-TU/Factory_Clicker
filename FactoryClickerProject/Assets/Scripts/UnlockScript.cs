using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class UnlockScript : MonoBehaviour
{

    public UnityEvent unlock, lockButton;

    public ResourceTracker resources;

    public string buttonName = "@";
    public int purchaseCost;
    public TMP_Text costText, nameText;


    // Start is called before the first frame update
    void Start()
    {
        SetUI();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            print(resources.resourcesAvailable);
        }

        if (resources.resourcesAvailable >= purchaseCost)
        {
            unlock?.Invoke();
        }
        else
        {
            lockButton.Invoke();
        }
    }

    private void SetUI()
    {
        nameText.text = buttonName;
        costText.text = purchaseCost.ToString();
    }

}
