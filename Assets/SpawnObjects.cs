using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour {

    public List<GameObject> objs = new List<GameObject>();
    public GameObject Wall;
    public float cd;
    private float t;
    // Use this for initialization
	void Start () {
        t = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (t > cd)
        {
            SpawnWall();
            t = 0; 
        }
        else
        {
            t += Time.deltaTime;
        }
	}

    void SpawnWall()
    {
        Instantiate(Wall,transform.position,transform.rotation);
    }
}
