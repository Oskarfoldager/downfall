using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public Transform bar;
    // Start is called before the first frame update
    private void Start()
    {
       
    }
    public void SetSize()   
    {
         bar.localScale = new Vector2(Bounce.lives/500, 1f);
         Debug.Log(Bounce.lives/500);
    }

    // Update is called once per frame
    void Update()
    {
        SetSize();
    }
}
