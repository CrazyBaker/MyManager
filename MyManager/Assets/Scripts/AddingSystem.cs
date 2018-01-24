using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddingSystem : MonoBehaviour {

public Text lvlText;
public Text progressText;
public Text ostText;
public Text allText;

public float baseCount;

private InputField TextBox;

private float lvl;
private float progress;
private float ost;
private float all;

	void Start () {
		TextBox = FindObjectOfType<InputField>();
		ost = baseCount;
	}
	
	void Update () {
		
	}

	public void Adding(float count) {
		count = float.Parse(TextBox.text);
		ost -= count;
		all += count;

		progress =  (ost * 100) / baseCount;

		if (ost <= 0) {
			LvlUp();
		}
		UpdateText();
	}

	public void LvlUp () {
		ost = baseCount + ost;
		lvl += 1;
		
	}

	public void UpdateText () {
		lvlText.text = lvl.ToString();
		progressText.text = progress.ToString();
		ostText.text = ost.ToString();
		allText.text = all.ToString();
	}
}
