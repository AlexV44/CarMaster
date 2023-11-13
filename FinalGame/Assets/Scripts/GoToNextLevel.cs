using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToNextLevel : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player") {
            UnlockLevel();
            SceneManager.LoadScene(0);
        }
    }

    public void UnlockLevel() {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;

        if (currentLevel >= PlayerPrefs.GetInt("LevelComplete")) {
            PlayerPrefs.SetInt("LevelComplete", currentLevel + 1);
        }
    }
}
