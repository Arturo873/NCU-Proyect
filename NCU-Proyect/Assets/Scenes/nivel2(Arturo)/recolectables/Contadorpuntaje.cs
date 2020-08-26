﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Contadorpuntaje : MonoBehaviour
{
    public static Contadorpuntaje instance;
    public TextMeshProUGUI cantidadCarpetas;
    public TextMeshProUGUI cantidadmonedas;
    public TextMeshProUGUI cantidadLlaves;
    int cantidadC;
    int cantidadM;
    int cantidadL;

    
    void Awake()
    {
        /*
        
        if (instance == null)
        {

            instance = this;
            DontDestroyOnLoad(gameObject);


        }
        else if (instance != this)
        {
            Destroy(gameObject);

        }
        */

    }
    
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;

        }
        /*
        cantidadC = PlayerPrefs.GetInt("carpeta", 0);
        cantidadM = PlayerPrefs.GetInt("moneda", 0);
        cantidadL = PlayerPrefs.GetInt("llave", 0);


        */

        cantidadCarpetas.text = PlayerPrefs.GetInt("carpeta", 0).ToString();
        cantidadmonedas.text = PlayerPrefs.GetInt("moneda", 0).ToString();
        cantidadLlaves.text = PlayerPrefs.GetInt("llave", 0).ToString() + " /4";
    }

    public void ChangeScore(int recolectado, string nombre)
    {
        if (nombre == "carpeta")
        {
            cantidadC = PlayerPrefs.GetInt("carpeta", 0)+ recolectado;
            PlayerPrefs.SetInt("carpeta", cantidadC);
            cantidadCarpetas.text = PlayerPrefs.GetInt("carpeta", 0).ToString();
        }
        else
        {
            if (nombre == "moneda")
            {
                cantidadM = PlayerPrefs.GetInt("moneda", 0)+ recolectado;
                PlayerPrefs.SetInt("moneda", cantidadM);
                cantidadmonedas.text = cantidadM.ToString();

            }
            else
            {

                cantidadL = PlayerPrefs.GetInt("llave", 0)+ recolectado;
                PlayerPrefs.SetInt("llave", cantidadL);
                cantidadLlaves.text = cantidadL.ToString()+" /4";

            }
            
        }
    }
}