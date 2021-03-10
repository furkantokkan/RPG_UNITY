using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkillDamage : MonoBehaviour
{
    public LayerMask enemyLayer;
    public float radius = 0.5f;
    public float damageCount = 10f;
    private EnemyHealth enemyHealth;
    private PlayerHealth playerHealth;
    protected bool colided;
   internal virtual void Update()
    {
        Collider[] hits = Physics.OverlapSphere(transform.position, radius,enemyLayer);
        foreach (Collider hit in hits)
        {
            if (enemyLayer == (1 << LayerMask.NameToLayer("Enemy")))
            {
                enemyHealth = hit.gameObject.GetComponent<EnemyHealth>();
                colided = true;
            }
            else if (enemyLayer == (1 << LayerMask.NameToLayer("Player")))
            {
                playerHealth = hit.gameObject.GetComponent<PlayerHealth>();
                colided = true;
            }
            if (colided)
            {
                if (enemyLayer == (1 << LayerMask.NameToLayer("Enemy")))
                {
                    if (enemyHealth != null)
                    {
                        enemyHealth.TakeDamage(damageCount);
                        enabled = false;
                    }
                }
                else if (enemyLayer == (1 << LayerMask.NameToLayer("Player")))
                {
                    if (playerHealth != null)
                    {
                        playerHealth.TakeDamage(damageCount);
                        enabled = false;
                    }
                }
            }
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position,radius);
    }

}
