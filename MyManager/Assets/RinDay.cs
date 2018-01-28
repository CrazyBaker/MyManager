using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RinDay : MonoBehaviour {

	public Text text;

	private time time;
	private float allR;
	private float days;
	private float middle;

	void Start () {
		time = FindObjectOfType<time>();
	}
	
	void Update () {
		allR = PlayerPrefs.GetFloat("rall");
		days = time.GetDays();
		middle = allR / days;

		text.text = middle.ToString();
	}

	public float GetMiddleInDay() {
		return middle;
	}
}
