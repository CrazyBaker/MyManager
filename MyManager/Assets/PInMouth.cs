using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PInMouth : MonoBehaviour {

	public Text text;
	private PinDay pinDay;
	private float middleInMouth;
	
	void Start() {
		pinDay = FindObjectOfType<PinDay>();
	}

	void Update () {		
		middleInMouth = pinDay.GetMiddleInDay();
		middleInMouth = middleInMouth * 30;
		text.text = middleInMouth.ToString();
	}
}
