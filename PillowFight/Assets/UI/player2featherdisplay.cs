using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player2featherdisplay : MonoBehaviour
{
    private int feath2 = 25;
    public Text featherText2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        featherText2.text = "FEATHERS: " + feath2;

        if (Input.GetKeyDown(KeyCode.Tab)) {
            feath2--;
        }
    }
}
