using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class buyhealth : MonoBehaviour
{
    public float currentpriceh = 5;
    public Text pricersh;
    public void buythehealth()
    {
        if (buyfirerate.coins > currentpriceh)
        {
            buyfirerate.coins -= currentpriceh;
            raisethepriceh();
        }
        else
        {

        }
    }
    public void raisethepriceh()
    {
        currentpriceh = Mathf.Round(currentpriceh*currentpriceh*0.6f);
    }
    private void FixedUpdate()
    {
        pricersh.text = "the price for health " + currentpriceh + " coins";
    }
}
