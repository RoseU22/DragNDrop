using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Importē, lai varētu darboties ar ainām
using UnityEngine.SceneManagement;

public class ParslegtAinu : MonoBehaviour {

	public void UzSakumu()
	{
		SceneManager.LoadScene("Sakums", LoadSceneMode.Single);
	}

	public void UzMasinasAinu()
	{
		SceneManager.LoadScene("PilsetasKarte", LoadSceneMode.Single);
	}

	public void Apturet()
	{
		Application.Quit();
	}

}
