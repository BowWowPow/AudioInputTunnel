using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour {
	public float moveSpeed,t,cd;
	// Use this for initialization
	void Start () {
		t = 0;
		cd = 10f;
	}
	
	// Update is called once per frame
	void Update () {
			if(t <= cd){
			t += Time.deltaTime;
		}else{
			Destroy(this.gameObject);
			t = 0;
		}
	}
}
