using System.Numerics;
using UnityEngine;
using UnityEngine.UI;
using Quaternion = UnityEngine.Quaternion;

public class Fuel : MonoBehaviour
{
    [SerializeField] Color[] FuelColors;
    [SerializeField] GameObject Pointer;

    public Image FuelBar;

    [Range(1, 100)] public float fuel;
    [Range(-180, 180)] float Rotate;
    float maxFuel = 100;
    float lerpSpeed;

    private void Start()
    {
        fuel = maxFuel;
    }

    private void Update()
    {
        if (fuel > maxFuel) fuel = maxFuel;

        lerpSpeed = 3f * Time.deltaTime;


        ExperienceBarFiller();
        FueleColorChange();
        FuelPointerRotate();
    }

    void FueleColorChange()
    {
        Color healthColor = Color.Lerp(Color.red, Color.green, (fuel / maxFuel));
        FuelBar.color = healthColor;
    }

    void ExperienceBarFiller()
    {
        FuelBar.fillAmount = Mathf.Lerp(FuelBar.fillAmount, (fuel / maxFuel), lerpSpeed);
    }

    void FuelPointerRotate()
    {
        Rotate = ((fuel * 360 )/100);
        int Rotateint = (int)Rotate;
        Debug.Log(Rotate);


        Pointer.transform.rotation = Quaternion.Slerp(Pointer.transform.rotation, Pointer.transform.rotation, Rotateint) ;
    }

}
