using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHandler : MonoBehaviour
{
    [SerializeField] Canvas gameOverCanvas;
    [SerializeField] Canvas aimCursorCanvas;

    void Awake()
    {
        gameOverCanvas.enabled = false;
        aimCursorCanvas.enabled = true;
    }

    public void HandleDeath()
    {
        gameOverCanvas.enabled = true;
        aimCursorCanvas.enabled = false;
        Time.timeScale = 0;
        FindObjectOfType<WeaponSwitcher>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

}
