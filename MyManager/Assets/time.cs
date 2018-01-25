using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time : MonoBehaviour {

private Text text;
private System.DateTime startTime;
private string timeFromStart;

	void Start () {
		text = GetComponent<Text>();

		startTime = System.DateTime.Now;
	}
	
	void Update () {
		System.DateTime nowTime;
		nowTime = System.DateTime.Now;
		timeFromStart = startTime.Subtract(nowTime).ToString();

		text.text = timeFromStart;
	}
}
