using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    private Rigidbody2D rb;

    void Awake()
    {
        // Attempt to get the Rigidbody2D component attached to this object
        rb = GetComponent<Rigidbody2D>();

        if (rb == null)
        {
            Debug.LogError("Rigidbody2D component is missing on the Bubble prefab!", this);
        }
    }

    // Called when the Bubble collides with another collider
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Destroy the Bubble when it hits something
        if (collision.gameObject.CompareTag("DeathSurface"))
        {
            Destroy(gameObject);
        }
    }
}
