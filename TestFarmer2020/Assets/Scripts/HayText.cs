using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HayText : MonoBehaviour
{
    public TextMeshProUGUI hayText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hayText.text = "Hay stack " + HayController.numberOfTheHay+"/40";
        print("Hay stack " + HayController.numberOfTheHay);
    }
}
