using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knight : MonoBehaviour
{
    float rotSpeed = 0;                 //���� ȸ�� �ӵ�


    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10000;
        }

        transform.Rotate(0, this.rotSpeed * Time.deltaTime, 0);         //transform�� ĳ������ ��ġ ���۳�Ʈ
                                                                            //Rotate �Լ��� ȸ���� �����ִ� �Լ�
        rotSpeed *= 0.99f;                                                  //�����Ӹ��� 1% ���ҽ����ִ� 
    }
}
