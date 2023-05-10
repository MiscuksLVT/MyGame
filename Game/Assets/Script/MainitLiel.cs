using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class MainitLiel : MonoBehaviour {


    public GameObject mainigaisAttles;
   
    public GameObject xSlaiders;
    public GameObject ySlaiders;
    public GameObject[] atteluMasiv;


  



    public void mainitLielumu()
    {
       
        float pasreizajaVertiba = xSlaiders.GetComponent<Slider>().value;
        atteluMasiv[0].transform.localScale = new Vector2(1f * pasreizajaVertiba, 1);
  
    }
    public void mainiRotaciju()
    {
        float pasreizajaVertiba = ySlaiders.GetComponent<Slider>().value;
        atteluMasiv[0].transform.localScale = new Vector2(1, 1f * pasreizajaVertiba);
    }
}
