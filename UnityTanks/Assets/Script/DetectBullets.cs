using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectBullets : MonoBehaviour
{
    GameObject proiettile;
    bool entra = true;
    // Start is called before the first frame update
    void Start()
    {
        //GameObject[] proiettili = new GameObject[10];
        GameObject proiettile = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (proiettile != null)
        {
            Debug.Log(proiettile.transform.position.x);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        


        if (collision.tag == "Bullet" )
        {

            if (entra)
            {
                proiettile = collision.gameObject;
                entra = false;
            }

        }
    }
}
