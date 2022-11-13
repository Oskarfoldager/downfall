using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int HealthPrize;
    public int HealthAmount;
    // Start is called before the first frame update
    void Start()
    {
        HealthPrize = 10;
        HealthAmount = 100;
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
