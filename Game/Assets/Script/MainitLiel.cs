using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class MainitLiel : MonoBehaviour {


    public GameObject mainigaisAttles;
    public Sprite[] atteluMasiva;
    public GameObject xSlaiders;
    public GameObject ySlaiders;



    public void izkritosais(int skaitlis)
    {
        if (skaitlis == 0)
            mainigaisAttles.GetComponent<Image>().sprite = atteluMasiva[0];
        else if (skaitlis == 1)
            mainigaisAttles.GetComponent<Image>().sprite = atteluMasiva[1];
        else if (skaitlis == 2)
            mainigaisAttles.GetComponent<Image>().sprite = atteluMasiva[2];
        else Debug.Log("Nav piesaistits attels!");
    }





    public void mainitLielumu()
    {
        float pasreizajaVertiba = xSlaiders.GetComponent<Slider>().value;
        mainigaisAttles.transform.localScale = new Vector2(1f * pasreizajaVertiba, 0);
    }
    public void mainiRotaciju()
    {
        float pasreizajaVertiba = ySlaiders.GetComponent<Slider>().value;
        mainigaisAttles.transform.localScale = new Vector2(0, 1f * pasreizajaVertiba);
    }
}
