using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbiting : MonoBehaviour {

	//public Transform SunTarget;
	public Transform Planet1;
	public Rigidbody rb;
	//public float mass;

	void Awake () {
		
		Planet1 = transform;
		rb.AddForce(transform.right * 10);
		rb.AddForce(transform.up);

	}

	// Use this for initialization
	void Start () {
		
//		GameObject Sun = GameObject.FindGameObjectWithTag("Sun");
//		SunTarget = Sun.transform;
	}
	
	// Update is called once per frame
	void Update () {
//		Vector3 line = SunTarget.position - Planet1.position;
//		line.Normalize();
//
//		float distance = Vector3.Distance(SunTarget.position, Planet1.position);
//		rb.AddForce(line * 10/distance);


		GameObject refen = GameObject.FindGameObjectWithTag("manager");

		foreach(GameObject bod in refen.GetComponent<bodymanager>().body){

			Vector3 line = bod.transform.position - Planet1.position;


			float distance = Vector3.Distance(bod.transform.position, Planet1.position);
			//rb.mass = mass;

			if(distance != 0){
				line.Normalize();
				rb.AddForce(line * bod.GetComponent<Rigidbody>().mass * rb.mass * 9.81f);

			}



		}





	}
}
