﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour {

	private Rigidbody rb;
	public float speed;
	public int angle;
	public KeyCode adelante;
	public KeyCode atras;
	public KeyCode izqui;
	public KeyCode derecha;
	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKey(adelante))
		{
		transform.Translate (Vector3.forward * Time.deltaTime * speed);
		}
		if(Input.GetKey(atras))
		{
			transform.Translate (Vector3.back * Time.deltaTime * speed);
		}
		if(Input.GetKey(derecha))
		{
			transform.Rotate (Vector3.up * Time.deltaTime * angle);
		}

		if(Input.GetKey(izqui))
		{
			transform.Rotate (Vector3.up * Time.deltaTime * -angle);
		}


	}
}
	