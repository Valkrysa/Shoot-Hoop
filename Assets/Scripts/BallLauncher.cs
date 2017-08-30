using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLauncher : MonoBehaviour {

    public GameObject basketballPrefab;
    public float ballSpeed = 1.0f;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1")) {
            GameObject instance = Instantiate(basketballPrefab);
            instance.transform.position = transform.position;
            Rigidbody instanceRigidBody = instance.GetComponent<Rigidbody>();
            instanceRigidBody.velocity = transform.forward * ballSpeed;
        }
    }
}
