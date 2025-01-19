using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonWall : MonoBehaviour
{
    public void move()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        Vector2 direction = transform.up;
        rb.velocity = direction * 5;
    }
}
