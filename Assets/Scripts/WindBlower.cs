using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindBlower : MonoBehaviour
{
    public float turnAngle = 90f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bubble"))
        {
            Rigidbody2D rb = other.GetComponent<Rigidbody2D>();

            if (rb != null)
            {
                Vector2 currentVelocity = rb.velocity;

                Vector2 newVelocity = Quaternion.Euler(0, 0, turnAngle) * currentVelocity;

                rb.velocity = newVelocity;
            }
        }
    }
}
