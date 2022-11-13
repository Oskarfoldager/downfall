using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class hitplayer : MonoBehaviour
{
    public int health;
    public int tankdamage;
    public int shootiedamage;
    public int handdamage;
    [SerializeField] private HealthBar healthBar;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            //go to main scene
            SceneManager.LoadScene(2);
        }
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "bulletfromtank") 
        { 
            Bounce.lives-=tankdamage; 
            Destroy(col.gameObject); 
        }
        else if (col.gameObject.tag == "bulletfromshootie")
        {
            Bounce.lives -= shootiedamage; 
            Destroy(col.gameObject);
        }else if(col.gameObject.tag == "bulletfromhand")
        {
            Bounce.lives -= handdamage;
            Destroy(col.gameObject);
        }
    }
}
