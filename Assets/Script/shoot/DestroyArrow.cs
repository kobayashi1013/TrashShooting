using UnityEngine;

public class DestroyArrow : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("can")) // Ensure the bottle has the tag "Bottle"
        {
            Destroy(gameObject); // Destroy only the arrow
        }
    }
}
