using UnityEngine;

public class shootTest : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed;
    private void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime); // Moves in the +X direction
    }

}