using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToCameraPositions : MonoBehaviour {

    // Use this for initialization
    private GameObject p1, p2, p3, p4;
    private List<GameObject> positions = new List<GameObject>();
    private GameObject direction;
    public float speed;

    void Start () {
        if (p1 == null)
        {
            p1 = GameObject.FindGameObjectWithTag("p1");
            positions.Add(p1);
        }
        if (p2 == null)
        {
            p2 = GameObject.FindGameObjectWithTag("p2");
            positions.Add(p2);
        }
        if (p3 == null)
        {
            p3 = GameObject.FindGameObjectWithTag("p3");
            positions.Add(p3);
        }
        if (p4 == null)
        {
            p4 = GameObject.FindGameObjectWithTag("p4");
            positions.Add(p4);
        }

        int p = Random.Range(0, 4);
        direction = positions[p];
	}
	
    void Update()
    {
        MoveToCameraPosition();
    }

    void MoveToCameraPosition()
    {
        transform.position = Vector3.Lerp(transform.position, direction.transform.position, speed * Time.deltaTime);
    }
}
