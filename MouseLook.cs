using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;

    public Transform playerBody;


    //Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    public float speedH = 2.0f;
    public float speedV = 2.0f;

    public float yRotation = 0.0f;
    public float xRotation = 0.0f;

    // Update is called once per frame
    void Update()
    {

        yRotation += speedH * Input.GetAxis("Mouse X");
        xRotation -= speedV * Input.GetAxis("Mouse Y");
        if (xRotation >= 45f) xRotation = 45f;
        transform.eulerAngles = new Vector3(xRotation, yRotation, 0.0f);
    }
}
