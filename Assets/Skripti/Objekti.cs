using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {

	public GameObject atkritumuMasina;
	public GameObject atraPalidziba;
	public GameObject autobuss;
	public GameObject b2;
	public GameObject CementaMasina;
	public GameObject e46;
	public GameObject e61;
	public GameObject Eskavators;
	public GameObject Policija;
	public GameObject Traktors1;
	public GameObject Traktors5;
	public GameObject Ugunsdzeseji;

	[HideInInspector]
	public Vector2 atkritumuMasinaKoordinatas;
	[HideInInspector]
	public Vector2 atrasPalidzibasKoordinatas;
    [HideInInspector]
    public Vector2 autobussKoordinatas;
	[HideInInspector]
	public Vector2 b2Koordinatas;
	[HideInInspector]
	public Vector2 CementaMasinaKoordinatas;
	[HideInInspector]
	public Vector2 e46Koordinatas;
	[HideInInspector]
	public Vector2 e61Koordinatas;
	[HideInInspector]
	public Vector2 EskavatorsKoordinatas;
	[HideInInspector]
	public Vector2 PolicijaKoordinatas;
	[HideInInspector]
	public Vector2 Traktors1Koordinatas;
	[HideInInspector]
	public Vector2 Traktors5Koordinatas;
	[HideInInspector]
	public Vector2 UgunsdzesejiKoordinatas;

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
		b2Koordinatas = b2.GetComponent<RectTransform>().localPosition;
		CementaMasinaKoordinatas = CementaMasina.GetComponent<RectTransform>().localPosition;
		e46Koordinatas = e46.GetComponent<RectTransform>().localPosition;
		e61Koordinatas = e61.GetComponent<RectTransform>().localPosition;
		EskavatorsKoordinatas = Eskavators.GetComponent<RectTransform>().localPosition;
		PolicijaKoordinatas = Policija.GetComponent<RectTransform>().localPosition;
		Traktors1Koordinatas = Traktors1.GetComponent<RectTransform>().localPosition;
		Traktors5Koordinatas = Traktors5.GetComponent<RectTransform>().localPosition;
		UgunsdzesejiKoordinatas = Ugunsdzeseji.GetComponent<RectTransform>().localPosition;
	}	
}
