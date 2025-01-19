using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bubblePrefab;
    public float shootSpeed = 5f;
    private int chance = 1;

    void ShootBubble()
    {
        GameObject bubble = Instantiate(bubblePrefab, transform.position, Quaternion.identity);

        Rigidbody2D rb = bubble.GetComponent<Rigidbody2D>();

        if (rb != null)
        {
            Vector2 direction = transform.right;
            rb.velocity = direction * shootSpeed;
        }
        else
        {
            Debug.LogError("Rigidbody2D component not found on the bubble!");
        }
    }

    public void Launch()
    {
        if (chance == 1)
        {
            ShootBubble();
            chance = 0;
        }
    }
}


