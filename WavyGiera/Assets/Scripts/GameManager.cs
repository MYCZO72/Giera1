﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager instance = null;
	public BoardManager skrypcik;

	void InitGame()
	{
		skrypcik.generuj();
	}

	void Awake()
	{
		if( instance == null )
		{
			instance = this;
		}
		else if( instance != this )
		{
			Destroy (gameObject);
		}

		DontDestroyOnLoad( gameObject );
		skrypcik = GetComponent<BoardManager>();
		InitGame();
	}
}
