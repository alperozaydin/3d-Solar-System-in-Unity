using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bodymanager : MonoBehaviour {


	public GameObject[] body;
	public GameObject[] body2;
	public GameObject[] body3;
	// Use this for initialization
	void Start () {
		
	}

	void awake(){
		body = GameObject.FindGameObjectsWithTag("Sun");
		body2 = GameObject.FindGameObjectsWithTag("Earth");
		body3 = GameObject.FindGameObjectsWithTag("Saturn");

	}


	// Update is called once per frame
	void Update () {
		body = GameObject.FindGameObjectsWithTag("Sun");
		body2 = GameObject.FindGameObjectsWithTag("Earth");
		body3 = GameObject.FindGameObjectsWithTag("Saturn");

	}
}
