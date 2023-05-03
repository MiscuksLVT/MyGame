using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System.Security.Cryptography;
using UnityEngine.UI;

public class Atteluparvietosana : MonoBehaviour,

    IPointerDownHandler, IBeginDragHandler,
        IDragHandler, IEndDragHandler
{

    private RectTransform transformKomponente;
    public Canvas kanva;
    public GameObject xSaiders;
    public GameObject ySlaiders;
    public GameObject mainigaisAttles;

    void Start()
    {
        //Stratejot automatiski pieklust
        // attela transorm komponenti un
        // piefikse kadas koordinatas attels atrodas
        transformKomponente = GetComponent<RectTransform>();
    }
    public void OnPointerDown(PointerEventData notikums)
    {
        Debug.Log("Izdarits peles klikskis uz objekta!");
    }
    public void OnBeginDrag(PointerEventData notikums)
    {
        Debug.Log("Uzsaktaobjekta vilksana!");
    }
    public void OnDrag(PointerEventData notikums)
    {
        Debug.Log("Notiek objekta parvietosana!");
        transformKomponente.anchoredPosition +=
            notikums.delta / kanva.scaleFactor;
    }

    public void OnEndDrag(PointerEventData notikums)
    {
        Debug.Log("Pabeigta objekta vilksana");
    }

   
    public void mainitPlatumu()
    {
        float pasreizajaVertiba = xSaiders.GetComponent<Slider>().value;
        mainigaisAttles.transform.localScale = new Vector2(1f * pasreizajaVertiba, 0);
    }

    public void mainitGarumu()
    {
        float pasreizajaVertiba = ySlaiders.GetComponent<Slider>().value;
        mainigaisAttles.transform.localScale = new Vector2(0, 1f * pasreizajaVertiba);
    }

}
