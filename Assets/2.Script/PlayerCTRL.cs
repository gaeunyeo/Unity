using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCTRL : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 1f;
    public bool isJump = false;


    void Start()
    {

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
            GetComponent<Rigidbody>().AddForce(Vector3.up * 10f, ForceMode.Impulse);
          
            isJump = true;

        }
    }

    private void OnCollisionEnter(Collision collision) //�������� �ε����� �� 
    {
        //Floor�� �±׸� �߰��ؼ� �ٴڿ� ������ ���������. 
        //
        if (collision.transform.tag == "FLOOR")
        {
            isJump = false;
        }

    }

}
