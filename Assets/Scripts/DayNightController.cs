using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightController : MonoBehaviour
{
    public float rotateSpeed = 10f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime, Space.Self);
    }
}