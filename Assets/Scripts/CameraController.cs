using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform trans;
    float _rotationX;

    float rotationY;

    public float sensitivityHor = 5.0f;

    public float sensitivityVert = 5.0f;

    public float minimumVert = -45.0f;

    public float maximumVert = 45.0f;

    private void Start()
    {
        trans = this.transform;
    }

    private void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        trans.Translate(h * Time.deltaTime, 0, v * Time.deltaTime);

        if (Input.GetMouseButton(1))

        {
            rotationY = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivityHor;

            _rotationX -= Input.GetAxis("Mouse Y") * sensitivityVert;

            _rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert);

            transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
        }
    }
}