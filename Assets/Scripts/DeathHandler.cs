using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHandler : MonoBehaviour
{
    [SerializeField] Canvas gameOverCanvas;
    [SerializeField] Canvas gameInterfaceCanvas;
    [SerializeField] Canvas bloodScreenCanvas;
    [SerializeField] float bloodyScreenDuration = 1f;

    void Awake()
    {
        gameOverCanvas.enabled = false;
        bloodScreenCanvas.enabled = false;
        gameInterfaceCanvas.enabled = true;
    }

    public void HandleDeath()
    {
        gameOverCanvas.enabled = true;
        bloodScreenCanvas.enabled = true;
        gameInterfaceCanvas.enabled = false;
        Time.timeScale = 0;
        FindObjectOfType<WeaponSwitcher>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void GetBloodyScreen()
    {
        StartCoroutine(SetScreenBlood());
    }

    IEnumerator SetScreenBlood()
    {
        bloodScreenCanvas.enabled = true;
        yield return new WaitForSeconds(bloodyScreenDuration);
        bloodScreenCanvas.enabled = false;
    }

}
