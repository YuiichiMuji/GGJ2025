using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Split : MonoBehaviour
{
    public GameObject bubblePrefab;
    public GameObject Spawn1;
    public GameObject Spawn2;

    public float shootSpeed = 10f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bubble"))
        {
            Destroy(other.gameObject);
            ShootDoubleBubble();
        }
    }

    void ShootDoubleBubble()
    {
        GameObject bubble = Instantiate(bubblePrefab, Spawn1.transform.position, Quaternion.identity);
        GameObject bubble2 = Instantiate(bubblePrefab, Spawn2.transform.position, Quaternion.identity);

        Rigidbody2D rb = bubble.GetComponent<Rigidbody2D>();
        Rigidbody2D rb2 = bubble2.GetComponent<Rigidbody2D>();

        Vector2 direction = transform.right;
        rb.velocity = direction * shootSpeed;
        rb2.velocity = direction * shootSpeed;
    }
}
