using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDestroy : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (this.gameObject)
            Destroy(this.gameObject);
    }
}