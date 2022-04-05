using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] RigidbodyFirstPersonController fpsController;
    [SerializeField] float zoomInFOV = 35f;
    [SerializeField] float zoomOutFOV = 60f;
    [SerializeField] float zoomInSensivity = 0.8f;
    [SerializeField] float zoomOutSensivity = 2f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.CapsLock))
        {
            ZoomIn();
        }
        if (Input.GetKeyUp(KeyCode.CapsLock))
        {
            ZoomOut();
        }
    }

    void ZoomIn()
    {
        Camera.main.fieldOfView = zoomInFOV;
        fpsController.mouseLook.XSensitivity = zoomInSensivity;
        fpsController.mouseLook.YSensitivity = zoomInSensivity;
    }

    void ZoomOut()
    {
        Camera.main.fieldOfView = zoomOutFOV;
        fpsController.mouseLook.XSensitivity = zoomOutSensivity;
        fpsController.mouseLook.YSensitivity = zoomOutSensivity;
    }
}
