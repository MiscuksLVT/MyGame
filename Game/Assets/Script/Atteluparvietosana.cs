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
    public GameObject[] atteluMasiv;
    public float x=1;
    public float y=1;

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
      
        x = pasreizajaVertiba   ;
        
        atteluMasiv[0].transform.localScale = new Vector2(  pasreizajaVertiba, y);
        atteluMasiv[1].transform.localScale = new Vector2(  pasreizajaVertiba, y);
        atteluMasiv[2].transform.localScale = new Vector2(  pasreizajaVertiba, y);
        atteluMasiv[3].transform.localScale = new Vector2(  pasreizajaVertiba, y);
        atteluMasiv[4].transform.localScale = new Vector2(  pasreizajaVertiba, y);
        atteluMasiv[5].transform.localScale = new Vector2(  pasreizajaVertiba, y);
        atteluMasiv[6].transform.localScale = new Vector2(  pasreizajaVertiba, y);
        atteluMasiv[7].transform.localScale = new Vector2(  pasreizajaVertiba, y);
        atteluMasiv[8].transform.localScale = new Vector2(  pasreizajaVertiba, y);
        atteluMasiv[9].transform.localScale = new Vector2(  pasreizajaVertiba, y);
        atteluMasiv[10].transform.localScale = new Vector2(  pasreizajaVertiba, y);
        atteluMasiv[11].transform.localScale = new Vector2(  pasreizajaVertiba, y);
        atteluMasiv[12].transform.localScale = new Vector2(  pasreizajaVertiba, y);
        atteluMasiv[13].transform.localScale = new Vector2(  pasreizajaVertiba, y);
        atteluMasiv[14].transform.localScale = new Vector2(  pasreizajaVertiba, y);
        atteluMasiv[15].transform.localScale = new Vector2(  pasreizajaVertiba, y);
        atteluMasiv[16].transform.localScale = new Vector2(  pasreizajaVertiba, y);
        atteluMasiv[17].transform.localScale = new Vector2(  pasreizajaVertiba, y);
        atteluMasiv[18].transform.localScale = new Vector2(  pasreizajaVertiba, y);
        atteluMasiv[19].transform.localScale = new Vector2(  pasreizajaVertiba, y);
        atteluMasiv[20].transform.localScale = new Vector2(  pasreizajaVertiba, y);
    }

    public void mainitGarumu()
    {
        float pasreizajaVertibaa = ySlaiders.GetComponent<Slider>().value;
        
        y = pasreizajaVertibaa ; 
        atteluMasiv[0].transform.localScale = new Vector2(x,  pasreizajaVertibaa);
        atteluMasiv[1].transform.localScale = new Vector2(x,  pasreizajaVertibaa);
        atteluMasiv[2].transform.localScale = new Vector2(x,   pasreizajaVertibaa);
        atteluMasiv[3].transform.localScale = new Vector2(x,   pasreizajaVertibaa);
        atteluMasiv[4].transform.localScale = new Vector2(x,   pasreizajaVertibaa);
        atteluMasiv[5].transform.localScale = new Vector2(x,   pasreizajaVertibaa);
        atteluMasiv[6].transform.localScale = new Vector2(x,   pasreizajaVertibaa);
        atteluMasiv[7].transform.localScale = new Vector2(x,   pasreizajaVertibaa);
        atteluMasiv[8].transform.localScale = new Vector2(x,   pasreizajaVertibaa);
        atteluMasiv[9].transform.localScale = new Vector2(x,   pasreizajaVertibaa);
        atteluMasiv[10].transform.localScale = new Vector2(x,   pasreizajaVertibaa);
        atteluMasiv[11].transform.localScale = new Vector2(x,   pasreizajaVertibaa);
        atteluMasiv[12].transform.localScale = new Vector2(x,   pasreizajaVertibaa);
        atteluMasiv[13].transform.localScale = new Vector2(x,   pasreizajaVertibaa);
        atteluMasiv[14].transform.localScale = new Vector2(x,   pasreizajaVertibaa);
        atteluMasiv[15].transform.localScale = new Vector2(x,   pasreizajaVertibaa);
        atteluMasiv[16].transform.localScale = new Vector2(x,   pasreizajaVertibaa);
        atteluMasiv[17].transform.localScale = new Vector2(x,   pasreizajaVertibaa);
        atteluMasiv[18].transform.localScale = new Vector2(x,   pasreizajaVertibaa);
        atteluMasiv[19].transform.localScale = new Vector2(x,   pasreizajaVertibaa);
        atteluMasiv[20].transform.localScale = new Vector2(x,   pasreizajaVertibaa);




    }

}
