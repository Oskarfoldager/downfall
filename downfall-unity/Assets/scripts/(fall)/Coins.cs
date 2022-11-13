using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
    public int coins;
    public Text text;
    int test;
    // Start is called before the first frame update
    void Start()
    {
        
    }
   
    // Update is called once per frame
    void Update()
    {
        text.text = ""+(coins);
        Debug.Log(coins);
    }
    private void OnTriggerEnter2D(Collider2D col)
   {
    Debug.Log("Hej "+ col.gameObject.tag);
    if(col.gameObject.tag == "coin"){
        coins += 1;
       Destroy(col.gameObject);
    }

   }

} 