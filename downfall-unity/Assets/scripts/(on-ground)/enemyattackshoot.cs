using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyattackshoot : MonoBehaviour
{
    Animator animator;
    public float period = 20f;
    private float nextactiontime;
    public GameObject bullet;
    public enemyai enemyai;
    public Vector3 offset;

    // Start is called before the first frame update
    private void Start()
    {
        nextactiontime = Time.time + period;
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (enemyai.lenghtbetweenispositive)
        {
            offset = new Vector3(offset.x, offset.y, offset.z);
        }
        else
        {
            offset = new Vector3(offset.x * -1, offset.y, offset.z);
        }
        if (Time.time > nextactiontime)
        {
            if (enemyai.isattacking)
            {
                shoot();
                animator.Play("TankShoot");
                nextactiontime += period;
                Debug.Log("shooting");
            }   
                else if(!enemyai.isattacking)
                {
                    animator.Play("TankDrive");
                }
            
            nextactiontime += period;
        }
    }
    void shoot()
    {
        GameObject thisproj = Instantiate(bullet, transform.position + offset, transform.rotation);
        thisproj.GetComponent<bulletmotion>().enemyai = enemyai;
    }
}
