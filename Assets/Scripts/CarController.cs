using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CarController : MonoBehaviour
{
    [SerializeField] private float _carSpeed;
    [SerializeField] private float _maxSpeed;

    [SerializeField] private float steerAngle;

    [SerializeField] private float _rotationSpeed = 200;

    float dragAmount = 0.99f;

    [SerializeField] private float _carTraction;

    Vector3 _moveVector;
    Vector3 _rotVector;

    public FixedJoystick joyStick;

    Rigidbody rb;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        _moveVector.x = joyStick.Horizontal;
        _moveVector.y = joyStick.Vertical;

        Vector3 carmove = new Vector3(_moveVector.x, 0, _moveVector.y);
        rb.MovePosition(rb.position + carmove * _carSpeed * Time.deltaTime * 5);

        //rb.AddForce(carmove * _carSpeed);

        transform.Rotate(Vector3.up * carmove.x * steerAngle * Time.deltaTime * carmove.magnitude);

        carmove *= dragAmount;
        carmove = Vector3.ClampMagnitude(carmove, _maxSpeed);   //clampMagnitude
        carmove = Vector3.Lerp(carmove.normalized, transform.position, _carTraction * Time.deltaTime) * carmove.magnitude;   //Normalized 

    }

  
}
