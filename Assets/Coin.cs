using UnityEngine;
using TMPro;  // Import TextMeshPro namespace

public class Coin : MonoBehaviour
{
    public TextMeshProUGUI scoreText;  // Reference to the TextMeshProUGUI component for displaying score
    private int score = 0;  // Player's score

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the trigger is the paper ball
        if (other.gameObject.CompareTag("coin"))
        {
           
            // Increment score
            IncreaseScore();

            // Optional: You can destroy the paper ball or reset it
              // Or reset its position if needed
        }
    }

    // Function to increase the score and update the UI
    private void IncreaseScore()
    {
        score += 1;  // Increase score by 1
        scoreText.text = "Score: " + score;  // Update the score UI
        Debug.Log("Current Score: " + score);  // Optional log for testing
    }
}