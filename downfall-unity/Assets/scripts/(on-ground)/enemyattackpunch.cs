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
    Animator animator;
    // Start is called before the first frame update
    private void Start()
    {
        animator = GetComponent<Animator>();
        nextactiontime = Time.time + period;
    }
    void Update()
    {
        if (enemyai.lenghtbetweenispositive)
        {
            offset = new Vector3(offset.x, offset.y, offset.z);
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        else
        {
            transform.eulerAngles = new Vector3(180f, 0f, 180f);
            offset = new Vector3(offset.x * -1, offset.y, offset.z);
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
        animator.Play("StabbermanAttack");
        GameObject thisproj = Instantiate(weapon, transform.position + offset, transform.rotation);
        thisproj.GetComponent<bulletmotion>().enemyai = enemyai;
    }
}
