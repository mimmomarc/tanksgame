using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarMovement : MonoBehaviour {
    
    public float velocity = 100f;
    

    //variabile utilizzate per gestire la velocità dopo il blocco della barriera
    
    public float direction = 1;
    public bool canMove = true;


    Rigidbody2D rb;
    

    // Start is called before the first frame update
    void Start()
    {
        if (Random.value >= 0.5f)
        {
            direction = 1;
        }
        else
        {
            direction = -1;
        }
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //rb.AddForce(new Vector2(0,velocity*direction*Time.deltaTime) , ForceMode2D.Impulse);
        if (canMove)
        {
            
            rb.velocity = new Vector2(0, velocity * direction);
        }
        else
        {
            rb.velocity = new Vector2(0, 0);

        }
       

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "LimitArea")
        {
            if (direction == 1)
            {
                direction = -1;
            }
            else
            {
                direction = 1;
            }
        }


        if (collision.collider.tag == "Player")
        {
            if (collision.contacts[0].normal.y == 1 || collision.contacts[0].normal.y == -1)
            {
                
                canMove = false;
            }
        }



    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            if (collision.contacts[0].normal.y == 1 || collision.contacts[0].normal.y == -1)
            {
                
                canMove = false;
            }
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player") { 
           

            canMove = true;
            
        }

    }


}
