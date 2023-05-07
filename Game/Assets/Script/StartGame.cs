using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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
      
      
            index = Random.Range(0, fragmenti.Length);
            Vards = ievadesLauksText.GetComponent<InputField>().text;
       tekstaAttelosana.GetComponent<Text>().text = fragmenti[index] + Vards.ToUpper() + "!";


    }
    public void UzglabatVecums()
    {
        vec = int.Parse(ievadesLauksVec.GetComponent<InputField>().text);
        tekstaAttelosana.GetComponent<Text>().text = fragmentiVec[index] + " " + vec + " " + fragmenti[index];

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