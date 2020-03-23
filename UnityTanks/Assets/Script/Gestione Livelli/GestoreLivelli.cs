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

        if(livello == 3)
        {
            return livello3();
        }

        throw new System.Exception("Il livello non esiste");
    }
    
    public static Livello livello1()
    {
        Livello livello1;
        livello1 = new Livello(1);
        livello1.creaBarrieraSinistra();
        
        
        
        return livello1;
       

       
    }

    public static Livello livello2()
    {
        Livello livello2 = new Livello(2);
        livello2.creaBarrieraCentro();
        livello2.creaBarrieraSinistra();
        return livello2;
    }

    public static Livello livello3()
    {
        Livello livello3 = new Livello(3);
        livello3.creaBarrieraCentro();
        livello3.creaBarrieraDestra();
        livello3.creaBarrieraSinistra();
        return livello3;
    }

}
