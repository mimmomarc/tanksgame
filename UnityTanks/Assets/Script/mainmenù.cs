using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class mainmenù: MonoBehaviour {


    private const string MENU_INIZIA = "MenuInizia";
    private const string MODALITA_AVVENTUA = "SampleScene";
    private const string SELEZIONA_LIVELLO_AVVENTURA = "SelezionaLivello";

    public void Playgame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);




    }


    public void PlayMenuInizia()
    {
        SceneManager.LoadScene(MENU_INIZIA);
    }

    public void PlayModalitaAvventura()
    {
        SceneManager.LoadScene(MODALITA_AVVENTUA);
    }

    public void PlaySelezionaLivelloAvventura()
    {
        SceneManager.LoadScene(SELEZIONA_LIVELLO_AVVENTURA);
    }


    public void QuitGame()
    {
        
        Application.Quit();




    }


}
