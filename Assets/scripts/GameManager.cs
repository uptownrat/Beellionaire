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

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // calculates player clicking bees
    public void AddBees()
    {
        totalBees += beesPerClick;
        totalSpam = totalBees / 300;
        Instantiate(newBee);
        // visibleBeeCount++;


        beeCountText.text = "total bees: " + totalBees.ToString();
        spamCountText.text = "spam cans: " + totalSpam.ToString();
    }

    
}
