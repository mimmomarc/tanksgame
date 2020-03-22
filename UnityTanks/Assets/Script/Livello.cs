using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Livello
{

    public Barriera BarSinistra = null;
    public Barriera BarDestra = null;
    public Barriera BarCentro = null ;
    int numero;





    public Livello(int numero)
    {
        this.numero = numero;
        BarSinistra = new Barriera(false);
        BarDestra = new Barriera(false);
        BarCentro = new Barriera(false);

    }



    public void creaBarrieraSinistra()
    {
        BarSinistra.setEsistenza(true);
    }

    public void creaBarrieraDestra()
    {
        BarDestra.setEsistenza(true);
    }

    public void creaBarrieraCentro()
    {
        BarCentro.setEsistenza(true);
    }
    
    public bool SiPuòCostruire (int n)
    {
        if (n == 1)
        {
            return BarSinistra.esistenza();
        }else if (n == 2)
        {
            return BarCentro.esistenza();
        }else if (n == 3)
        {
            return BarDestra.esistenza();
        }

        throw new System.Exception("Il valore inserito deve essere 1 , 2 o 3 per Sinistra , Centro e Destra");

        
    }

    public class InfoEnemy
    {


    }


    public int getNumero()
    {
        return this.numero;
    }

    public class Barriera  
    {
        bool ciDeveEssere = false;
        public Barriera(bool ciDeveEssere)
        {
            this.ciDeveEssere = ciDeveEssere;
        }

        public bool esistenza()
        {
            return this.ciDeveEssere;
        }

        public void setEsistenza(bool es)
        {
            this.ciDeveEssere = es;
        }


    }


}

