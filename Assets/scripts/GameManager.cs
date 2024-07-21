using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] BeeClass newBee;
    private float totalBees;
    private int visibleBeeCount; //limits number of bees onscreen so it doesn't get crazy
    [SerializeField] TextMeshProUGUI beeCountText;
    
    // Start is called before the first frame update
    void Start()
    {
        totalBees = 0;
        visibleBeeCount = 0;
    }

    //// Update is called once per frame
    //void Update()
    //{

    //}

    public void AddBees()
    {
        totalBees++;
        visibleBeeCount++;

        if(visibleBeeCount <= 1000)
        {
            //create another bee
            Instantiate(newBee);
            
        }

        beeCountText.text = totalBees.ToString();
    }
}
