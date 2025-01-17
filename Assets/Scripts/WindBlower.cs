using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindBlower : MonoBehaviour
{
    public float turnAngle = 90f; // The angle by which the bubble should turn (positive or negative)

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object that entered the trigger is tagged as "Bubble"
        if (other.CompareTag("Bubble"))
        {
            Rigidbody2D rb = other.GetComponent<Rigidbody2D>();

            if (rb != null)
            {
                // Get the current velocity of the Bubble
                Vector2 currentVelocity = rb.velocity;

                // Calculate the new direction to turn (90 degrees left or right)
                Vector2 newVelocity = Quaternion.Euler(0, 0, turnAngle) * currentVelocity;

                // Set the new velocity to make the Bubble turn
                rb.velocity = newVelocity;
            }
        }
    }
}

