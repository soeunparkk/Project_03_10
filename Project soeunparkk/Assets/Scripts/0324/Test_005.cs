using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test_005 : MonoBehaviour
{
    public int hp = 180;
    public Text textUI;                   //���°��� �����ֱ� ���� Text UI
    public Text hpTextUI;               //HP�� �����ֱ� ���� Text UI

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))     //���ǹ����� ���콺 �Է� ���� 0 �μ��� ���� ���콺
        {
            hp += 10;
        }
        if (Input.GetMouseButtonDown(1))    //���ǹ����� ���콺 �Է� ���� 1�μ��� ������ ���콺
        {
            hp -= 10;
        }

        if (hp <= 50)                        //50���� �϶�
        {
            //Debug.Log("���� !");
            textUI.text = "���� !";
        }
        else if (hp >= 200)                  //200�̻� �϶�
        {
            //Debug.Log("���� !");
            textUI.text = "���� !";
        }
        else
        {
            //Debug.Log("��� !");
            textUI.text = "��� !";
        }

        hpTextUI.text = "HP : " + hp.ToString();            //Tostring ������ ���ڿ��� �ٲ��ִ� �Լ� ("HP : ����")
    }
}
