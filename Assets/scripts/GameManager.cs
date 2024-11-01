using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] BeeClass newBee;
    public float totalBees;
    private float totalSpam;
    private int visibleBeeCount; //limits number of bees onscreen so it doesn't get crazy
    [SerializeField] public TextMeshProUGUI beeCountText;
    [SerializeField] TextMeshProUGUI spamCountText;

    protected uint beesPerClick;
    [SerializeField] float BPC_cost;
    [SerializeField] float BPC_mult;
    [SerializeField] float BPC_multCost;
    private int numBPCClicks;

    // Start is called before the first frame update
    void Start()
    {
        totalBees = 0;
        visibleBeeCount = 0;
        numBPCClicks = 0;

        beesPerClick = 1;
        BPC_cost = 10.0f;
        BPC_mult = 1.1f;
        BPC_multCost = 1.2f;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddBees()
    {
        totalBees += beesPerClick;
        totalSpam = totalBees / 300;
        Instantiate(newBee);
        // visibleBeeCount++;


        beeCountText.text = "total bees: " + totalBees.ToString();
        spamCountText.text = "spam cans: " + totalSpam.ToString();
    }

    public void BPC()
    {
        numBPCClicks++;
        beesPerClick = (uint)((beesPerClick + 1) * BPC_mult);
        BPC_cost = BPC_cost * BPC_multCost;

        Debug.Log("bees per click: " + beesPerClick);
        Debug.Log("bpc upgrade cost: " + BPC_cost);
        Debug.Log("Number of ugrades: " + numBPCClicks);
    }
}
