using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToCamera : MonoBehaviour {

    private GameObject CameraRig;
    private float time;
	// Use this for initialization
	void Start () {
        CameraRig = GameObject.FindGameObjectWithTag("MainCamera");
        time = 0.3f;
	}
	
	// Update is called once per frame
	void Update () {
        //transform.position = Vector3.Lerp(CameraRig.transform.position, transform.position, time);
        transform.rotation = Quaternion.Lerp(CameraRig.transform.rotation, transform.rotation, time);
	}
}
