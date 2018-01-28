using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RinMouth : MonoBehaviour {

	public Text text;
	private RinDay rinDay;
	private float middleInMouth;
	
	void Start() {
		rinDay = FindObjectOfType<RinDay>();
	}

	void Update () {		
		middleInMouth = rinDay.GetMiddleInDay();
		middleInMouth = middleInMouth * 30;
		text.text = middleInMouth.ToString();
	}
}
