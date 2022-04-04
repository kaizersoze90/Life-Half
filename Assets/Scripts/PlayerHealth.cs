using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float maxHitPoints = 100f;

    public void TakeDamage(float damage)
    {
        maxHitPoints -= damage;
        if (maxHitPoints < 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("You died..");
    }
}
