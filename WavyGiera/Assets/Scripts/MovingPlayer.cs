using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlayer : MonoBehaviour 
{
	public float speed;
	Rigidbody2D gracz;

	void Start()
	{
		gracz = GetComponent<Rigidbody2D>();	
	}

	void FixedUpdate()
	{
		float movex = Input.GetAxis("Horizontal");
		float movey = Input.GetAxis("Vertical");

		Vector3 ruch = new Vector3( movex, movey, 0f );

		gracz.AddForce( ruch * speed );
	}
}
