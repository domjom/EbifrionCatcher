using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    //Code used is reused from initial BaseCharacterControls code repurposed for game

    public CharacterController characterController;
    public Camera mainCamera;
    public float mouseHorizontalSensitivity;
    public float mouseVerticalSensitivity;

    float verticalViewingAngle = 0;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        CameraControls();
    }

    void CameraControls()
    {
        //Get the delta X and Y for the mouse movement.
        float rotateX = Input.GetAxis("Mouse X") * mouseHorizontalSensitivity;
        float rotateY = Input.GetAxis("Mouse Y") * mouseVerticalSensitivity;


        // When moving the camera horizontally, rotate the whole body. The forward direction changes.
        transform.Rotate(Vector3.up * rotateX);

        // When moving the camera vertically, only rotate the camera.
        // Clamping the vertical angle [-90, 90], so the player can't look up or down beyond limits
        verticalViewingAngle = Mathf.Clamp(verticalViewingAngle - rotateY, -90f, 90f);
        mainCamera.transform.localRotation = Quaternion.Euler(verticalViewingAngle, 0, 0);
    }
}
