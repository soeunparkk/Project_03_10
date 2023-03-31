using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player
{
    private int hp = 100;                                   //���� Hp�� private �ϰ� ���� 100 �Է�
    private int Power = 50;                                 //���� Power�� private �ϰ� ���� 50 �Է�

    public void Attack()
    {                                                       //�޼ҵ� Attack ����
        Debug.Log(this.Power + "�������� ������.");
    }

    public void Damage(int damage)                          //�޼ҵ� Damage ����
    {
        this.hp -= damage;
        Debug.Log(damage + "�������� �Ծ���.");
    }

    public int GetHp()
    {
        return hp;
    }

}

public class Test_009 : MonoBehaviour
{

    public Text playerHp;                                       //Player Hp �����ִ� UI
    public Text player2Hp;                                      //Player2 Hp �����ִ� UI

    Player mPlayer = new Player();                              //Player Ŭ���� ���� New <==
    Player mPlayer2 = new Player();                              //Player Ŭ���� ���� New <==


    // Start is called before the first frame update
    void Start()
    {
        //mPlayer.Attack();                                     //Player �޼ҵ� Attack ȣ��
        //mPlayer.Damage(30);                                   //Player �޼ҵ� Damage ȣ��
        //Debug.Log(mPlayer.GetHp());                           //Player�� Hp�� �����ش�.


        Player mPlayer = new Player();                          //Player Ŭ���� ���� New <==
        mPlayer.Attack();                                       //Player �޼ҵ� Attack ȣ��
        mPlayer.Damage(30);                                     //Player �޼ҵ� Damage ȣ��
        Debug.Log(mPlayer.GetHp());                             //Player�� Hp�� �����ش�.                                                    
    }

    // Update is called once per frame
    void Update()
    {
        playerHp.text = "Player1 Hp: " + mPlayer.GetHp().ToString();                  //Player�� Hp�� UI�� ǥ��
        player2Hp.text = "Player2 Hp: " + mPlayer2.GetHp().ToString();                  //Player2�� Hp�� UI�� ǥ��

        if (Input.GetMouseButtonDown(0))                        //���� ���콺
        { 
            mPlayer.Damage(1);                                  //Player �޼ҵ� Damage ȣ��
        }

        if (Input.GetMouseButtonDown(0))                        //������ ���콺
        {
            mPlayer2.Damage(1);                                  //Player2 �޼ҵ� Damage ȣ��
        }

    }
}
