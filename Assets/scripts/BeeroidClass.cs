using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeroidClass : MonoBehaviour
{
    // variables go up here
    [SerializeField] GameManager gameManager;
    [SerializeField] HoneycoinClass playerMoney;

    public StoreItemClass research = new StoreItemClass();
    public StoreItemClass beeroid = new StoreItemClass();
    public StoreItemClass effic = new StoreItemClass();

    float roidTimer;
    float roidLength;

    int counter;

    // Start is called before the first frame update
    void Start()
    {
        // set default variables
        counter = 0;

        roidLength = 10.0f;
        roidTimer = 0.0f;

        //effic = 100.0f;
        //efficMult = 0.75f;

        effic.SetUpgrade(100.0f, 100.0f, 0.75f);
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

            // change efficiency based on how many times youve bought roids
            effic.upgradeF = 100 * Mathf.Pow(effic.upgradeMult, counter);
            counter++;

            // TO-DO: change costs and such
        }

        // TO-DO: change the sprite or something to show the button wont work if roids r active
    }

    // increases efficiency/raises roid multiplier
    public void ResearchRoids()
    {
        // if counter is 0, do nothing
        // but if counter is > 0, bring it down by 1
        if (counter > 0)
        {
            counter--;

            // change cost and such
        }
        else
        {
            counter = 0;
        }
    }


    // HELPER FUNCTIONS ////////////////////////////////////////////////////////////////////////////////////

}
