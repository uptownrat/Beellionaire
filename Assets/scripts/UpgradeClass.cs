using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UpgradeClass : MonoBehaviour
{
    protected uint itemQuantity; // amount of item player has
    protected float itemQuantityFloat;
    protected uint numUpgrades; // how many times the player bought this upgrade

    // remove serialize later
    [SerializeField] protected float itemCost; // cost of upgrade, visible to player
    [SerializeField] protected float costMult; // how much cost goes up when upgrading
    [SerializeField] protected float itemMult; // efficiency

    // for upgrades that have timers / intervals 
    //[SerializeField] protected float intervalMult;
    //[SerializeField] protected float intervalCost;
    //[SerializeField] protected float intervalCostMult;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
