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
    public int howmanytospawn;
    protected int i = 0;
    public int dificulty1to3;
    public List<GameObject> enemys = new List<GameObject>() {};
    public void Start()
    {
        switch (dificulty1to3)
        {
            case 1:
                enemys = new List<GameObject>() { enemy1};
                break;
            case 2:
                enemys = new List<GameObject>() { enemy1, enemy2};
                break;
            case 3:
                enemys = new List<GameObject>() { enemy1, enemy2, enemy3 };
                break;
        }

        

        

        
    }
    // Start is called before the first frame update
    void Update()
    {
        if (Time.time > nextactiontime)
        {
            if (i < howmanytospawn)
            {
                Debug.Log("Attempting to spawn enemy");
                GameObject thisproj = Instantiate(enemys[Random.Range(0, enemys.Count)], transform.position, transform.rotation);
                nextactiontime += period;
                i++;
            }
        }



    }
}
