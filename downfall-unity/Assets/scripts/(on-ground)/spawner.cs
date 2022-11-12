using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject playerr;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public float period = 20f;
    private float nextactiontime = 0;

    // Start is called before the first frame update
    void Update()
    {
        List<GameObject> enemys = new List<GameObject>() { enemy1, enemy2, enemy3 };
        if (Time.time > nextactiontime)
        {
            Debug.Log("Attempting to spawn enemy");
            GameObject thisproj = Instantiate(enemys[Random.Range(0, 3)], transform.position, transform.rotation);
            nextactiontime += period;
        }


    }
}
