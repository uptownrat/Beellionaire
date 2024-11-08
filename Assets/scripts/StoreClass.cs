using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreClass : MonoBehaviour
{
    /* 
       UPGRADES TODO:
        - bees per click (increasing efficiency)
        - beekeepers
            - hire beekeepers
            - decrease beeping interval
            - increase number of bees beeped
        - beeroids
            - increase cost to buy roids
                - decreases effectiveness of roids with each purchase
            - research (increase) effectiveness of roids
            - increase cost to research
        - hapbee hour
            - increase hbh effectiveness
            - decrease interval between hbh checks


        HAPBEE HOUR NOTES
        - decrease time between hours (base chance stays the same, interval between
            when you can trigger them decreases)
        - you can gamble more often basically
        - base chance to trigger hbh stays the same
            - ? if failed, chance can be increased a little
    */

    [SerializeField] GameManager gameManager;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
