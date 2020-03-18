using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausemenù : MonoBehaviour
{
    //public static bool giocoinpausa = false; 
   

    // Update is called once per frame
    public void Pausa()
    {
       
            Time.timeScale =0f;
            
        
    }
    public void Riprendi()
    {
        Time.timeScale = 1f;
    }

    public void quit()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("menù");
        

    }
}


