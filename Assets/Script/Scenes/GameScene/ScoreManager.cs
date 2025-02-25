using UnityEngine;
using TMPro; // Import TextMeshPro for UI

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance; // Singleton to access from other scripts
    public TextMeshProUGUI scoreText;
    private int score = 0;

    void Awake()
    {
        instance = this;
    }

    public void AddScore(int points)
    {
        score += points; // Increase score
        scoreText.text = "SCORE: " + score; // Update UI text
    }
}
