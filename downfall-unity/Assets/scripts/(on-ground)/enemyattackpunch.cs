using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyattackpunch : MonoBehaviour
{
    public float period = 20f;
    private float nextactiontime;
    public GameObject weapon;
    public enemyai enemyai;
    public Vector3 offset;

    // Start is called before the first frame update
    private void Start()
    {
        nextactiontime = Time.time + period;
    }
    void Update()
    {
        if (enemyai.lenghtbetweenispositive)
        {
            offset = new Vector3(Mathf.Sqrt(offset.x * offset.x), offset.y, offset.z);
        }
        else
        {
            offset = new Vector3(Mathf.Sqrt(offset.x * offset.x) * -1, offset.y, offset.z);
        }

        if (Time.time > nextactiontime)
        {
            if (enemyai.isattacking)
            {
                punch();
                nextactiontime += period;
                Debug.Log("attacking");
            }
            nextactiontime += period;
        }
    }
    void punch()
    {
        GameObject thisproj = Instantiate(weapon, transform.position + offset, transform.rotation);
        thisproj.GetComponent<bulletmotion>().enemyai = enemyai;
    }
}
