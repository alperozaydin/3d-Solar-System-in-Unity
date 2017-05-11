using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbiting5 : MonoBehaviour {


	public Transform Moon2;
	public Rigidbody rb;
	// Use this for initialization
	void Start () {
		Moon2 = transform;
		rb.AddForce(transform.right * 40);
		rb.AddForce(transform.up );
	}
	
	// Update is called once per frame
	void Update () {


		GameObject refen = GameObject.FindGameObjectWithTag("manager");

		foreach(GameObject bod in refen.GetComponent<bodymanager>().body3){

			Vector3 line = bod.transform.position - Moon2.position;


			float distance = Vector3.Distance(bod.transform.position, Moon2.position);
			//rb.mass = mass;

			if(distance != 0){
				line.Normalize();
				rb.AddForce(line * bod.GetComponent<Rigidbody>().mass * rb.mass * 9.81f);

			}



		}
	}
}
