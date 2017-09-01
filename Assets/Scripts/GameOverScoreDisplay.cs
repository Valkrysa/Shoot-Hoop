using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScoreDisplay : MonoBehaviour {

    private Text scoreText;
    private ScoreAbsorber scoreAbsorber;

    // Use this for initialization
    void Start () {
        scoreText = GetComponent<Text>();
        scoreAbsorber = FindObjectOfType<ScoreAbsorber>();
    }

    void Update() {
        scoreText.text = "Score: " + scoreAbsorber.score.ToString();
    }
}
