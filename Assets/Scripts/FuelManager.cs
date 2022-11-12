using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelManager : MonoBehaviour
{
    public float currentFuel = 100f;
    public float Decreasefuel = 0.001f;
    public Text fuelDisplay;
    float countDown = 1f;
    public bool isCarMoving;

    // Start is called before the first frame update
    void Start()
    {
        countDown = Decreasefuel;
        isCarMoving = true;
    }

    // Update is called once per frame
    void Update()
    {

        if(isCarMoving)
        {
            if(countDown > 0)
            {
                countDown -= Time.deltaTime /550;
            }
            else
            {
                countDown = Decreasefuel;
                currentFuel -= 1f;
            }
            currentFuel -= countDown;
        }

        Mathf.Round(currentFuel);

        fuelDisplay.text = "Fuel:" + currentFuel;
    }
}
