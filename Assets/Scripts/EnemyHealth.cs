using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float maxHitPoints = 100f;

    Animator animator;

    bool isDead = false;
    public bool IsDead() { return isDead; }

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void TakeDamage(float amount)
    {
        BroadcastMessage("OnDamageTaken");
        maxHitPoints -= amount;
        if (maxHitPoints <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        if (isDead) return;
        isDead = true;
        animator.SetTrigger("Die");
        Destroy(gameObject, 2.66f);
    }
}
