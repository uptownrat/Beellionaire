using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HBHClass : MonoBehaviour
{
    // variables go up here
    [SerializeField] GameManager gameManager;

    // hbh length upgrades
    [SerializeField] float length;
    // [SerializeField] float lengthMult;
    [SerializeField] float lengthCost;
    [SerializeField] float lengthCostMult;

    // keeps track of how long a hbh has been going
    float hbhTimer;

    // hbh efficiency upgrades
    [SerializeField] public float effic;
    // [SerializeField] float efficMult;
    [SerializeField] float efficCost;
    [SerializeField] float efficCostMult;

    // trigger interval upgrades
    float checkTimer;
    float triggerInterval;
    float triggerChance;

    // [SerializeField] float trigIntMult;
    [SerializeField] float trigIntCost;
    [SerializeField] float trigIntCostMult;

    // Start is called before the first frame update
    void Start()
    {
        // set default variables
        length = 10.0f;
        lengthCost = 100.0f;
        lengthCostMult = 1.3f;

        hbhTimer = 0.0f;

        effic = 2.0f;
        efficCost = 100.0f;
        efficCostMult = 1.5f;

        checkTimer = 0.0f;
        triggerInterval = 600.0f;
        triggerChance = 0.1f;

        trigIntCost = 100.0f;
        trigIntCostMult = 1.5f;
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
            if (checkTimer > triggerInterval)
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
            if (hbhTimer >= length)
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
        if (length <= 60.0f)
        {
            length += 2.0f;
            lengthCost = lengthCost * lengthCostMult;

            Debug.Log("hbh length = " + length);
        }

        // else, deactivate the button for the upgrade or something
    }

    // increases efficiency/raises hbh multiplier
    public void HBHEfficiency()
    {
        effic += 0.2f;
        efficCost = efficCost * efficCostMult;

        Debug.Log("hbh effic = " + effic);
    }

    // decrease hbh trigger check interval
    public void HBHTriggerInterval()
    {
        if (triggerInterval >= 300.0f)
        {
            triggerInterval -= 2.0f;
            trigIntCost = trigIntCost * trigIntCostMult;

            Debug.Log("trigger interval = " + triggerInterval);
        }
    }


    // HELPER FUNCTIONS ////////////////////////////////////////////////////////////////////////////////////

}
