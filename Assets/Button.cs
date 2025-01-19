using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public Sprite newsprite;
    private SpriteRenderer spriteRenderer;

    public ButtonWall ButtonWall;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bubble"))
        {
            spriteRenderer.sprite = newsprite;
            Destroy(other.gameObject);
            ButtonWall.move();
        }
    }
}
