using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Transform player;
    public float mouseSensivity = 2f;
    public float cameraVerticalRotation = 0f;
    bool lockedCursor = true;

    private void OnEnable()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        float inputX = Input.GetAxis("Mouse X") * mouseSensivity;
        float inputY = Input.GetAxis("Mouse Y") * mouseSensivity;

        cameraVerticalRotation -= inputY;
        cameraVerticalRotation = Mathf.Clamp(cameraVerticalRotation, -70f, 60f);
        transform.localEulerAngles = Vector3.right * cameraVerticalRotation;

        player.Rotate(Vector3.up * inputX);
    }
}
