using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondaryGoal : MonoBehaviour {

    public int pointValue = 1;

    private ScoreKeeper scoreKeeper;
    private Collider expectedCollider;

    void Start() {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }

    void OnTriggerEnter(Collider other) {
        if (expectedCollider == other) {
            scoreKeeper.IncrementScore(pointValue);
        }
    }

    public void ExpectCollider(Collider other) {
        expectedCollider = other;
    }
}
