using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camralate : MonoBehaviour {
	public Camera cam;
	public float zoom, movespeed;
	// Use this for initialization
	void Start () {
		cam = this.gameObject.GetComponent<Camera> ();
		zoom = 1.001f;
		movespeed = 5.0f;
	}
	
	// Update is called once per frame
	void Update () {
		cam.orthographicSize = zoom * Time.deltaTime;
		transform.Translate (0.0f,0.0f, transform.position.z - movespeed );
	}
}
