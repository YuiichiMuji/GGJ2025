using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

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
        if ((GameManager.Instance.allplaced == false) && (GameManager.Instance.pause == false))
        {
            GameObject tempWall = BuildManager.main.getSelectedWall();
            wall = Instantiate(tempWall, transform.position, Quaternion.identity);
        }
        
    }
}


