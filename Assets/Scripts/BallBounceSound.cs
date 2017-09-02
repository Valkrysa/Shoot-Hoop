using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounceSound : MonoBehaviour {

    private AudioSource source;

    void Start() {
        source = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision) {
        source.Play();
    }
}
