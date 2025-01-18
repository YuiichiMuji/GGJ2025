using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SetProp : MonoBehaviour
{
    public bool IsObjectClicked = false;
    public bool IsGameBegin = false;
    private Vector3 initialPosition;
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // 检测鼠标左键是否被按下
        if (Input.GetMouseButtonDown(0) && !IsGameBegin)
        {
            // 将鼠标屏幕坐标转换为世界坐标
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // 检查鼠标点击位置是否有碰撞体
            Collider2D hitCollider = Physics2D.OverlapPoint(mousePos);
            if (hitCollider != null)
            {
                // 如果有碰撞体，获取该碰撞体所在的物体
                GameObject clickedObject = hitCollider.gameObject;
                Debug.Log("Clicked object: " + clickedObject.name);
                IsObjectClicked = true;
            }
        }

        if (IsObjectClicked)
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(mousePosition.x, mousePosition.y, transform.position.z);
        }

        if (Input.GetMouseButtonDown(1) && IsObjectClicked)//点击右键时，还原物品位置
        {
            transform.position = initialPosition;
            IsObjectClicked = false;
        }


    }

   

}
