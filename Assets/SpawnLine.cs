using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLine : MonoBehaviour {

    public GameObject Line;
    public float cd;
    private float t;
    // Use this for initialization
    void Start()
    {
        t = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (t > cd)
        {
            SpawnLines();
            t = 0;
        }
        else
        {
            t += Time.deltaTime;
        }
    }

    void SpawnLines()
    {
        Instantiate(Line, transform.position, transform.rotation);
    }
}

