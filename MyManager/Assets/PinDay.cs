using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PinDay : MonoBehaviour {

	public Text text;

	private time time;
	private float allP;
	private float days;
	private float middle;

	void Start () {
		time = FindObjectOfType<time>();
	}
	
	void Update () {
		allP = PlayerPrefs.GetFloat("pall");
		days = time.GetDays();
		middle = allP / days;

		text.text = middle.ToString();
	}

	public float GetMiddleInDay() {
		return middle;
	}
}
