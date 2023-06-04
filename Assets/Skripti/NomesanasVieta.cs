using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NomesanasVieta : MonoBehaviour, IDropHandler {

	private float vietasZRot, velkObjZRot, rotacijasStarpiba;
    private float xIzmStarpiba, yIzmStarpiba;
    private Vector2 vietasIzm, velkObjIzm;

	public Objekti objektuSkripts;
    

    public void OnDrop(PointerEventData eventData)
    {
        if(eventData.pointerDrag != null)
        {
            if (eventData.pointerDrag.tag.Equals(tag))
            {
                vietasZRot = eventData.pointerDrag.GetComponent<RectTransform>().transform.eulerAngles.z;
                velkObjZRot = GetComponent<RectTransform>().transform.eulerAngles.z;

                rotacijasStarpiba = Mathf.Abs(vietasZRot - velkObjZRot);

                vietasIzm = eventData.pointerDrag.GetComponent<RectTransform>().localScale;

                velkObjIzm = GetComponent<RectTransform>().localScale;

                xIzmStarpiba = Mathf.Abs(vietasIzm.x - velkObjIzm.x);
                yIzmStarpiba = Mathf.Abs(vietasIzm.y - velkObjIzm.y);

                Debug.Log("Objekta rotācijas starpība: "+rotacijasStarpiba+"\nPlatuma starpība: "+xIzmStarpiba+"\nAugstuma starpība: "+yIzmStarpiba);

				if (rotacijasStarpiba <= 6 && (xIzmStarpiba <= 0.1 && yIzmStarpiba <= 0.1) || (rotacijasStarpiba >= 354 && rotacijasStarpiba <= 360) && (xIzmStarpiba <= 0.1 && yIzmStarpiba <= 0.1))
                {
                    Debug.Log("Nomests pareizajā vietā!");
                    objektuSkripts.vaiIstajaVieta = true;

                    eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                    eventData.pointerDrag.GetComponent<RectTransform>().localRotation = GetComponent<RectTransform>().localRotation;
                    eventData.pointerDrag.GetComponent<RectTransform>().localScale = GetComponent<RectTransform>().localScale;

                    switch (eventData.pointerDrag.tag)
                    {
                        case "Atkritumi":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[1]);
                            break;

                        case "Atrie":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[2]);
                            break;

                        case "Buss":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[3]);
                            break;

						case "b2":
							objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[4]);
							break;

						case "CementaMasina":
							objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[5]);
							break;

						case "e46":
							objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[6]);
							break;

						case "e61":
							objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[7]);
							break;
							
						case "Eskavators":
							objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[8]);
							break;

						case "Policija":
							objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[9]);
							break;

						case "Traktors1":
							objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[10]);
							break;

						case "Traktors5":
							objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[11]);
							break;

						case "Ugunsdzeseji":
							objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[12]);
							break;


                        default:
                            Debug.Log("Tags nav definēts");
                            break;
                    }
                }
                //Ja tagi nesakrīt, tātad nepareizajā vietā
            }
            else{
                objektuSkripts.vaiIstajaVieta = false;
                objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[0]);

                switch (eventData.pointerDrag.tag)
                {
                    case "Atkritumi":
                        objektuSkripts.atkritumuMasina.GetComponent<RectTransform>().localPosition = objektuSkripts.atkritumuMasinaKoordinatas;
                        break;

                    case "Atrie":
                        objektuSkripts.atraPalidziba.GetComponent<RectTransform>().localPosition = objektuSkripts.atrasPalidzibasKoordinatas;
                        break;

                    case "Buss":
                        objektuSkripts.autobuss.GetComponent<RectTransform>().localPosition = objektuSkripts.autobussKoordinatas;
                        break;

					case "b2":
						objektuSkripts.b2.GetComponent<RectTransform>().localPosition = objektuSkripts.b2Koordinatas;
						break;

					case "CementaMasina":
						objektuSkripts.CementaMasina.GetComponent<RectTransform>().localPosition = objektuSkripts.CementaMasinaKoordinatas;
						break;

					case "e46":
						objektuSkripts.e46.GetComponent<RectTransform>().localPosition = objektuSkripts.e46Koordinatas;
						break;

					case "e61":
						objektuSkripts.e61.GetComponent<RectTransform>().localPosition = objektuSkripts.e61Koordinatas;
						break;

					case "Eskavators":
						objektuSkripts.Eskavators.GetComponent<RectTransform>().localPosition = objektuSkripts.EskavatorsKoordinatas;
						break;

					case "Policija":
						objektuSkripts.Policija.GetComponent<RectTransform>().localPosition = objektuSkripts.PolicijaKoordinatas;
						break;

					case "Traktors1":
						objektuSkripts.Traktors1.GetComponent<RectTransform>().localPosition = objektuSkripts.Traktors1Koordinatas;
						break;

					case "Traktors5":
						objektuSkripts.Traktors5.GetComponent<RectTransform>().localPosition = objektuSkripts.Traktors5Koordinatas;
						break;

					case "Ugunsdzeseji":
						objektuSkripts.Ugunsdzeseji.GetComponent<RectTransform>().localPosition = objektuSkripts.UgunsdzesejiKoordinatas;
						break;

                    default:
                        Debug.Log("Tags nav definēts");
                        break;
                }
            }
        }
    }
}
