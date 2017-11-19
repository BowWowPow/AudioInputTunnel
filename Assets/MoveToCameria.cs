using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToCameria : MonoBehaviour {

    GameObject Cam;
    public float speed;
    // Use this for initialization
    void Start () 
    {
        
        if(Cam == null)
        {
            Cam = GameObject.FindGameObjectWithTag("MainCamera");
        }
	}
	
	// Update is called once per frame
	void Update () 
    {
        MoveToCamera();
	}

    void MoveToCamera()
    {
        transform.position = Vector3.Lerp(transform.position, Cam.transform.position, speed * Time.deltaTime);
    }
}
