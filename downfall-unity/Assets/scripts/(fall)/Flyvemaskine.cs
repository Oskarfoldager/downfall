using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flyvemaskine : MonoBehaviour
{
      public GameObject Flyver;
     public float speed;
     public bool gothit;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
   void Update() 
    {
      if(gothit == true)
      {
        Flyver.transform.position = new Vector3(Flyver.transform.position.x + speed,Flyver.transform.position.y,Flyver.transform.position.z);
      }
    }
   public void OnTriggerEnter2D(Collider2D col)
   {
        gothit = true;
             //chair.transform.Translate (Vector3.right* speed * Time.deltaTime);
   }
               
   
   // void OnTriggerEnter2D(Collider2D col)
    
}
