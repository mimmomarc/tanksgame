using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public string mittente=null;
    public float speed = 20f;
    public int damage=5;
    public Rigidbody2D rb;
    public Animator animator;
    bool fallo = true;
    //Il proiettile appena si crea assume una velocità difinita da speed e da direzione transorm.up
    void Start()
    {
        rb.velocity = transform.up * speed;
       
    }

    private void Update()
    {
       if (mittente != null && fallo)
        {
           
            fallo = false;
        }
    }

    public void setMittente(string mittente)
    {
        this.mittente = mittente;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.transform.position.x > 0 && collision.tag == "Barrier" &&this.mittente=="Player")
        {
            Esplosione();
           
        }
        else if (collision.gameObject.transform.position.x < 0 && collision.tag == "Barrier" && this.mittente == "Enemy")
        {
            Esplosione();
        }
        else if (collision.gameObject.tag=="Player" && this.mittente == "Enemy")
        {

            collision.gameObject.GetComponent<Player>().Damage(damage);
            Esplosione(); 

        }
        else if(collision.gameObject.tag == "Enemy" && this.mittente == "Player")
        {
            Esplosione();

        }

    }

    void Esplosione()
    {
        rb.velocity = new Vector2(0, 0);
        animator.Play("EsplosioneProiettile");
        Invoke("DestroyObj", 0.4f);
        

        
    }
    void DestroyObj()
    {
        Destroy(gameObject);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        

        if(collision.tag == "LimitArea")
        {
            DestroyObj();
            
        }


        
    }


}  
