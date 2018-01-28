using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Statistics : MonoBehaviour {

public Text hoursPText;

private float hoursP;
private float pPomodoro;

	void Start () {
		
	}
	
	void Update () {
		pPomodoro = PlayerPrefs.GetFloat("pall");
		hoursP = pPomodoro / 2;

		hoursPText.text = hoursP.ToString();
	}
}
