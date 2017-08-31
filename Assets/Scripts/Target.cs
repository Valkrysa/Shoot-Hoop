using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {

    public int pointValue = 1;

    private ScoreKeeper scoreKeeper;

	void Start () {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }

    void OnCollisionEnter(Collision collision) {
        scoreKeeper.IncrementScore(pointValue);
    }
}
