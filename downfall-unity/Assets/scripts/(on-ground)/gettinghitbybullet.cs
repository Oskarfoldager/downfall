using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gettinghitbybullet : MonoBehaviour
{
    public int health;
    public GameObject thisthing;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            Destroy(thisthing);
            points.p++;
        }
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "bulletfromplayer") { health--; Destroy(col.gameObject); }
    }
}
