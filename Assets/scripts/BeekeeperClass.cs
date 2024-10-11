using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beekeeper : MonoBehaviour
{
    int numBeekeepers;
    float beepCost;
    [SerializeField] float beepCostMult;

    uint beesPicked;
    [SerializeField] float beesPickedMult;
    [SerializeField] float beesPickedCost;
    [SerializeField] float beesPickedCostMult;

    int pickInterval;
    [SerializeField] float pickIntMult;
    [SerializeField] float pickIntCost;
    [SerializeField] float pickIntCostMult;

    int frameCount;


    // Start is called before the first frame update
    void Start()
    {
        numBeekeepers = 0;

        beepCost = 50.0f;
        beepCostMult = 1.2f;

        beesPicked = 1;
        beesPickedMult = 1.1f;
        beesPickedCost = 50.0f;
        beesPickedCostMult = 1.2f;

        pickInterval = 10000;
        pickIntMult = 0.02f;
        pickIntCost = 60.0f;
        pickIntCostMult = 1.25f;

        frameCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        frameCount++;
        if (frameCount >= 1000)
        {
            // triggerBeePick();
            frameCount = 0;
        }
    }

    public void triggerBeePick()
    {
        // stuff here
    }
}
