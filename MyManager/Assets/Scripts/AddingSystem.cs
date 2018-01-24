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

		SetupSaves();
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
		SaveSkills();
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

	public void SetupSaves() {
		if (PlayerPrefs.HasKey("plvl") & gameObject.name == "PButton") {
			lvl = PlayerPrefs.GetFloat("plvl");
			progress = PlayerPrefs.GetFloat("pprogress");
			ost = PlayerPrefs.GetFloat("post");
			all = PlayerPrefs.GetFloat("pall");
		}

		if (PlayerPrefs.HasKey("rlvl") & gameObject.name == "RButton") {
			lvl = PlayerPrefs.GetFloat("rlvl");
			progress = PlayerPrefs.GetFloat("rprogress");
			ost = PlayerPrefs.GetFloat("rost");
			all = PlayerPrefs.GetFloat("rall");
		}

		if (PlayerPrefs.HasKey("elvl") & gameObject.name == "EButton") {
			lvl = PlayerPrefs.GetFloat("elvl");
			progress = PlayerPrefs.GetFloat("eprogress");
			ost = PlayerPrefs.GetFloat("eost");
			all = PlayerPrefs.GetFloat("eall");
		}

		if (PlayerPrefs.HasKey("slvl") & gameObject.name == "SButton") {
			lvl = PlayerPrefs.GetFloat("slvl");
			progress = PlayerPrefs.GetFloat("sprogress");
			ost = PlayerPrefs.GetFloat("sost");
			all = PlayerPrefs.GetFloat("sall");
		}

		if (PlayerPrefs.HasKey("clvl") & gameObject.name == "CButton") {
			lvl = PlayerPrefs.GetFloat("clvl");
			progress = PlayerPrefs.GetFloat("cprogress");
			ost = PlayerPrefs.GetFloat("cost");
			all = PlayerPrefs.GetFloat("call");
		}
		
		UpdateText ();
	}

	public void SaveSkills() {
		if (gameObject.name == "PButton") {
			PlayerPrefs.SetFloat("plvl", lvl);
			PlayerPrefs.SetFloat("pprogress", progress);
			PlayerPrefs.SetFloat("post", ost);
			PlayerPrefs.SetFloat("pall", all);
		}

		if (gameObject.name == "RButton") {
			PlayerPrefs.SetFloat("rlvl", lvl);
			PlayerPrefs.SetFloat("rprogress", progress);
			PlayerPrefs.SetFloat("rost", ost);
			PlayerPrefs.SetFloat("rall", all);
		}

		if (gameObject.name == "EButton") {
			PlayerPrefs.SetFloat("elvl", lvl);
			PlayerPrefs.SetFloat("eprogress", progress);
			PlayerPrefs.SetFloat("eost", ost);
			PlayerPrefs.SetFloat("eall", all);
		}
		
		if (gameObject.name == "SButton") {
			PlayerPrefs.SetFloat("slvl", lvl);
			PlayerPrefs.SetFloat("sprogress", progress);
			PlayerPrefs.SetFloat("sost", ost);
			PlayerPrefs.SetFloat("sall", all);
		}

		if (gameObject.name == "CButton") {
			PlayerPrefs.SetFloat("clvl", lvl);
			PlayerPrefs.SetFloat("cprogress", progress);
			PlayerPrefs.SetFloat("cost", ost);
			PlayerPrefs.SetFloat("call", all);
		}
	}
}
