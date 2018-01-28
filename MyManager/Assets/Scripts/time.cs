using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time : MonoBehaviour {

private Text text;
private System.DateTime startTime;
private string timeFromStart;
private System.DateTime nowTime;

private System.TimeSpan timeStat;
private int days;


	void Start () {
		text = GetComponent<Text>();

		startTime = System.DateTime.Now;
	}
	
	void Update () {
		
		nowTime = System.DateTime.Now.AddDays(10);
		timeFromStart = GetDays().ToString();

		text.text = timeFromStart;
	}

	public int GetDays() {
		timeStat = startTime.Subtract(nowTime);
		days = timeStat.Days;
		return Mathf.Abs(days);
	}
}
