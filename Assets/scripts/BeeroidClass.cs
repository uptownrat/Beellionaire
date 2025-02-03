using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeroidClass : MonoBehaviour
{
    // variables go up here
    [SerializeField] GameManager gameManager;
    [SerializeField] beeMoney playerMoney;

    float beeroidCost;
    float beeroidCostMult;

    public float effic;
    float efficDecMult;
    float efficIncMult;     // keep locked
    float efficIncCost;
    float efficIncCostMult;

    float roidTimer;
    float roidLength;

    uint counter;

    // Start is called before the first frame update
    void Start()
    {
        // set default variables
        counter = 0;

        roidLength = 10.0f;
        roidTimer = 0.0f;

        effic = 100.0f;
    }

    // Update is called once per frame
    void Update()
    {
        // if beeroids true then check timer against length
        // turn beeroids off and reset stuff if timer >= length
        if (gameManager.beeroidsActive == true)
        {
            roidTimer += Time.deltaTime;
            if (roidTimer >= roidLength)
            {
                gameManager.beeroidsActive = false;
                roidTimer = 0.0f;
                Debug.Log("Beeroids off");
            }
        }
    }


    // ROIDS UPGRADES //////////////////////////////////////////////////////////////////////////////////
    // buy some roids
    public void BuyRoids()
    {
        if (gameManager.beeroidsActive == false)
        {
            // force hbh off and replace it with beeroids
            gameManager.beeroidsActive = true;
            if (gameManager.hbhActive == true)
            {
                gameManager.hbhActive = false;
            }

            // change costs and mults and stuff

            // effic = 100 * Mathf.Pow(0.75, counter);
            // bring counter up by 1

        }

        // TO-DO: change the sprite or something to show the button wont work if true
    }

    // increases efficiency/raises roid multiplier
    public void ResearchRoids()
    {
        // if counter is 0, do nothing
        // but if counter is > 0, bring it down by 1
    }


    // HELPER FUNCTIONS ////////////////////////////////////////////////////////////////////////////////////

}
