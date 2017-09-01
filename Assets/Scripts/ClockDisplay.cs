using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockDisplay : MonoBehaviour {

    private Text clockText;
    private LevelManager levelManager;

    // Use this for initialization
    void Start () {
        clockText = GetComponent<Text>();
        levelManager = FindObjectOfType<LevelManager>();
    }
	
	// Update is called once per frame
	void Update () {
        clockText.text = "Time: " + (int)levelManager.timeUntilNextLevel;
    }
}
