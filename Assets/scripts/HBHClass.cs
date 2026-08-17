using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HBHClass : MonoBehaviour
{
    // variables go up here
    [SerializeField] GameManager gameManager;

    public StoreItemClass length = new StoreItemClass();

    // keeps track of how long a hbh has been going
    float hbhTimer;

    public StoreItemClass effic = new StoreItemClass();

    // trigger interval upgrades
    float checkTimer;
    float triggerChance;
    
    public StoreItemClass triggerInterval = new StoreItemClass();

    // Start is called before the first frame update
    void Start()
    {

        length.SetUpgrade(10.0f, 10.0f, 2.0f);
        length.SetCost(100.0f, 100.0f, 1.3f);

        hbhTimer = 0.0f;

        effic.SetUpgrade(2.0f, 2.0f, 0.2f);
        effic.SetCost(100.0f, 100.0f, 1.5f);

        checkTimer = 0.0f;
        triggerChance = 0.1f;

        triggerInterval.SetUpgrade(600.0f, 600.0f, 2.0f);
        triggerInterval.SetCost(100.0f, 100.0f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        // if hbh is Not active, work towards activating it
        if (gameManager.hbhActive == false && gameManager.beeroidsActive != true)
        {
            // check hbh timer against the hbh trigger interval
            // if check succeeds, trigger hbh
            // if check fails, increase odds of success for next time

            checkTimer += Time.deltaTime;
            if (checkTimer > triggerInterval.upgradeF)
            {
                float rand = Random.Range(0.0f, 1.0f);
                if (rand <= triggerChance)
                {
                    // trigger hbh
                    gameManager.hbhActive = true;
                    triggerChance = 0.1f;

                    Debug.Log("hbh started");
                }
                else
                {
                    triggerChance += 0.1f;

                    Debug.Log("hbh failed");
                }

                checkTimer = 0.0f;
            }
        }

        // whether hbhActive is true or not, but beeroids are true, turn off hbh
        // reset hbh stuff back to default so no timers tick up or anything
        else if (gameManager.beeroidsActive == true)
        {
            gameManager.hbhActive = false;

            hbhTimer = 0.0f;
            checkTimer = 0.0f;
            triggerChance = 0.1f;
        }

        // if hbh Is active, work towards deactivating it
        else
        {
            hbhTimer += Time.deltaTime;
            if (hbhTimer >= length.upgradeF)
            {
                // turn off hbh
                gameManager.hbhActive = false;
                hbhTimer = 0.0f;

                Debug.Log("hbh stopped");
            }
        }
        
    }


    // HBH UPGRADES //////////////////////////////////////////////////////////////////////////////////
    // increases how long hbh lasts
    public void HBHLength()
    {
        if (length.upgradeF <= 60.0f)
        {
            length.upgradeF += length.upgradeMult;
            length.Purchase();

            Debug.Log("hbh length = " + length.upgradeF);
        }

        // else, deactivate the button for the upgrade or something
    }

    // increases efficiency/raises hbh multiplier
    public void HBHEfficiency()
    {
        effic.upgradeF += effic.upgradeMult;
        effic.Purchase();

        Debug.Log("hbh effic = " + effic.upgradeF);
    }

    // decrease hbh trigger check interval
    public void HBHTriggerInterval()
    {
        if (triggerInterval.upgradeF >= 300.0f)
        {
            triggerInterval.upgradeF -= triggerInterval.upgradeMult;
            triggerInterval.Purchase();

            Debug.Log("trigger interval = " + triggerInterval);
        }
    }


    // HELPER FUNCTIONS ////////////////////////////////////////////////////////////////////////////////////

}
