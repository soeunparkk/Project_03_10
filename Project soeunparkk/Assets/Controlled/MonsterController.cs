using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
    public int Monster_hp = 5;

    public void Monster_Damaged(int damage)     //������ �޴� �Լ� (�μ� int) 
    {
        Monster_hp -= damage;                   //�������� �A

        if(Monster_hp <= 0)
        {
            GameObject temp = this.gameObject;  //�� �ڽ��� 
            Destroy(temp);

        }
    }
}
