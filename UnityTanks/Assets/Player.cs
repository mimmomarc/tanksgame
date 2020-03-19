using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public int maxHealth = 100;
    public int currentHealt ;
    public HealthBar healthBar;
    public Animator animator;

    void Start()
    {
        currentHealt = maxHealth;
        if (healthBar != null)
        {
            healthBar.setMaxHealth(maxHealth);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealt == 0)
        {
            animator.Play("DestroyPlayer");
            Invoke("Distruggi", 0.5f);
        }
        
    }

    public void Damage(int value)
    {
        healthBar.decrementHealth(value);
        currentHealt = currentHealt - value;
    }

    void Distruggi()
    {
        Destroy(gameObject);
    }

}
