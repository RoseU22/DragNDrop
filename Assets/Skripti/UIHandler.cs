using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIHandler : MonoBehaviour {

	public GameObject LevelDialog;
	public Text LevelStatus;
	public Text scoreText;

	public static UIHandler instance;

	void Awake(){
		if (instance == null)
			instance = this;
	}

	//Paráda pazińojumu par uzvaru un atbilstośi paráda atbilstośas zvaigznes
	public void ShowLevelDialog(string status, string scores){
		GetComponent<StarsHandler> ().starsAchieved();
		LevelDialog.SetActive(true);
		LevelStatus.text = status;
		scoreText.text = scores;
	}

	//Nodrośina iespéju atsákt spéli no jauna
	public void ReplayLevel(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		NomesanasVieta.skaits = 0;
	}
}
