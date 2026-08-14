using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StoreItemClass : MonoBehaviour
{
    float cost;
    [SerializeField] TextMeshProUGUI costDisplay;
    float costMult;
    float baseCost;
    int timesBought;

    [SerializeField] HoneycoinClass honeycoin;

    // Start is called before the first frame update
    void Start()
    {
        cost = 0;
        costMult = 0;
        baseCost = 0;
        timesBought = 0;
    }

    public void setStoreItemClass(float c, float cm)
    {
        baseCost = c;
        cost = baseCost;
        costMult = cm;
        displayStoreItem();
    }

    public void Upgrade()
    {
        // exit if not enough honeycoin
        if (honeycoin.HCTotal < cost)
        {
            Debug.Log("not enough honeycoin to buy upgrade");
        }
        else
        {
            timesBought++;

            // subtract cost from HC total
            honeycoin.SubtractMoney(cost);

            // calculate new price
            cost = baseCost * costMult * timesBought;
            displayStoreItem();
        }
    }

    private void displayStoreItem()
    {
        costDisplay.text = cost.ToString();
    }
}
