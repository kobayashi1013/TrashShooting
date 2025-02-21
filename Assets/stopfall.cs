using UnityEngine;

public class StopOnCollision : MonoBehaviour
{
	public float fallSpeed = 5f;
	private bool isFalling = true;

	void Update()
	{
		if (isFalling)
		{
			transform.position += Vector3.down * fallSpeed * Time.deltaTime;
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Default")) // Ensure floor has "Ground" tag
		{
			isFalling = false; // Stop movement
		}
	}
}
