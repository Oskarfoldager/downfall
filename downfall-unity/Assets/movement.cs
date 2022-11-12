using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {

            moveleft();

        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {

            moveright();

        }
    }


    public void moveright()
    {
        rb.AddForce(new Vector2(speed,0),ForceMode2D.Impulse);
      //  rb.MovePosition(new Vector3(rb.position.x + (float)speed, rb.position.y));
        transform.eulerAngles = new Vector3(0f, 180f, 0f);
    }
    public void moveleft()
    {
        rb.AddForce(new Vector2(-speed, 0), ForceMode2D.Impulse);
        //    rb.MovePosition(new Vector3(rb.position.x - (float)speed, rb.position.y));
        transform.eulerAngles = new Vector3(0f, 0f, 0f);
    }
}
