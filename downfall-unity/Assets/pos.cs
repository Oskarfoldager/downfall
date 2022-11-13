using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pos : MonoBehaviour
{

    public void OnTriggerEnter2D(Collider2D col)
    {

        SceneManager.LoadScene(7);
        //chair.transform.Translate (Vector3.right* speed * Time.deltaTime);
    }


    // void OnTriggerEnter2D(Collider2D col)

}
