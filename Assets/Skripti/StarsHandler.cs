using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsHandler : MonoBehaviour {

	public GameObject[] stars;
	public int score = 0;

	//Sák skaitít laiku
	void Start () {
		StartCoroutine (time());
	}

	IEnumerator time(){
		while (true) 
		{
			timeCount();
			yield return new WaitForSeconds (1);
		}
	}

	void timeCount () {	
		score += 1;
	}

	//Nosaka cik zvaigznes lietotájs dabús balstoties uz vińa laiku
	public void starsAchieved(){

		if (score >= 200) {
			
			//one star
			stars [0].SetActive (true);
			stars [4].SetActive (true);
			stars [5].SetActive (true);

		} else if (score >= 150 && score <= 200) {
			
			//two stars
			stars [0].SetActive (true);
			stars [1].SetActive (true);
			stars [5].SetActive (true);

		} else if (score < 150) {
			
			//three stars
			stars [0].SetActive (true);
			stars [1].SetActive (true);
			stars [2].SetActive (true);

		}
	}
}