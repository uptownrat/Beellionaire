using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BPCClass : UpgradeClass
{
    //protected uint beesPerClick;
    //[SerializeField] float BPC_cost;
    //[SerializeField] float BPC_mult;
    //[SerializeField] float BPC_multCost;
    //private int numBPCClicks;

    // Start is called before the first frame update
    void Start()
    {
        itemQuantity = 1;
        itemMult = 1.1f;
        itemCost = 10.0f;
        costMult = 1.2f;

        numUpgrades = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // calculates bees per click
    public void BPC()
    {
        numUpgrades++;
        itemQuantity = (uint)((itemQuantity + 1) * itemMult);
        itemCost = itemCost * costMult;

        Debug.Log("bees per click: " + itemQuantity);
        Debug.Log("bpc upgrade cost: " + itemCost);
        Debug.Log("Number of ugrades: " + numUpgrades);
    }
}
