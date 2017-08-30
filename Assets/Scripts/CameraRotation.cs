using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour {

    public Camera childCamera;
    public float rotationSpeed = 2.0f;

	// Use this for initialization
	void Start () {
        childCamera = GetComponentInChildren<Camera>();
    }
	
	// Update is called once per frame
	void Update () {
        float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * rotationSpeed * -1f;

        transform.localRotation = Quaternion.Euler(0, mouseX, 0) * transform.localRotation;
        childCamera.transform.localRotation = Quaternion.Euler(mouseY, 0, 0) * childCamera.transform.localRotation;
    }
}
