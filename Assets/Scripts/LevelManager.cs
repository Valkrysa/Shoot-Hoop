using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
    
    public float timeUntilNextLevel = 5.0f;
    public bool autoLoadNextLevel = false;

    void Update() {
        timeUntilNextLevel -= Time.deltaTime;
        if (autoLoadNextLevel && timeUntilNextLevel <= 0) {
            LoadNextScene();
        }
    }

    public void LoadNextScene () {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadPreviousLevel () {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
