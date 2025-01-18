using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Split : MonoBehaviour
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


    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Split");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Death");
    }

    void ShootBubble()
    {
        GameObject bubble = Instantiate(bubblePrefab, transform.position, Quaternion.identity);

        Rigidbody2D rb = bubble.GetComponent<Rigidbody2D>();

        if (rb != null)
        {
            Vector2 direction = transform.up;
            rb.velocity = direction * shootSpeed;
        }
        else
        {
            Debug.LogError("Rigidbody2D component not found on the bubble!");
        }
    }
}
