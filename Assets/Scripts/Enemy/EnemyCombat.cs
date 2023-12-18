using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCombat : MonoBehaviour
{
    public float attackSpeed = 1f;
    public float attackCooldown = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        attackCooldown -= Time.deltaTime;
    }

    public void Attack(CharacterStats targetStat)
    {
        if (attackCooldown <=0)
        {
            targetStat.takeDamage(5f);
            attackCooldown = 1f/attackSpeed;            
        }
    }
}
