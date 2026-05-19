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

    // Start is called before the first frame update
    void Start()
    {
        costDisplay.text = baseCost.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setStoreItemClass(float c, float cm, float bc)
    {
        cost = c;
        costMult = cm;
        baseCost = bc;
    }
}
