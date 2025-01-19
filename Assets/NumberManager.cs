using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberManager : MonoBehaviour
{
    public Sprite[] sprites;
    public Image newImage;

    void Start()
    {
        newImage = GetComponent<Image>();
    }
    void Update()
    {
        int currentleft = GameManager.Instance.currentleft;
        newImage.sprite = sprites[currentleft];
    }
}
