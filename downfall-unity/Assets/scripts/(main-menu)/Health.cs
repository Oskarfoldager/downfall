using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int HealthPrize;
    // Start is called before the first frame update
    void Start()
    {
        HealthPrize = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if(Coins.coins>HealthPrize)
        {
            Coins.coins -= HealthPrize;
        }
    }
}
