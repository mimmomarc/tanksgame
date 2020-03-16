﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sparo : MonoBehaviour
{
    bool spara;
    bool conteggioEseguito ;
    float seconds;
    float timer , prova;
    public float delaySeconds;
    public Transform firePoint;
    public GameObject bulletPrefab;
    

    void Start()
    {
        spara = false;
        conteggioEseguito = true;
    }

    void Update()
    {


       //se stai cliccando e il tempo necessario è trascorso
       if(spara && conteggioEseguito)
        {
            //Crea un nuovo proiettile
            Shoot();
            //Il conteggio dovrà ripartire
            conteggioEseguito = false;
            //si parte da 0
            seconds = 0 ;
            timer = 0;
        }
       
       //parte il conteggio (anche se il bottone viene rilasciato e la variabile bool spara andrà su true 
       //comunque il conteggio dovrà continuare fino a quando non si raggiungono i 5 secondi
       if(conteggioEseguito==false)
        {
            timer += Time.deltaTime;
            seconds = timer;
            if (seconds > delaySeconds)
            {
                conteggioEseguito = true;
               
            }
           

        }

    }

    //Gestisce cosa succede quando si clicca sul bottone
    public void pointerDown()
    {
        spara = true;
    }


    //Gestisce cosa succede quando si lascia il bottone
    public void pointerUp()
    {
        spara = false;
    }

    //Il metodo che si occupa di gestire la creazione dei nuovi proiettili 
    void Shoot()
    {

        Instantiate(bulletPrefab, firePoint.position,firePoint.rotation);
    }

}
