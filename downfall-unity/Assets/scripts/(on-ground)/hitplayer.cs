using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hitplayer : MonoBehaviour
{
    public int health;
    public int tankdamage;
    public int shootiedamage;
    public int handdamage;
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
            health-=tankdamage; 
            Destroy(col.gameObject); 
        }
        else if (col.gameObject.tag == "bulletfromshootie")
        { 
            health-=shootiedamage; 
            Destroy(col.gameObject);
        }else if(col.gameObject.tag == "bulletfromtank")
        {
            health-=handdamage;
            Destroy(col.gameObject);
        }
    }
}
