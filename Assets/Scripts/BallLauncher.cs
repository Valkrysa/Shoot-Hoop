using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLauncher : MonoBehaviour {

    public Camera myCamera;
    public GameObject basketballPrefab;
    public float ballSpeed = 20.0f;

	// Use this for initialization
	void Start () {
        myCamera = GetComponentInChildren<Camera>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1")) {
            GameObject instance = Instantiate(basketballPrefab);
            instance.transform.position = transform.position;
            Rigidbody instanceRigidBody = instance.GetComponent<Rigidbody>();
            instanceRigidBody.velocity = myCamera.transform.rotation * Vector3.forward * ballSpeed;
        }
    }
}
