using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityStandardAssets.CrossPlatformInput; necessita del framework di riferimento




//In questo script è gestito il movimento , nell'update c'è il movimento utilizzato , sotto ad update sono presenti dei metodi alternativi utilizzati con altre componenti.
public class Controller : MonoBehaviour
{
    public Animator animator;
    public Joystick joystick;
    public float speed;
    float horizontal , vertical;
    //Indica il minimo valore che sereve per far muovere il personaggio in una direzione
    const float SOGLIA_MOVIMENTO = 0.5f;
    Rigidbody2D n_rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        
        n_rigidbody = GetComponent<Rigidbody2D>();
        horizontal = 0;
        vertical = 0;
    }

    
    void Update()
    {

        //Questa gestione del movimento permette al personaggio di muoversi in direzioni parallele all'asse delle x e delle y , mai in diagonale.

        horizontal = joystick.Horizontal;
        vertical = joystick.Vertical;
        
        if(horizontal > SOGLIA_MOVIMENTO || horizontal<-SOGLIA_MOVIMENTO)
        {
           
            n_rigidbody.velocity = new Vector2( horizontal * speed * Time.deltaTime , 0 );
            animator.SetFloat("Speed",Mathf.Abs( n_rigidbody.velocity.x));
        
        }else if (vertical>SOGLIA_MOVIMENTO|| vertical < -SOGLIA_MOVIMENTO)
        {
          
            n_rigidbody.velocity = new Vector2(0,vertical * speed * Time.deltaTime);
            animator.SetFloat("Speed", Mathf.Abs(n_rigidbody.velocity.y));
        }
        else
        {
            animator.SetFloat("Speed", 0f);

            n_rigidbody.velocity = new Vector2(0,0);
        }


    }

    void controlWithRow()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            n_rigidbody.velocity = new Vector2(speed, 0);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            n_rigidbody.velocity = new Vector2(-speed, 0);
        }
        else
        {
            n_rigidbody.velocity = new Vector2(0, 0);
        }
    }



    /* Gestione del movimento con il framewok UnityStandardAssets.CrossPlatformInput
    void controlWithUIButton()
    {

        if (CrossPlatformInputManager.GetAxis("Right") > 0)
        {

            n_rigidbody.velocity = new Vector2(speed, 0);
            Debug.Log("Destra");



        }



        if (CrossPlatformInputManager.GetAxis("Left") < 0)
        {

            n_rigidbody.velocity = new Vector2(-speed, 0);
            Debug.Log("Sinistra");


        }
        if (CrossPlatformInputManager.GetAxis("Right") == 0 && CrossPlatformInputManager.GetAxis("Left") == 0)
        {
            n_rigidbody.velocity = new Vector2(0, 0);
        }

        if (CrossPlatformInputManager.GetAxis("Right") > 0 && CrossPlatformInputManager.GetAxis("Left") < 0)
        {
            n_rigidbody.velocity = new Vector2(0, 0);
        }

        if (CrossPlatformInputManager.GetAxis("Up") > 0)
        {
            n_rigidbody.velocity = new Vector2(0, speed);
        }

        if (CrossPlatformInputManager.GetAxis("Down") < 0)
        {
            n_rigidbody.velocity = new Vector2(0, -speed);
        }

        if (CrossPlatformInputManager.GetAxis("Up") > 0 && CrossPlatformInputManager.GetAxis("Down") < 0)
        {
            n_rigidbody.velocity = new Vector2(0, 0);
        }
    }
        */
}
