using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimaryGoal : MonoBehaviour {

    void OnTriggerEnter(Collider other) {
        Debug.Log("Collided");
        Debug.Log(other);
    }
}
