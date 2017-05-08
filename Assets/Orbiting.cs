using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbiting : MonoBehaviour {

	public Transform SunTarget;
	public Transform Moon;
	public Rigidbody rb;

	void Awake () {
		
		Moon = transform;
		rb.AddForce(transform.right * 100);
		rb.AddForce(transform.up * -100);

	}

	// Use this for initialization
	void Start () {
		
		GameObject Sun = GameObject.FindGameObjectWithTag("Sun");
		SunTarget = Sun.transform;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 line = SunTarget.position - Moon.position;
		line.Normalize();

		float distance = Vector3.Distance(SunTarget.position, Moon.position);
		rb.AddForce(line * 10/distance);
	}
}
