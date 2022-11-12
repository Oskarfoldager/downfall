using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyai : MonoBehaviour
{
    public Transform player;
    public Transform self;
    public float speed;
    public float lengthbetween;
    public float radiusofattack;
    public float attackspeed = 20f;
    private float nextactiontime = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        movetowardsplayer();
        lengthbetween = Mathf.Sqrt((player.position.x - self.position.x) * (player.position.x - self.position.x));
    }
    void movetowardsplayer()
    {
        if (lengthbetween < radiusofattack)
        {
            attackplayer();
        }
        else
        {
            self.position = Vector3.MoveTowards(self.position, player.position, speed);
        }
    }
    void attackplayer()
    {
        if (Time.time > nextactiontime)
        {
            Debug.Log("attacking");
            nextactiontime += attackspeed;
        }
    }
}
