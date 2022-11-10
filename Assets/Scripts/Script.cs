using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Script : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider test;
    void Start()
    {
        test = GameObject.Find("Casual1_Body").GetComponent<Slider>();
        //test.value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //test.value = 100;
        Debug.Log("Resultado = " + test); 
    }
}
