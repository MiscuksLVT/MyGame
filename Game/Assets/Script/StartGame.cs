using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Threading;
public class StartGame : MonoBehaviour {

    public void Uzaskums()
    {
      
        SceneManager.LoadScene("Sakums", LoadSceneMode.Single);
    }

    //Metode,kura aizver programmu, ja ta ir izveidota ka .exe

    public void Apturet()
    {
		Debug.Log ("Quit is working");
        Application.Quit();
    }

    //Pasiem jauztaisa metode,kas parsledzno sakuma uz UI ainu
    public void Game()
    {
		Thread.Sleep(1000);
        SceneManager.LoadScene("CreatePers", LoadSceneMode.Additive);

    }
}