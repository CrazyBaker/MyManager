﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SinDay : MonoBehaviour {

	public Text text;

	private time time;
	private float allS;
	private float days;
	private float middle;

	void Start () {
		time = FindObjectOfType<time>();
	}
	
	void Update () {
		allS = PlayerPrefs.GetFloat("sall");
		days = time.GetDays();
		middle = allS / days;

		text.text = middle.ToString();
	}

	public float GetMiddleInDay() {
		return middle;
	}
}
