using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimaryGoal : MonoBehaviour {

    SecondaryGoal secondaryGoal;

    void Start() {
        secondaryGoal = GetComponentInChildren<SecondaryGoal>();
    }

    void OnTriggerEnter(Collider other) {
        if (other.GetComponent<BallBounceSound>()) {
            secondaryGoal.ExpectCollider(other);
        }
    }
}
