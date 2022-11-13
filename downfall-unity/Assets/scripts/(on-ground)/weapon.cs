using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public GameObject thisthing;
    public int timetodie;
    public float period = 20f;
    private float nextactiontime;

    // Start is called before the first frame update
    void Start()
    {
        nextactiontime = Time.time + period;

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextactiontime)
        {
            Destroy(thisthing);
        }

    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "player") { Destroy(thisthing); }
    }
}
