using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GestoreLivelli
{

    public static Livello getLivello(int livello)
    {
        if(livello == 1)
        {
            return livello1();
        }

        if(livello == 2)
        {
            return livello2();
        }


        throw new System.Exception("Il livello non esiste");
    }
    
    public static Livello livello1()
    {
        Livello livello1 = null;
        

        livello1 = new Livello(1);
        livello1.creaBarrieraSinistra();
        livello1.creaBarrieraDestra();
        return livello1;
       

       
    }

    public static Livello livello2()
    {
        Livello livello2 = new Livello(2);
        livello2 = new Livello(1);
        livello2.creaBarrieraSinistra();
        livello2.creaBarrieraDestra();
        livello2.creaBarrieraCentro();
        return livello2;
    }

}
