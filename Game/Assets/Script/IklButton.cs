using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IklButton : MonoBehaviour {



    public GameObject BlueOneImg;
    public GameObject GreenOneImg;


    public void Uzkl(bool vertiba)
    {
        BlueOneImg.SetActive(vertiba);
    }
    public void Neuzkl(bool vertiba)
    {
       GreenOneImg.SetActive(vertiba);
    }

}
