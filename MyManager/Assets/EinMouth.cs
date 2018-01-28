using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EinMouth : MonoBehaviour {

	public Text text;
	private EinDay einDay;
	private float middleInMouth;
	
	void Start() {
		einDay = FindObjectOfType<EinDay>();
	}

	void Update () {		
		middleInMouth = einDay.GetMiddleInDay();
		middleInMouth = middleInMouth * 30;
		text.text = middleInMouth.ToString();
	}
}
