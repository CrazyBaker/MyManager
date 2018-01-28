using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CinMouth : MonoBehaviour {

	public Text text;
	private CinDay cinDay;
	private float middleInMouth;
	
	void Start() {
		cinDay = FindObjectOfType<CinDay>();
	}

	void Update () {		
		middleInMouth = cinDay.GetMiddleInDay();
		middleInMouth = middleInMouth * 30;
		text.text = middleInMouth.ToString();
	}
}
