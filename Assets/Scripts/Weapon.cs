using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] Camera FPCamera;
    [SerializeField] float range = 100f;
    [SerializeField] float weaponDamage = 20f;
    [SerializeField] ParticleSystem muzzleVFX;
    [SerializeField] GameObject hitImpact;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        PlayMuzzleFlash();
        ProcessHit();
    }

    void PlayMuzzleFlash()
    {
        muzzleVFX.Play();
    }

    void ProcessHit()
    {
        RaycastHit hit;

        if (Physics.Raycast(FPCamera.transform.position, FPCamera.transform.forward, out hit, range))
        {
            CreateHitImpact(hit);
            EnemyHealth enemyHealth = hit.transform.GetComponent<EnemyHealth>();
            if (enemyHealth != null)
            {
                enemyHealth.TakeDamage(weaponDamage);
            }
        }
        else
        {
            return;
        }
    }

    void CreateHitImpact(RaycastHit hit)
    {
        GameObject hitGO = Instantiate(hitImpact, hit.point, Quaternion.LookRotation(hit.normal));
        Destroy(hitGO, 0.1f);
    }
}
