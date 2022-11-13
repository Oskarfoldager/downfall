using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Text text;
    public int HealthPrize;
    public int HealthAmount;
    public int Money;
    public int Healthy;
    
    
    void Start()
    {
        HealthPrize = 10;
        HealthAmount = 100;
    }
    void Update()
    {
       // Healthy = Bounce.lives;
        Money = Coins.coins;
        text.text = ""+(HealthAmount, + HealthPrize, + Money);
    }
    public void HealthVoid()
    {
        if(Coins.coins>HealthPrize) 
        {
            Coins.coins -= HealthPrize;
            HealthPrize += 5;
            Bounce.lives += HealthAmount;
            HealthAmount += 20;
           
        }
    }

}
