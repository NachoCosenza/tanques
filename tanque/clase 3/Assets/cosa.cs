﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cosa : MonoBehaviour {

	private Rigidbody rb;
	public float angle;
	public GameObject prefa;
	public Transform salida;
	public KeyCode giroI;
	public KeyCode giroD;
	public KeyCode accion;




	public int valor = 1 ;

	void Start () 
	{
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKey(giroD))
		{
			transform.Rotate (Vector3.up * Time.deltaTime * angle);
		}

		if(Input.GetKey(giroI))
		{
			transform.Rotate (Vector3.up * Time.deltaTime * -angle);
		}
		//rb.AddRelativeForce (Vector3.forward);
		//rb.AddTorque (Vector3.up);
		//rb.AddRelativeTorque (Vector3.up);
		if(Input.GetKeyDown(accion))
		{
			Instantiate (prefa,salida.position,salida.rotation);
		}
	}
}
