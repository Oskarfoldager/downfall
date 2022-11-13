using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pos : MonoBehaviour
{
    public GameObject Flyver;
    public float speed;
    public bool bothit;
    // Start is called before the first frame update
    void Start()
    {
        bothit = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (bothit == true)
        {
            SceneManager.LoadScene(0);
        }
    }
    public void OnTriggerEnter2D(Collider2D col)
    {

        bothit = true;
        //chair.transform.Translate (Vector3.right* speed * Time.deltaTime);
    }


    // void OnTriggerEnter2D(Collider2D col)

}
