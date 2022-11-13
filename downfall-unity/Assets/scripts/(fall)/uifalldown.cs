using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class uifalldown : MonoBehaviour
{
    public Transform c;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = ""+ (Mathf.Round(c.position.y + 841));
    }
}
