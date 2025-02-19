using UnityEngine;
using UnityEngine.UI; // Required for UI elements
using UnityEngine.SceneManagement; // If you want to load a new scene when time runs out

public class GameTimer : MonoBehaviour
{
    public float timeLeft = 60f; // 60-second timer
    public Text timerText; // Assign a UI Text element in the Inspector

    void Update()
    {
        // Reduce time
        timeLeft -= Time.deltaTime;

        // Update UI text
        if (timerText != null)
        {
            timerText.text = "Time Left: " + Mathf.Ceil(timeLeft).ToString();
        }

        // When the timer reaches 0, end the game
        if (timeLeft <= 0)
        {
            timeLeft = 0; // Ensure it doesn't go negative
            EndGame();
        }
    }

    void EndGame()
    {
        Debug.Log("Time's up! Game Over!");
        // You can add code to restart, load a results scene, or show a game over screen
        // Example: SceneManager.LoadScene("GameOverScene");
    }
}
