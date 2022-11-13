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
                shoot();
                nextactiontime += period;
                Debug.Log("shooting");
            }   
                
            nextactiontime += period;
        }
    }
    void shoot()
    {
        animator.Play("Shootershot"); 
        animator.Play("TankShoot");
        GameObject thisproj = Instantiate(bullet, transform.position + offset, transform.rotation);
        thisproj.GetComponent<bulletmotion>().enemyai = enemyai;
    }
}
