using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwichScreen : MonoBehaviour {

	public Canvas canvas;
	public Canvas pCanvas;
	public Canvas statCanvas;

	void Start () {
		SwichBack();
	}
	
	void Update () {
		
	}

	public void SwichOnP() {
		canvas.enabled = false;
		pCanvas.enabled = true;
		statCanvas.enabled = false;
	} 

	public void SwichOnStat() {
		canvas.enabled = false;
		pCanvas.enabled = false;
		statCanvas.enabled = true;
	} 

	public void SwichBack () {
		canvas.enabled = true;
		pCanvas.enabled = false;
		statCanvas.enabled = false;
	}
}
