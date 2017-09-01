using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {

    private Text scoreText;
    private ScoreKeeper scoreKeeper;

	// Use this for initialization
	void Start () {
        scoreText = GetComponent<Text>();
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "Score: " + scoreKeeper.score;
    }
}
