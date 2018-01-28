using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CinDay : MonoBehaviour {

	public Text text;

	private time time;
	private float allC;
	private float days;
	private float middle;

	void Start () {
		time = FindObjectOfType<time>();
	}
	
	void Update () {
		allC = PlayerPrefs.GetFloat("call");
		days = time.GetDays();
		middle = allC / days;

		text.text = middle.ToString();
	}

	public float GetMiddleInDay() {
		return middle;
	}
}
