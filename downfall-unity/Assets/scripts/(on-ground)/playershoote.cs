using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class playershoote : MonoBehaviour
{
    public bool canshoot;
    public float attackspeed = 20f;
    private float nextactiontime;
    public Text canshoots;
    public GameObject bullet;
    public Vector3 offset;
    void Update()
    {
        if (Time.time > nextactiontime)
        {
            canshoot = true;
            nextactiontime += attackspeed;
        }
        if (Input.GetKey(KeyCode.E))
        {
            
            if(canshoot == true)
            {
                GameObject thisproj = Instantiate(bullet, transform.position + offset, transform.rotation);
                canshoot = false;
            }
        }
        if(canshoot == true)
        {
            canshoots.text = "you can shoot";
        }
        else
        {
            canshoots.text = "realoding";
        }



    }
}
