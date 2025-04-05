using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResourceTracker : MonoBehaviour
{

    public int resourcesAvailable;
    public TMP_Text resourceCounter;


    private void Start()
    {
        UpdateUI();
    }

    // Add resources to available pool
    public void AddResources(int amountToAdd)
    {
        resourcesAvailable += amountToAdd;
        UpdateUI();
    }

    private void UpdateUI()
    {
        resourceCounter.text = "Money: " + resourcesAvailable.ToString();
    }

}
