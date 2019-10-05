using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class feathers : MonoBehaviour
{


    private int feath = 25;
    public Text featherText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        featherText.text = "FEATHERS: " + feath;

        if (Input.GetKeyDown(KeyCode.Space)) {
            feath--;
        }
    }
}
