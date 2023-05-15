using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChangeImage : MonoBehaviour {
    public Sprite[] atteluMasivs;
    public GameObject MAttles;

    public void izkritosais(int skaitlis)
    {
        if (skaitlis == 0)
            MAttles.GetComponent<Image>().sprite = atteluMasivs[0];
        else if (skaitlis == 1)
            MAttles.GetComponent<Image>().sprite = atteluMasivs[1];
        else if (skaitlis == 2)
            MAttles.GetComponent<Image>().sprite = atteluMasivs[2];
        else if (skaitlis == 3)
            MAttles.GetComponent<Image>().sprite = atteluMasivs[3];
        else if (skaitlis == 4)
            MAttles.GetComponent<Image>().sprite = atteluMasivs[4];
        else Debug.Log("Nav piesaistits attels!");
    }
}
