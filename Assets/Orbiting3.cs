using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbiting3 : MonoBehaviour {



	public Transform Planet2;
	public Rigidbody rb;
	// Use this for initialization
	void Start () {
		Planet2 = transform;
		rb.AddForce(transform.right * 50);
		rb.AddForce(transform.up);
	}
	
	// Update is called once per frame
	void Update () {

		GameObject refen = GameObject.FindGameObjectWithTag("manager");

		foreach(GameObject bod in refen.GetComponent<bodymanager>().body){

			Vector3 line = bod.transform.position - Planet2.position;


			float distance = Vector3.Distance(bod.transform.position, Planet2.position);
			//rb.mass = mass;

			if(distance != 0){
				line.Normalize();
				rb.AddForce(line * bod.GetComponent<Rigidbody>().mass * rb.mass * 9.81f);

			}



		}


	}
}
