﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//ゲームが始まらないと処理はされない
		if (GameManager.Instance.BeforeGameStart ()) return;
		if (Input.GetMouseButtonDown (0)) {
			Attack ();
		}
	}
	//攻撃
	void Attack()
	{
		Debug.Log ("攻撃");
	}
}
