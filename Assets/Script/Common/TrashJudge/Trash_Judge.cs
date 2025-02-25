using UnityEngine;

public class Trash_Judge : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        int points = 0;

        // Assign score based on the tag
        switch (other.tag)
        {
            case "paper":
                points = 10;
                break;
            case "glass":
                points = 20;
                break;
            case "metal":
                points = 30;
                break;
            case "plastic":
                points = 40;
                break;
            default:
                points = 0; // No points for unrecognized objects
                break;
        }

        // Only update the score if it's a valid trash object
        if (points > 0)
        {
            ScoreManager.instance.AddScore(points); // Add the appropriate score
            Destroy(other.gameObject); // Remove the trash after scoring
        }
    }
}
