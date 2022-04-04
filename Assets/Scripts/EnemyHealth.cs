using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float maxHitPoints = 100f;

    public void TakeDamage(float amount)
    {
        maxHitPoints -= amount;
        if (maxHitPoints <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }


}
