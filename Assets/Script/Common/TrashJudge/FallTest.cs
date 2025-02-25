using UnityEngine;

public class FallTest : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("metal")) // Ensure the bottle has the tag "Bottle"
        {
            Destroy(other.gameObject); // Destroy only the arrow
        }
        else if (other.gameObject.CompareTag("plastic")) // Ensure the bottle has the tag "Bottle"
        {
            Destroy(other.gameObject); // Destroy only the arrow
        }
        else if (other.gameObject.CompareTag("paper")) // Ensure the bottle has the tag "Bottle"
        {
            Destroy(other.gameObject); // Destroy only the arrow
        }
        else if (other.gameObject.CompareTag("glass")) // Ensure the bottle has the tag "Bottle"
        {
            Destroy(other.gameObject); // Destroy only the arrow
        }

        Debug.Log("Collided with: ");

    }
}