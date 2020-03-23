using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject barLegni;
    Vector3 Sinistra, Centro, Destra;
    Quaternion Fix;
    
   
    void Start()
    {


       

        
        Sinistra = new Vector3(1f, Random.Range(-4.3f, 4.3f),0f);
        Centro = new Vector3(4f, Random.Range(-4.3f, 4.3f), 0f);
        Destra = new Vector3(7f, Random.Range(-4.3f, 4.3f), 0f);
        Fix = new Quaternion(0f, 0f, 0f,0f);



        //Recupero le info del livello
        Livello livello = GestoreLivelli.getLivello(2);
        Livello.InfoBarriere info = livello.DammiInfoBarriere();


        if (info.siPuòCostruireASinistra())
        {
            Instantiate(barLegni, Sinistra, Fix);

        }

        if (info.siPuòCostruireAlCentro())
        {
            Instantiate(barLegni, Centro, Fix);

        }

        if(info.siPuòCostruireADestra())
        {
            Instantiate(barLegni, Destra, Fix);

        }




    }






    // Update is called once per frame
    void Update()
    {
       
    }
}
