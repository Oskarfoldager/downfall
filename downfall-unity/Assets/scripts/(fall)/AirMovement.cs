using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirMovement : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public Vector2 leftmovement;
    public Vector2 rightmovement;
    public float Movementspeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKey(KeyCode.A))
       {
        rb2d.AddForce(leftmovement,ForceMode2D.Impulse) ;
       } 
              if(Input.GetKey(KeyCode.D))
       {
        rb2d.AddForce(rightmovement,ForceMode2D.Impulse);
       } 
    }
}
