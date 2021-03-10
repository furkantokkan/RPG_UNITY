using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBasicAttack : MonoBehaviour
{
    public float damage = 10;

    private void OnTriggerEnter(Collider other)
    {
        EnemyHealth enemyHealth = other.GetComponent<EnemyHealth>();
  
        if (enemyHealth != null)
        {
            enemyHealth.TakeDamage(damage);
        }
    }
}
