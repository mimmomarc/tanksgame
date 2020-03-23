using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Livello
{


    private InfoBarriere infoBarriere = null;
    int numero;





    public Livello(int numero)
    {
        this.numero = numero;
        this.infoBarriere = new InfoBarriere();
       

    }

    /// <summary>
    /// Questo metodo deve essere usato all'interno degli script che gestiscono le barriere.
    /// Restituisce un tipo InfoBarriere dal quale si possono gestire le info delle barriere.
    /// </summary>
    /// <returns>InfoBarriere</returns>
    public InfoBarriere DammiInfoBarriere()
    {
        return this.infoBarriere;
    }


    /// <summary>
    /// Restituisce il numero del livello attuale
    /// </summary>
    /// <returns>Intero</returns>
    public int getNumero()
    {
        return this.numero;
    }


    /// <summary>
    /// Questo metodo si occupa di modificare i dati in InfoBarriere , precisamente assegna true alla possibilità di creare la barriera Sinistra
    /// </summary>
    public void creaBarrieraSinistra()
    {
        infoBarriere.setBarrieraSinistra(true);
    }



    /// <summary>
    /// Questo metodo si occupa di modificare i dati in InfoBarriere , precisamente assegna true alla possibilità di creare la barriera Sinistra
    /// </summary>
    public void creaBarrieraDestra()
    {
        infoBarriere.setBarrieraDestra(true);
    }



    /// <summary>
    /// Questo metodo si occupa di modificare i dati in InfoBarriere , precisamente assegna true alla possibilità di creare la barriera Sinistra
    /// </summary>
    public void creaBarrieraCentro()
    {
        infoBarriere.setBarrieraCentro(true);
    }



    public class InfoEnemy
    {


    }

    /// <summary>
    /// La classe che gestisce le info delle Barriere , da usare all'interno degli script che gestiscono il movimento e comportamento delle barriere 
    /// </summary>
    public class InfoBarriere
    {
        private Barriera BarSinistra = null;
        private Barriera BarDestra = null;
        private Barriera BarCentro = null;

       public InfoBarriere()
        {
            BarSinistra = new Barriera(false);
            BarDestra = new Barriera(false);
            BarCentro = new Barriera(false);
        }

        public void  setBarrieraSinistra(bool esistenza)
        {
            BarSinistra.setEsistenza(esistenza);
        }

       public void setBarrieraDestra(bool esistenza)
        {
            BarDestra.setEsistenza(esistenza);
        }

        public void setBarrieraCentro(bool esistenza)
        {
            BarCentro.setEsistenza(esistenza);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>True se si può costruire , False altrimenti</returns>
        public bool siPuòCostruireASinistra()
        {
            return BarSinistra.esistenza();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>True se si può costruire , False altrimenti</returns>
        public bool siPuòCostruireADestra()
        {
            return BarDestra.esistenza();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>True se si può costruire , False altrimenti</returns>
        public bool siPuòCostruireAlCentro()
        {
            return BarCentro.esistenza();
        }



    }


  

    private class Barriera  
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

