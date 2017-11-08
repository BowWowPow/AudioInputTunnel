using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour {

    public GameObject circle;
	// Use this for initialization
	void Start () {
        transform.LookAt(circle.transform);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
