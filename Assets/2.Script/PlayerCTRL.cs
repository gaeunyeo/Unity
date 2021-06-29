using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCTRL : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 1f;
    public bool isJump = false;
    public GameObject Floor3;
    public int cnt = 0;
    public Text GarbageCount;
    public Text ObastacleCount;
    public Text Mission;
    public AudioSource GET;
    public AudioSource WARNING;

    
   
 


    void Start()
    {
        GarbageCount.text = cnt.ToString();
        ObastacleCount.text = cnt.ToString();


    }

    // Update is called once per frame
    void Update()
    {
        //KEY CTRL 
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
            transform.LookAt(transform.position + Vector3.left);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            transform.LookAt(transform.position + Vector3.right);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * speed * Time.deltaTime;
            transform.LookAt(transform.position + Vector3.back);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * speed * Time.deltaTime;
            transform.LookAt(transform.position + Vector3.forward);
        }
        if (Input.GetKeyDown(KeyCode.Space) && isJump == false) //���� ���� �Ϸ���
        {
            //�ڱ����� �پ��ִ� RIGIDBODY�� �ҷ� �� �� �ִ�.  GetComponent<������Ʈ>
            GetComponent<Rigidbody>().AddForce(Vector3.up * 5f, ForceMode.Impulse);

            isJump = true;

        }
    }

    private void OnCollisionEnter(Collision collision) //�������� �ε����� �� 
    {
       // Floor�� �±׸� �߰��ؼ� �ٴڿ� ������ ���������. 


        if (collision.transform.tag == "FLOOR")
        {
            isJump = false;
        }
        if (collision.transform.tag == "SPACEGARBAGE") //������ �ε�-> ī��Ʈ ��, ��Ʈ����
        {
            cnt++;
            GarbageCount.text = cnt.ToString();

            Destroy(collision.gameObject);

            Mission.text = "���� �����⸦ �����ϼ̽��ϴ�.";

            GET.Play();
        }
        if (collision.transform.tag == "OBSTACLE") //��ֹ��� �ε����ٸ� �޷� ���� ���?
        {
            cnt++;
            int cnt1 = cnt * 100;
            ObastacleCount.text= cnt1.ToString();  

            Mission.text = "���� ����";
            
            Destroy(collision.gameObject);

            WARNING.Play();
        }

       
    }

    
}
