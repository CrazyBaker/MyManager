using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwichScreen : MonoBehaviour {

	public Camera mainCamera;
	//public Camera PCamera;
	public Canvas canvas;
	void Start () {
		mainCamera.enabled = true;
		//PCamera.enabled = false;
		
	}
	
	void Update () {
		if (Input.GetKey(KeyCode.Q)) {
			canvas.enabled = !canvas.enabled;
		}
	}

	public void SwichOnP() {
		mainCamera.enabled = !mainCamera.enabled;
	//	PCamera.enabled = !PCamera.enabled;
	} 
}
