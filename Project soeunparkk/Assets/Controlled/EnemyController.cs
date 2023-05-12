using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 5.0f;
    public float rotationSpeed = 1.0f;

    public GameObject bulletPrefab;
    public GameObject enemyPiovt;

    [SerializeField]
    private Transform firePoint;
    public float fireRate = 1.0f;
    [SerializeField]
    private float nextFireTime;



    


    private Rigidbody rb;                   //Rigidbody ����
    private Transform player;               //�÷��̾� ��ġ �������� ���� ����

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();             //�����Ҷ� �ڱ� �ڽ��� Rigidbody�� �޾ƿ´�.
        player = GameObject.FindGameObjectWithTag("Player").transform;      //Scene���� Player Tag�� ���� ������Ʈ�� �����ͼ� Transform �� ����
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {


            if (Vector3.Distance(player.position, transform.position) > 5.0f)            //Vector3.Distance <== �Ÿ��� �˷��ִ� �Լ� 
            {
                Vector3 direction = (player.position - transform.position).normalized;      //�� ���͸� ���� Normlized �ϸ� ���� ���� �˷���
                rb.MovePosition(transform.position + direction * speed * Time.deltaTime);       //�÷��̾ ���ؼ� ������ speed �ӵ��� �̵�
            }

            //��ž ȸ��
            Vector3 targetDirection = (player.position - enemyPiovt.transform.position).normalized; //�� ���͸� ���� Normalized �ϸ� ���� ���� �˷���
            Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
            enemyPiovt.transform.rotation = Quaternion.Lerp(enemyPiovt.transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

            if (Time.time > nextFireTime)
            {
                nextFireTime = Time.time + 1.0f / fireRate;
                GameObject temp = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
                temp.GetComponent<ProjectileMove>().launchDirection = firePoint.localRotation * Vector3.forward;
                temp.GetComponent<ProjectileMove>().bulletType = ProjectileMove.BULLETTYPE.ENEMY;
            }
        }
    }
}