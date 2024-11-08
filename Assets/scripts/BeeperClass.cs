using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HireBeepers : UpgradeClass
{
    [SerializeField] GameManager gameManager;
    [SerializeField] GameObject beeperMan;

    // Start is called before the first frame update
    void Start()
    {
        numUpgrades = 0;
        itemCost = 50.0f;
        costMult = 1.2f;
        itemMult = 1.1f;

        itemQuantity = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public uint getNumBeeper()
    {
        return itemQuantity;
    }

    public void AddBeeper()
    {
        numUpgrades++;
        Instantiate(beeperMan, new Vector3(0.0f, -4.5f, 0.0f), Quaternion.identity);
        Debug.Log("created beeper");
    }
}

public class BeeperIntervalClass : UpgradeClass
{

    void Start()
    {
        numUpgrades = 0;
        itemQuantityFloat = 5.0f;
        itemCost = 60.0f;
        costMult = 1.25f;
        itemMult = 0.02f;
    }

    private void Update()
    {

    }

    public float getItemQuantity() { return itemQuantityFloat; }
}

public class BeeperEfficiencyClass : UpgradeClass
{

    void Start()
    {
        
    }

    void Update()
    {

    }

}

public class BeeperClass : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    [SerializeField] HireBeepers beeper;
    [SerializeField] BeeperEfficiencyClass beeperEfficiency;
    [SerializeField] BeeperIntervalClass beeperInterval;

    protected float beepTimer;

    void Start()
    {
        beepTimer = 0.0f;
    }

    void Update()
    {
        beepTimer += Time.deltaTime;
        if (beepTimer > )
        {
            triggerBeep();
            beepTimer = 0.0f;
        }
    }

    // auto clicker
    public void triggerBeep()
    {
        uint numBeeps;
        numBeeps = (uint)beeperInterval.getItemQuantity() * beeper.getNumBeeper();
        Debug.Log("beeped: " + numBeeps);
        gameManager.totalBees += numBeeps;
        // take intbeespicked = 1*numbeeper * beepedmult
        gameManager.beeCountText.text = "total bees: " + gameManager.totalBees;
    }
}