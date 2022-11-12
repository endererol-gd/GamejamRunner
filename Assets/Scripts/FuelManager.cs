using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelManager : MonoBehaviour
{
    public float currentFuel = 100f;
    public Text fuelDisplay;
    public bool isCarMoving;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fuelDisplay.text = "Fuel:" + currentFuel;
    }
}
