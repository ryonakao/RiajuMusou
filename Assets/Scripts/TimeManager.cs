﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour {

	public float time = 30;

	public bool isDebug;
	// Use this for initialization
	void Start () {
		if (isDebug)
			time = 5;
	}
	
	// Update is called once per frame
	void Update () {
		CountDown ();
		if (time <= 0) {
			GoResult ();
		}
	}

	//時間を減らす
	void CountDown()
	{
		time -= 1.0f * Time.deltaTime;
	}
	//リザルトシーンへ遷移
	void GoResult()
	{
		MySceneManager.Instance.GoResult ();
	}
}
