using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HoneycoinClass : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    public float HCTotal;
    public float HCEarned;
    [SerializeField] float HCMult;
    [SerializeField] float HCEarnedInterval;
    [SerializeField] float HCEarnedTimer;

    [SerializeField] TextMeshProUGUI HCText;

    // Start is called before the first frame update
    void Start()
    {
        HCEarned = 0.0f;
        HCEarnedTimer = 0.0f;
        HCEarnedInterval = 10.0f;
        HCMult = 0.02f;
    }

    // Update is called once per frame
    void Update()
    {
        HCEarnedTimer += Time.deltaTime;
        if(HCEarnedTimer > HCEarnedInterval)
        {
            AddMoney();
            HCEarnedTimer = 0.0f;
            DisplayMoney();
        }
    }

    // counts current number of bees and converts it to money
    public void AddMoney()
    {
        HCEarned = gameManager.totalBees * 0.02f;
        Debug.Log("total bees: " + gameManager.totalBees);
        HCTotal += HCEarned;
    }

    public void DisplayMoney()
    {
        HCText.text = "total money: " + HCTotal.ToString();

    }

}
