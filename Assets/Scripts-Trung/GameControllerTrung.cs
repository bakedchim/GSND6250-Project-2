using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerTrung : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject gameWinCanvas;
    
    public void WinGame()
    {
        // Set the time scale back to normal
        Time.timeScale = 0;
        // Show the game win canvas
        gameWinCanvas.SetActive(true);
    }

    public void LoseGame()
    {
        // Set the time scale back to normal
        Time.timeScale = 0;
        // Show the game over canvas
        gameOverCanvas.SetActive(true);
    }

    public void RestartGame()
    {
        // Set the time scale back to normal
        Time.timeScale = 1;
        // Reload the current scene
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }
}
