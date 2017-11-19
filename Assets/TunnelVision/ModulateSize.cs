using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModulateSize : MonoBehaviour
{

    public float ts_x, ts_y, ts_z, os_x, os_y, os_z;
    public Vector3 originalScale, targetScale;
    public float time;
    // Use this for initialization

    void Start()
    {
        
    }

    public void wake(Vector3 os, Vector3 ts, float t)
    {
        originalScale = os;
        targetScale = ts;
        time = t;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = Vector3.Lerp(targetScale, originalScale, time);
    }
}
