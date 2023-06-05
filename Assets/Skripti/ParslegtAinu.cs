using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Importē, lai varētu darboties ar ainām
using UnityEngine.SceneManagement;

public class ParslegtAinu : MonoBehaviour {

	//Párslédz ainu uz sákuma ekránu
	public void UzSakumu()
	{
		SceneManager.LoadScene("Sakums", LoadSceneMode.Single);
	}

	//Parslédz ainu uz galveno spéli
	public void UzMasinasAinu()
	{
		SceneManager.LoadScene("PilsetasKarte", LoadSceneMode.Single);
	}

	//Aptura spéli
	public void Apturet()
	{
		Application.Quit();
	}

}
