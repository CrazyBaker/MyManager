using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EinDay : MonoBehaviour {

	public Text text;

	private time time;
	private float allE;
	private float days;
	private float middle;

	void Start () {
		time = FindObjectOfType<time>();
	}
	
	void Update () {
		allE = PlayerPrefs.GetFloat("eall");
		days = time.GetDays();
		middle = allE / days;

		text.text = middle.ToString();
	}

	public float GetMiddleInDay() {
		return middle;
	}
}
