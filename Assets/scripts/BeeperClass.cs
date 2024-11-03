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
        numBeepers = 0;

        beepCost = 50.0f;
        beepCostMult = 1.2f;

        beeped = 1;
        beepedMult = 1.1f;
        beepedCost = 50.0f;
        beepedCostMult = 1.2f;

        beepTimer = 0.0f;

        pickInterval = 5.0f;
        pickIntMult = 0.02f;
        pickIntCost = 60.0f;
        pickIntCostMult = 1.25f;

    }

    // Update is called once per frame
    void Update()
    {
        beepTimer += Time.deltaTime;
        if (beepTimer > pickInterval)
        {
            triggerBeep();
            beepTimer = 0.0f;
        }
    }

    // auto click trigger
    public void triggerBeep()
    {
        uint numBeeps;
        numBeeps = beeped * numBeepers;
        Debug.Log("beeped: " +  numBeeps);
        gameManager.totalBees += numBeeps;
        // take intbeespicked = 1*numbeeper * beepedmult
        gameManager.beeCountText.text = "total bees: " + gameManager.totalBees;
    }

    public void AddBeeper()
    {
        numBeepers++;
        Instantiate(beeperMan, new Vector3(0.0f, -4.5f, 0.0f), Quaternion.identity);
        Debug.Log("created beeper");
    }
}
