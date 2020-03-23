using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class mainmenù: MonoBehaviour {


    private const string MENU_INIZIA = "MenuIniziale";
    private const string MODALITA_AVVENTUA = "SampleScene";
    private const string SELEZIONA_LIVELLO_AVVENTURA = "SelezionaLivelloAvv";

    private void Awake()
    {
        //Per il suono
        FindObjectOfType<AudioManager>().Play("Sottofondo");
    }

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


    public void SelezionaLivello(int level)
    {
        PlayerPrefs.SetInt("LivelloAttuale", level);
        PlayModalitaAvventura();
    }

    public void QuitGame()
    {
        
        Application.Quit();




    }


}
