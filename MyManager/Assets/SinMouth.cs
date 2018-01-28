using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SinMouth : MonoBehaviour {

	public Text text;
	private SinDay sinDay;
	private float middleInMouth;
	
	void Start() {
		sinDay = FindObjectOfType<SinDay>();
	}

	void Update () {		
		middleInMouth = sinDay.GetMiddleInDay();
		middleInMouth = middleInMouth * 30;
		text.text = middleInMouth.ToString();
	}
}
