using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    private Vector3 cameraOffset;

    private void Start()
    {
        cameraOffset = transform.position - target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = cameraOffset + target.transform.position;
    }
}
