using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResourceTracker : MonoBehaviour
{

    public int resourcesAvailable;
    public float autoClicks, autoClickPool;
    public TMP_Text resourceCounter, clickCounter;


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

    //Takes away resources
    public void RemoveResources(int amountToRemove)
    {
        resourcesAvailable -= amountToRemove;
        UpdateUI();
    }


    public bool CheckResources (int checkAmount)
    {
        if (checkAmount <= resourcesAvailable)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void Update()
    {
        autoClickPool += autoClicks * Time.deltaTime;
        if (autoClickPool >= 1f)
        {
            autoClickPool -= 1f;
            AddResources(1);
            UpdateUI();
        }

        UpdateUI();
        
        
        //if (resourcesAvailable == 20)
        //{
            //print("Wow");
        //}
    }


    private void UpdateUI()
    {
        resourceCounter.text = "Money: " + resourcesAvailable.ToString();
        clickCounter.text = "Money Per Second " + (Mathf.Round(autoClicks * 10)/10).ToString();
    }

    private void AddMachines()
    {
        if (resourcesAvailable > 1000 && )
    }

}
