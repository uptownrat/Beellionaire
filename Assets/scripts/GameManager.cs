using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] BeeClass newBee;
    private float totalBees;
    private float totalSpam;
    private int visibleBeeCount; //limits number of bees onscreen so it doesn't get crazy
    [SerializeField] TextMeshProUGUI beeCountText;
    [SerializeField] TextMeshProUGUI spamCountText;

    LinkedList<BeeClass> beeList = new LinkedList<BeeClass>();

    // Start is called before the first frame update
    void Start()
    {
        totalBees = 0;
        visibleBeeCount = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddBees()
    {
        totalBees++;
        totalSpam = totalBees / 300;
        // visibleBeeCount++;

        // limits amount of bees on screen
        while (beeList.Count >= 10)
        {
            beeList.RemoveFirst();
        }

        if (beeList.Count < 10)
        {
            //create another bee
            Instantiate(newBee);
            beeList.AddLast(newBee);
        }

        beeCountText.text = totalBees.ToString();
        spamCountText.text = totalSpam.ToString();
    }
}
