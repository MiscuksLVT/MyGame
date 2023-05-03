using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;


public class MainitLielumu : MonoBehaviour {


    public GameObject xSaiders;
    public GameObject ySlaiders;
    public GameObject mainigaisAttles;
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
