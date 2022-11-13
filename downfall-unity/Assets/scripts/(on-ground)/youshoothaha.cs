using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class youshoothaha : MonoBehaviour
{
    public Transform arm;
    public float bulletspeed;
    public GameObject thisthing;
    // Start is called before the first frame update
    void Start()
    {
        transform.eulerAngles = (ownbullet.eluleryes);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * Time.deltaTime * bulletspeed;
        if(Time.time > 10)
        {
            Destroy(thisthing);
        }
    }
}
