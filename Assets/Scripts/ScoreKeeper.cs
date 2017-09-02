using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour {

    public int score = 0;

    private AudioSource source;

    // Use this for initialization
    void Start () {
        DontDestroyOnLoad(gameObject);
        source = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void IncrementScore (int pointValue) {
        source.Play();
        score += pointValue;
    }
}
