using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthBar : MonoBehaviour
{
    public Transform bar;
    private float woow;
    // Start is called before the first frame update
    private void Start()
    
    {
       
    }
    public void SetSize()   
    {
        if(woow > 0)
        {
         bar.localScale = new Vector2(Bounce.lives/500, 1f);
         Debug.Log(Bounce.lives/500);
        }else
        {
            SceneManager.LoadScene(2);
        }
    }

    // Update is called once per frame
    void Update()
    {
        woow = Bounce.lives/500;
        SetSize();
    }
}
