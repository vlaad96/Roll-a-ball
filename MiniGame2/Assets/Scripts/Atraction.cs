using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atraction : MonoBehaviour {

    // Use this for initialization

    public GameObject attractedTo;
    private Rigidbody rb;

    public float strengthOfAttraction;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 direction = attractedTo.transform.position - transform.position;

        rb.AddForce(strengthOfAttraction * direction);
	}
}
