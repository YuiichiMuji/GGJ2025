using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bubblePrefab;
    public float shootSpeed = 10f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootBubble();
        }
    }

    void ShootBubble()
    {
        // Create the Bubble instance
        GameObject bubble = Instantiate(bubblePrefab, transform.position, Quaternion.identity);

        // Get the Rigidbody2D component of the Bubble
        Rigidbody2D rb = bubble.GetComponent<Rigidbody2D>();

        if (rb != null)
        {
            // Set the velocity directly
            Vector2 direction = transform.up; // The direction the shooter is facing
            rb.velocity = direction * shootSpeed;
        }
        else
        {
            Debug.LogError("Rigidbody2D component not found on the bubble!");
        }
    }
}



