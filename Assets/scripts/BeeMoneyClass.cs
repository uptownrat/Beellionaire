using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class beeMoney : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    public float totalBeeMoney;
    public float earnedBeeMoney;
    [SerializeField] float beeMoneyMult;
    [SerializeField] float earnMoneyInterval;
    [SerializeField] float earnMoneyTimer;

    [SerializeField] TextMeshProUGUI beeMoneyText;

    // Start is called before the first frame update
    void Start()
    {
        earnedBeeMoney = 0.0f;
        earnMoneyTimer = 0.0f;
        earnMoneyInterval = 10.0f;
        beeMoneyMult = 0.02f;
    }

    // Update is called once per frame
    void Update()
    {
        earnMoneyTimer += Time.deltaTime;
        if(earnMoneyTimer > earnMoneyInterval)
        {
            AddMoney();
            earnMoneyTimer = 0.0f;
            DisplayMoney();
        }
    }

    // counts current number of bees and converts it to money
    public void AddMoney()
    {
        earnedBeeMoney = gameManager.totalBees * 0.02f;
        Debug.Log("total bees: " + gameManager.totalBees);
        totalBeeMoney += earnedBeeMoney;
    }

    public void DisplayMoney()
    {
        beeMoneyText.text = "total money: " + totalBeeMoney.ToString();

    }

}
