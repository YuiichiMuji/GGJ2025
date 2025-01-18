using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleStar : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.LogError("ez");
        // Check if the other object has a specific tag or type
        if (other.gameObject.CompareTag("Bubble"))
        {
            Debug.LogError("Star");
        }
    }
}
