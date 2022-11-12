using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CarController : MonoBehaviour
{
    [SerializeField] private float _carSpeed;
    [SerializeField] private float _rotationSpeed = 200;



    Vector3 _moveVector;

    // Start is called before the first frame update
    void Start()
    {
        var carC = GetComponentInChildren<MeshCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).deltaPosition.y > 20 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {

           


        }
    }
}
