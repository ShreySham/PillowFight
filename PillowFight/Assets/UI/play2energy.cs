using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class play2energy : MonoBehaviour
{
    private int ener2 = 100;
    public Text energyText2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        energyText2.text = "ENERGY: " + ener2;

        if (Input.GetKeyDown(KeyCode.Space)) {
            ener2--;
        }
    }
}
