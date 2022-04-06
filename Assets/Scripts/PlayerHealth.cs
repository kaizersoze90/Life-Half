using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float maxHitPoints = 100f;

    DeathHandler deathHandler;

    void Awake()
    {
        deathHandler = GetComponent<DeathHandler>();
    }

    public void TakeDamage(float damage)
    {
        deathHandler.GetBloodyScreen();
        maxHitPoints -= damage;
        if (maxHitPoints < 0)
        {
            Die();
        }
    }

    void Die()
    {
        deathHandler.HandleDeath();
    }
}
