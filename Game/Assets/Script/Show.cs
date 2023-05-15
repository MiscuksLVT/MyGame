using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class Show : MonoBehaviour {

    public GameObject weapon;
    public GameObject BABAOdad;
   public GameObject golova1;
    public GameObject golova2;
    public GameObject golova3;
    public GameObject golova4;
    public GameObject golova5;
    public GameObject golova6;
    public GameObject golova7;
    public GameObject golova8;
    public GameObject head1;
    public GameObject head2;
    public GameObject head3;
    public GameObject head4;
    public GameObject head5;
    public GameObject head6;
    public GameObject head7;
    public GameObject head8;
    public GameObject svit1;
    public GameObject svit2;
    public GameObject svit3;
    public GameObject svit4;
    public GameObject svit5;
    public GameObject svit6;
    public GameObject svit7;
    public GameObject svit8;
    public GameObject wtani1;
    public GameObject wtani2;  
    public GameObject wtani3;
    public GameObject wtani4;
    public GameObject wtani5;
    public GameObject wtani6;
    public GameObject wtani7;
    public GameObject wtani8;
    public GameObject tagi1;
    public GameObject tagi2;
    public GameObject tagi3;
    public GameObject tagi4;
    public GameObject tagi5;
    public GameObject tagi6;
    public GameObject tagi7;
    public GameObject tagi8;
    public Sprite[] atteluMasiva;

    public void WeaponShow(bool vertiba)
    {
     
        BABAOdad.SetActive(vertiba);
        weapon.SetActive(vertiba);
    }



    public void golovaShow(bool vertiba)
    {



        golova1.SetActive(vertiba);
        golova2.SetActive(vertiba);
       golova3.SetActive(vertiba);
        golova4.SetActive(vertiba);
        golova5.SetActive(vertiba);
        golova6.SetActive(vertiba);
       golova7.SetActive(vertiba);
    golova8.SetActive(vertiba);

    }
    public void headShow(bool vertiba)
    {



        head1.SetActive(vertiba);
        head2.SetActive(vertiba);
        head3.SetActive(vertiba);
            
        head4.SetActive(vertiba);
            
        head5.SetActive(vertiba);
        head6.SetActive(vertiba);
        head7.SetActive(vertiba);
        head8.SetActive(vertiba);

    
    }
    public void svitShow(bool vertiba)
    {



        svit1.SetActive(vertiba);
            
        svit2.SetActive(vertiba);
        svit3.SetActive(vertiba);
        svit4.SetActive(vertiba);
            
        svit5.SetActive(vertiba);
        svit6.SetActive(vertiba);
            
        svit7.SetActive(vertiba);
        svit8.SetActive(vertiba);
   


    }
    public void wtaniShow(bool vertiba)
    {



        wtani1.SetActive(vertiba);
        wtani2.SetActive(vertiba);
        wtani3.SetActive(vertiba);
            wtani4.SetActive(vertiba);
        wtani5.SetActive(vertiba);
        wtani6.SetActive(vertiba);
            
        wtani7.SetActive(vertiba);
            wtani8.SetActive(vertiba);


    }
    public void tagiShow(bool vertiba)
    {



        tagi1.SetActive(vertiba);   
        tagi2.SetActive(vertiba);
        tagi3.SetActive(vertiba);
        tagi4.SetActive(vertiba);
        tagi5.SetActive(vertiba);
        tagi6.SetActive(vertiba);
        tagi7.SetActive(vertiba);
        tagi8.SetActive(vertiba);

       

    }
}
