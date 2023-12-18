using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public Stat damage;
    public Stat maxHealth;
    public Stat strength;

    private float currentHealth;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void takeDamage(float damage)
    {
        currentHealth -= damage;

        if (currentHealth <=0)
        {
            Die();
        }
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
