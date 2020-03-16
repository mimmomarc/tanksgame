using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 20f;
    public Rigidbody2D rb;
    //Il proiettile appena si crea assume una velocità difinita da speed e da direzione transorm.up
    void Start()
    {
        rb.velocity = transform.up * speed;
    }

    
}  
