using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbiting4 : MonoBehaviour {



	public Transform Planet3;
	public Rigidbody rb;
	// Use this for initialization
	void Start () {
		Planet3 = transform;
		rb.AddForce(transform.right * 100);
		rb.AddForce(transform.up);
	}
	
	// Update is called once per frame
	void Update () {

		GameObject refen = GameObject.FindGameObjectWithTag("manager");

		foreach(GameObject bod in refen.GetComponent<bodymanager>().body){

			Vector3 line = bod.transform.position - Planet3.position;


			float distance = Vector3.Distance(bod.transform.position, Planet3.position);
			//rb.mass = mass;

			if(distance != 0){
				line.Normalize();
				rb.AddForce(line * bod.GetComponent<Rigidbody>().mass * rb.mass * 9.81f);

			}



		}

	}
}
