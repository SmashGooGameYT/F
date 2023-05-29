using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class AttackPlayer : MonoBehaviour
{
    public float damage = 1;
    public LayerMask EnemyLayer;
    public Transform DamageZone;
    public float Range = 1f;


    void Damage()
    {
        Collider2D[] HitEnemies = Physics2D.OverlapCircleAll(DamageZone.position, Range, EnemyLayer);
        foreach (Collider2D enemy in HitEnemies)
        {
            enemy.GetComponent<HPenemy>().TakeDamage(damage);
        }
    }



    void OnDrawGizmosSelected()
    {
        if (DamageZone == null)
            return;

        Gizmos.DrawWireSphere(DamageZone.position, Range);
    }
}
