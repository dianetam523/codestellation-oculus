using UnityEngine;
using System.Collections;

public class FPS : MonoBehaviour {

	public GameObject oculusLeftEye;
<<<<<<< HEAD

	public JointOrientation j;
=======
    JointOrientation j;
>>>>>>> 29c278f82253a23faa9a3b2a9a43622a27f9dbc5
	Rigidbody rr;
	public float forwardSpeed = 100f;
	float rotationSpeed = 300f;
	
	Vector3 axis;
	float rotationY;
	float rotationX;
	float rotationZ;
	
	bool start = false;
	
	
	
	// Use this for initialization
	void Start () {
		rr = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.Space)) {
			
			start = true;
		}
		
		
		if(start == true)
		{
			if(j.getCalcX() > 0){
				j.makePositive();
			}
			FlightMode();
		}
		
	}
	
	
	
	void FlightMode(){
		
		//get rotation values for the leftEye
		rotationX = oculusLeftEye.transform.localRotation.x / 2;
		rotationY = oculusLeftEye.transform.localRotation.y / 2;
		rotationZ = oculusLeftEye.transform.localRotation.z;
		
		//put them into a vector
		axis = new Vector3 (rotationX, rotationY, rotationZ);
		
		//Rotate
<<<<<<< HEAD
		transform.Rotate (axis * Time.deltaTime*2 * rotationSpeed);
		rr.velocity = oculusLeftEye.transform.forward * j.getV ();

=======
		transform.Rotate (axis * Time.deltaTime * rotationSpeed);
		
		rr.velocity = oculusLeftEye.transform.forward * j.getV();
		
		
>>>>>>> 29c278f82253a23faa9a3b2a9a43622a27f9dbc5
	}﻿
}
