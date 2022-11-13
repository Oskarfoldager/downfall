using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletmotion : MonoBehaviour
{
    public float movementspeed;
    public enemyai enemyai;
    public bool isrevesed;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("bullet start");
        if (enemyai.lenghtbetweenispositive)
        {
            isrevesed = false;
        }
        else
        {
            isrevesed = true;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isrevesed)
        {
            transform.position = new Vector3(transform.position.x + -movementspeed, transform.position.y, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(transform.position.x + movementspeed, transform.position.y, transform.position.z);
        }

    }
}
