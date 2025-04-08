using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Upgrade_Amount : MonoBehaviour
{

    public string upgradeName = "@@@";
    public int numberOwned, baseCost, purchaseCost;
    public float multiplier = 1.5f;
    public TMP_Text costText, nameText, numberText;
    public ResourceTracker myResources;
    public float autoClickIncrease = 0.1f;


    private void Start()
    {
        SetUI();
    }

    private void SetUI()
    {
        CalculateCost();
        nameText.text = upgradeName;
        costText.text = purchaseCost.ToString();
        numberText.text = numberOwned.ToString();
    }

    private void CalculateCost()
    {
        purchaseCost = Mathf.CeilToInt(baseCost * Mathf.Pow(multiplier, numberOwned));
    }

}
