using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreClass : MonoBehaviour
{
    [SerializeField] HoneycoinClass coins;

    // bpc
    [SerializeField] StoreItemClass bpcButton;


    //// beepers
    [SerializeField] StoreItemClass addBeeperButton;
    [SerializeField] StoreItemClass beeperEfficButton;
    [SerializeField] StoreItemClass beeperIntervalButton;


    //// hbh
    [SerializeField] StoreItemClass hbhLengthButton;
    [SerializeField] StoreItemClass hbhEfficButton;
    [SerializeField] StoreItemClass hbhIntervalButton;


    //// roids
    [SerializeField] StoreItemClass buyRoidsButton;
    [SerializeField] StoreItemClass roidEfficButton;


    // Start is called before the first frame update
    void Start()
    {
        bpcButton.setStoreItemClass(10, 0.5f, 10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
