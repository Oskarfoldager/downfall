using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class buyfirerate : MonoBehaviour
{
    public float currentprice = 5;
    public static float coins = 100;
    public Text coiners;
    public Text pricers;
    public void buythefirrate()
    {
        if (coins > currentprice)
        {
            coins -= currentprice;
            raisetheprice();
        }
        else
        {

        }
    }
    public void raisetheprice()
    {
        currentprice = Mathf.Round(currentprice*currentprice*0.6f);
    }
    private void Update()
    {
        coiners.text = "you have " + coins + " coins";
        pricers.text = "the price for firerate " + currentprice + " coins";
    }
}
