using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plot : MonoBehaviour
{
    [Header("Reference")]
    [SerializeField] private SpriteRenderer sr;
    [SerializeField] private Color hoverColor;

    private GameObject wall;
    private Color startColor;

    private void Start()
    {
        startColor = sr.color; 
    }

    private void OnMouseEnter()
    {
        sr.color = hoverColor;
    }

    private void OnMouseExit()
    {
        sr.color = startColor;
    }

    private void OnMouseDown()
    {
        if (wall != null) return;

        GameObject tempWall = BuildManager.main.getSelectedWall();
        wall = Instantiate(tempWall, transform.position, Quaternion.identity);
    }
}