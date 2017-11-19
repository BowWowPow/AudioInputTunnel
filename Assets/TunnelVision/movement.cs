using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
	public float moveSpeed,t,cd;
	public GameObject wall;
	private float rotationZ = 0f;
	private float rotationX = 0f;
	private float sensitivityZ = 2f;
    public Vector3 os, ts;
    public float time;
    // Use this for initialization
    void Start()
    {
        moveSpeed = 2.5f;
        t = 0;
        cd = 0.25f;
        time = 0.5f;
        ts = new Vector3(1f, 1f, 1f);
        os = new Vector3(0f, 0f, 0f);
    }
	
	// Update is called once per frame
	void Update () {
		MoveCam();
		if(t <= cd){
			t += Time.deltaTime;
		}else{
			//MakeWall();
			t = 0;
		}
	}

	public void MakeWall(){
		GameObject temp = Instantiate(wall,new Vector3(transform.position.x,transform.position.y ,transform.position.z + 100f), Quaternion.identity);
		temp.transform.Rotate(new Vector3(this.transform.rotation.x,this.transform.rotation.y,transform.rotation.z));
        temp.gameObject.GetComponent<ModulateSize>().wake(os,ts,time);
	}

	public void MoveCam(){
		// if(Input.GetAxis("Horizontal") > 0 || Input.GetAxis("Horizontal") < 0 ){
		// 	transform.Translate (moveSpeed * Time.deltaTime, moveSpeed * Time.deltaTime,0.0f);
		// }

		// if(Input.GetAxis("Vertical") > 0 || Input.GetAxis("Vertical") < 0 ){
		// 	transform.Translate (moveSpeed * Time.deltaTime, moveSpeed * Time.deltaTime,0.0f);
		// }
		transform.Translate(transform.forward * moveSpeed);

		// rotationZ += Input.GetAxis("Horizontal") * sensitivityZ;
  //  		rotationZ = Mathf.Clamp (rotationZ, -5, 5);

  //  		rotationX += Input.GetAxis("Vertical") * sensitivityZ;
  //  		rotationX = Mathf.Clamp (rotationZ, -5, 5);
             
  //    	transform.localEulerAngles = new Vector3(-rotationX, -rotationZ, transform.localEulerAngles.z);

		

	}
}
