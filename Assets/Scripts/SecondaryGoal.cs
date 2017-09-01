using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondaryGoal : MonoBehaviour {

    void OnTriggerEnter(Collider other) {
        Debug.Log("Collided");
        Debug.Log(other);
    }

    public void ExpectCollider(Collider other) {

    }
}
