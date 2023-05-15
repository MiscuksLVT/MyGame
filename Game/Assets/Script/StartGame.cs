using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using JetBrains.Annotations;
using System.Threading;
using UnityEngine.SceneManagement;


public class StartGame : MonoBehaviour {
    private string Vards;
    private int vec;
    public GameObject ievadesLauksText;
    public GameObject ievadesLauksVec;
    public GameObject tekstaAttelosana;
    private string[] fragmentiVec = { "Years", "Gadi", "Godikov"};
    private string[] fragmenti = { "Viss stiprakais ", " Luzers ", "'PRO99LVL'"};
    int index;
    public void UzglabatTekstu()
    {
        int x = 0;
      
          index = Random.Range(0, fragmenti.Length);
            Vards = ievadesLauksText.GetComponent<InputField>().text;
        if (!string.IsNullOrEmpty(ievadesLauksText.GetComponent<InputField>().text.Trim()) || !int.TryParse(ievadesLauksText.GetComponent<InputField>().text, out x))
        {

            tekstaAttelosana.GetComponent<Text>().text = "Ievadi ar Cipariem(no10 lidz 60)";

        } 

            vec = int.Parse(ievadesLauksVec.GetComponent<InputField>().text);
        if (vec < 10 || vec > 60)
        {
            vec = x;
            tekstaAttelosana.GetComponent<InputField>().text = "";

    


        }
        else
        {

            tekstaAttelosana.GetComponent<Text>().text = fragmenti[index] + " " + Vards + " - " + vec + " " + fragmentiVec[index];

        }

        }
    


    public void Uzaskums()
    {

        SceneManager.LoadScene("Sakums", LoadSceneMode.Single);
    }

    //Metode,kura aizver programmu, ja ta ir izveidota ka .exe

    public void Apturet()
    {
        Debug.Log("Quit is working");
        Application.Quit();
    }

    //Pasiem jauztaisa metode,kas parsledzno sakuma uz UI ainu
    public void Game()
    {
        Thread.Sleep(1000);
        SceneManager.LoadScene("CreatePers", LoadSceneMode.Additive);

    }


}