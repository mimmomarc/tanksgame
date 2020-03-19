using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerDestinazione : MonoBehaviour
{

    float randomX =0f, randomy=0f;
    public const float riduciLimiteArea = 0.5f;
    public Collider2D areaCollider=null;

    //Definiscono l'area di movimento del nemico , il bordoSinistro è il centro dello schermo

     float bordoDestro;
     float bordoSinistro;
     float bordoSuperiore;
     float bordoInferiore;
    Vector2 targetPosition;
    
    // Start is called before the first frame update
    void Start()
    {

        if (areaCollider != null)
        {
            bordoDestro = areaCollider.bounds.extents.x-riduciLimiteArea;
            bordoSinistro = 0+riduciLimiteArea;
            bordoInferiore = -areaCollider.bounds.extents.y+riduciLimiteArea;
            bordoSuperiore = areaCollider.bounds.extents.y-riduciLimiteArea;

           // Debug.Log(minX + " " + maxX + " " + minY + " " + maxY);

            randomX = Random.Range(bordoSinistro, bordoDestro);
            randomy = Random.Range(bordoInferiore, bordoSuperiore);
            targetPosition = new Vector2(randomX, randomy);
            gameObject.transform.position = targetPosition;
           
        }
        else
        {
            throw new System.Exception("Inserire l'area limite di movimento per il nemico");
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }


    Vector2 dammiPosizioneCasuale() {
        randomX = Random.Range(bordoSinistro, bordoDestro);
        randomy = Random.Range(bordoInferiore, bordoSuperiore);
        Vector2 randomPos = new Vector2(randomX, randomy);
        return randomPos;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            gameObject.transform.position = dammiPosizioneCasuale();
        }
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {
            gameObject.transform.position = dammiPosizioneCasuale();
        }
    }
}
