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
        // ����������Ƿ񱻰���
        if (Input.GetMouseButtonDown(0) && !IsGameBegin)
        {
            // �������Ļ����ת��Ϊ��������
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // ��������λ���Ƿ�����ײ��
            Collider2D hitCollider = Physics2D.OverlapPoint(mousePos);
            if (hitCollider != null)
            {
                // �������ײ�壬��ȡ����ײ�����ڵ�����
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

        if (Input.GetMouseButtonDown(1) && IsObjectClicked)//����Ҽ�ʱ����ԭ��Ʒλ��
        {
            transform.position = initialPosition;
            IsObjectClicked = false;
        }


    }

   

}
