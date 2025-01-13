using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BeeperClass : MonoBehaviour
{
    [SerializeField] GameManager gameManager;

    uint numBeepers;
    float beepCost;
    [SerializeField] float beepCostMult;

    uint beeped;
    [SerializeField] float beepedMult;
    [SerializeField] float beepedCost;
    [SerializeField] float beepedCostMult;

    float beepTimer;
    float pickInterval;

    [SerializeField] float pickIntMult;
    [SerializeField] float pickIntCost;
    [SerializeField] float pickIntCostMult;

    [SerializeField] GameObject beeperMan;


    // Start is called before the first frame update
    void Start()
    {
        // number of beekeepers
        numBeepers = 0;

        // how much buying a new beekeeper costs and how much it goes up per purchase
        beepCost = 50.0f;
        beepCostMult = 1.2f;

        // number of new bees generated by beekeepers
        // cost of upgrading efficiency and how much it goes up per purchase
        beeped = 1;
        beepedMult = 1.1f;
        beepedCost = 50.0f;
        beepedCostMult = 1.2f;

        // timer keeping track of beekeeper interval
        beepTimer = 0.0f;

        // interval at which beekeepers generate new bees
        // cost of upgrading the beekeeper interval and how much it goes up per purchase
        pickInterval = 5.0f;
        pickIntMult = 0.02f;
        pickIntCost = 60.0f;
        pickIntCostMult = 1.25f;

    }

    // Update is called once per frame
    void Update()
    {
        // compare beekeeper timer to the interval
        // if its time to trigger the beekeeper bee generation, trigger that and reset timer
        beepTimer += Time.deltaTime;
        if (beepTimer > pickInterval)
        {
            triggerBeep();
            beepTimer = 0.0f;
        }
    }


    // BEEKEEPER UPGRADES //////////////////////////////////////////////////////////////////////////////////
    // creates a new beekeeper
    public void AddBeeper()
    {
        numBeepers++;
        Instantiate(beeperMan);
        Debug.Log("created beeper");
    }

    // upgrades beekeeper efficiency
    public void BeeperEfficiency()
    {

    }

    // upgrades beekeeper interval
    public void BeeperInterval()
    {

    }


    // HELPER FUNCTIONS ////////////////////////////////////////////////////////////////////////////////////
    // auto click trigger; generates more bees
    public void triggerBeep()
    {
        uint numBeeps;

        numBeeps = beeped * numBeepers;
        gameManager.totalBees += numBeeps;
        Debug.Log("beeped: " + numBeeps);

        // display text
        gameManager.beeCountText.text = "total bees: " + gameManager.totalBees;
    }
}
