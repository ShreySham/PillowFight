using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class energydisplay : MonoBehaviour
{
    private int ener = 25;
    public Text energyText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        energyText.text = "ENERGY: " + ener;

        if (Input.GetKeyDown(KeyCode.Escape)) {
            ener--;
        }
    }
}
