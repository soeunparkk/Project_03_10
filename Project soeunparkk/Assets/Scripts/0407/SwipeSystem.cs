using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeSystem : MonoBehaviour
{
    public Vector2 initialPos;                  //���콺�� ȭ���� x,y �����Ǹ� �ֱ� ������ Vector2
    public GameObject Charater;                 //ĳ���͸� �����Ѵ�.(GameObject)

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) initialPos = Input.mousePosition;
        if (Input.GetMouseButtonDown(0)) Calculate(Input.mousePosition);
    }

    void Calculate(Vector3 finalPos)            //����ϴ� �Լ��� �����.
    {
        float disX = Mathf.Abs(initialPos.x - finalPos.x);      //Mathf .abs �Լ��� ���밪�� ���ϴ� �Լ� (�Ÿ��� ���ؾ� �ϱ� ������)
        float disY = Mathf.Abs(initialPos.y - finalPos.y);

        if(disX > 0 || disY > 0)                                
        {
            if(disX > disY)
            {
                 Charater.transform.position += new Vector3(-1.0f, 0.0f, 0.0f);         ///Charater.transform.position += new Vector3(-1.0f, 0.0f, 0.0f);
            }
            else
            {
                Charater.transform.position += new Vector3(-1.0f, 0.0f, 0.0f);
            }
            
        }
        else
        {
            if(initialPos.y > finalPos.y)
            {
                Charater.transform.position += new Vector3(-1.0f, 0.0f, 0.0f);
            }
            else
            {
                Charater.transform.position += new Vector3(-1.0f, 0.0f, 0.0f);
            }
        }
    }
}
