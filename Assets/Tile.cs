using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Tile : MonoBehaviour
{

    [SerializeField] private Color basecolor, offsetcolor;
    [SerializeField] private SpriteRenderer _renderer;
    [SerializeField] private GameObject Highlight;
    private Vector3 initialPosition;
    public bool IsObjectClicked_=false;
    public SetProp prop;
    public void Init(bool isOffset)
    {
        _renderer.color = Color.green;
    }
    public void OnMouseEnter()
    {
        Highlight.SetActive(true);
        
        if (IsObjectClicked_ == true && Input.GetMouseButtonDown(0))
        {
            prop.transform.position = initialPosition;
            IsObjectClicked_=false;
        }
    }
    public void OnMouseExit()
    {
        Highlight.SetActive(false);
    }
    
    void Start()
    {
        initialPosition = transform.position;
        
    }

    void Update()
    {
        IsObjectClicked_ = prop.IsObjectClicked;
    }
}
