using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 playervector;
    public float movementspeed;
    public bool touchground;
    public BoxCollider2D bx2d;
    public Transform playertransform;
    public Collider2D whathit;
    public Vector2 velocity;
    public Vector2 jump;


    [SerializeField] private LayerMask groundlm;
    // Start is called before the first frame update
    void Start()
    {

    }






    //If the GameObject's name matches the one you suggest, output this message in the console




    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.D))
        {
            playertransform.position = new Vector3(playertransform.position.x + movementspeed, playertransform.position.y, playertransform.position.z);
            //rb.MovePosition(new Vector2(rb.position.x + (float)movementspeed, rb.position.y));
            playertransform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.A))
        {
            playertransform.position = new Vector3(playertransform.position.x + -movementspeed, playertransform.position.y, playertransform.position.z);
            //rb.MovePosition(new Vector2(rb.position.x - (float)movementspeed, rb.position.y));
            playertransform.eulerAngles = new Vector3(180f, 0f, 180f);
        }
        if (isgrounded() && Input.GetKey(KeyCode.Space) && touchground == false)
        {
            rb.AddForce(jump,ForceMode2D.Impulse);
        }




    }
    private bool isgrounded()
    {
        float extraheight = .02f;
        RaycastHit2D raycastHit = Physics2D.Raycast(bx2d.bounds.center, Vector2.down, bx2d.bounds.extents.y + extraheight, groundlm);
        Color raycolor;
        if (raycastHit.collider != null)
        {
            raycolor = Color.green;
            touchground = false;
        }
        else
        {
            raycolor = Color.red;
            touchground = true;
        }
        Debug.DrawRay(bx2d.bounds.center, Vector2.down * (bx2d.bounds.extents.y + extraheight));
        Debug.Log(raycastHit.collider);
        whathit = raycastHit.collider;
        Debug.Log(whathit + "hey");
        return raycastHit.collider != null;
    }
}
