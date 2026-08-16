using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StoreItemClass : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI costDisplay;

    public float cost;
    public float costMult;
    float baseCost;

    public float upgradeMult;
    public float upgradeF;
    float baseUpgradeF;
    public int upgradeI;
    int baseUpgradeI;

    bool isUnlocked;


    // Start is called before the first frame update
    void Start()
    {
        costDisplay.text = baseCost.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetCost(float c, float bc, float cm)
    {
        cost = c;
        baseCost = bc;
        costMult = cm;
    }
    
    // for setting decimnal upgrades
    public void SetUpgrade(float u, float bu, float um)
    {
        upgradeF = u;
        baseUpgradeF = bu;
        upgradeMult = um;
    }

    // for setting decimnal upgrades
    public void SetUpgrade(int u, int bu, float um)
    {
        upgradeI = u;
        baseUpgradeI = bu;
        upgradeMult = um;
    }

    //checks for money and increases cost
    public void Purchase()
    {
        cost = cost * costMult;
    }

    public void writetest()
    {
        Debug.Log("cost: " + cost + ", upgrade amt f: " + upgradeF);
    }

    //TO-DO: unlock purchase function
}
