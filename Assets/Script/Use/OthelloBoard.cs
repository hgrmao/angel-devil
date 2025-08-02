using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;


public class OthelloBoard : MonoBehaviour
{
    #region//���E�̃L�����N�^�[�Љ�
    public GameObject Vehuiah;
    public GameObject Bael;
    public GameObject Yeliel;
    public GameObject Agares;
    public GameObject Sitael;
    public GameObject Vasago;
    public GameObject Elemiah;
    public GameObject Gamigin;
    public GameObject Mahasiah;
    public GameObject Marbas;
    public GameObject Lelahel;
    public GameObject Valefar;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        

    }

    void OnEnable()
    {
        
        

    }

    
    public void Button1()
    {
        Vehuiah.SetActive(true);
        Bael.SetActive(true);
        Yeliel.SetActive(false);
        Agares.SetActive(false);

        Sitael.SetActive(false);
        Vasago.SetActive(false);
        Elemiah.SetActive(false);
        Gamigin.SetActive(false);

        Mahasiah.SetActive(false);
        Marbas.SetActive(false);
        Lelahel.SetActive(false);
        Valefar.SetActive(false);

        
    }

    public void Button2()
    {
        Vehuiah.SetActive(false);
        Bael.SetActive(false);
        Yeliel.SetActive(true);
        Agares.SetActive(true);

        Sitael.SetActive(false);
        Vasago.SetActive(false);
        Elemiah.SetActive(false);
        Gamigin.SetActive(false);

        Mahasiah.SetActive(false);
        Marbas.SetActive(false);
        Lelahel.SetActive(false);
        Valefar.SetActive(false);

        
    }

    public void Button3()
    {
        Vehuiah.SetActive(false);
        Bael.SetActive(false);
        Yeliel.SetActive(false);
        Agares.SetActive(false);

        Sitael.SetActive(true);
        Vasago.SetActive(true);
        Elemiah.SetActive(false);
        Gamigin.SetActive(false);

        Mahasiah.SetActive(false);
        Marbas.SetActive(false);
        Lelahel.SetActive(false);
        Valefar.SetActive(false);

        
    }

    public void Button4()
    {
        Vehuiah.SetActive(false);
        Bael.SetActive(false);
        Yeliel.SetActive(false);
        Agares.SetActive(false);

        Sitael.SetActive(false);
        Vasago.SetActive(false);
        Elemiah.SetActive(true);
        Gamigin.SetActive(true);

        Mahasiah.SetActive(false);
        Marbas.SetActive(false);
        Lelahel.SetActive(false);
        Valefar.SetActive(false);

       
    }

    public void Button5()
    {
        Vehuiah.SetActive(false);
        Bael.SetActive(false);
        Yeliel.SetActive(false);
        Agares.SetActive(false);

        Sitael.SetActive(false);
        Vasago.SetActive(false);
        Elemiah.SetActive(false);
        Gamigin.SetActive(false);

        Mahasiah.SetActive(true);
        Marbas.SetActive(true);
        Lelahel.SetActive(false);
        Valefar.SetActive(false);

        
    }

    public void Button6()
    {
        Vehuiah.SetActive(false);
        Bael.SetActive(false);
        Yeliel.SetActive(false);
        Agares.SetActive(false);

        Sitael.SetActive(false);
        Vasago.SetActive(false);
        Elemiah.SetActive(false);
        Gamigin.SetActive(false);

        Mahasiah.SetActive(false);
        Marbas.SetActive(false);
        Lelahel.SetActive(true);
        Valefar.SetActive(true);

        
    }
}
