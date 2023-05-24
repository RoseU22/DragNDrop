using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {

	public GameObject atkritumuMasina;
	public GameObject atraPalidziba;
	public GameObject autobuss;

	[HideInInspector]
	public Vector2 atkritumuMasinaKoordinatas;
	[HideInInspector]
	public Vector2 atrasPalidzibasKoordinatas;
    [HideInInspector]
    public Vector2 autobussKoordinatas;

	public Canvas kanva;

	public AudioSource skanasAvots;
	public AudioClip[] skanasKoAtskanot;

	[HideInInspector]
	public bool vaiIstajaVieta = false;

	public GameObject pedejaisVilktais = null;


	// Use this for initialization
	void Start () {
		atkritumuMasinaKoordinatas = atkritumuMasina.GetComponent<RectTransform>().localPosition;
		atrasPalidzibasKoordinatas = atraPalidziba.GetComponent<RectTransform>().localPosition;
		autobussKoordinatas = autobuss.GetComponent<RectTransform>().localPosition;
	}	
}
