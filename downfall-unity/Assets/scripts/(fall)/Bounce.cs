using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    Rigidbody2D rb;
    public Vector3 LastVelocity;
    public static float lives = 500;
    [SerializeField] private HealthBar healthBar;
    
    // Start is called before the first frame update
    void Start()
    {
        /*
        float health = 1f;
        healthBar.SetSize(health);
        health = lives/500;
        */
        rb = GetComponent<Rigidbody2D>(); 
        
    }

    // Update is called once per frame
    void Update()
    {
        
        LastVelocity = rb.velocity;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("and it is "+ LastVelocity.y);
        var speed = LastVelocity.magnitude;
        var direction = Vector3.Reflect(LastVelocity.normalized, collision.contacts[0].normal);
        rb.velocity = direction * Mathf.Max(speed, 0f);
        lives -= Mathf.Sqrt(LastVelocity.y*LastVelocity.y);
    }
}
