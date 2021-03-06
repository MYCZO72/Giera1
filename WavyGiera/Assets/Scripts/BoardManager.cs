﻿using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class BoardManager : MonoBehaviour {

	public int rows = 8;
	public int columns = 8;

	public GameObject darkTile;
	public GameObject lightTile;
	public GameObject player;
	private Transform boardHolder;

	public void generuj()
	{
		boardHolder = new GameObject("plansza").transform;
		GameObject gracznowy = Instantiate( player, new Vector3( 1, 1, 0f ), Quaternion.identity ) as GameObject;
		gracznowy.transform.SetParent( boardHolder );
		for(int i = 1; i <= columns; i++)
		{
			for(int j = 1; j <= rows; j++)
			{
				GameObject kratka;
				if( ( i + j ) % 2 == 1 )
					kratka = darkTile;
				else
					kratka = lightTile;

				GameObject instance = Instantiate( kratka, new Vector3( i, j, 0f ), Quaternion.identity ) as GameObject;

				instance.transform.SetParent( boardHolder );
			}
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
