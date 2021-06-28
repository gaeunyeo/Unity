using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerControl : MonoBehaviour

{
    // Start is called before the first frame update
    public Transform Player;
    public float speed = 1f;
    public Rigidbody rb;
    public GameObject View;
    public Vector3 offset;


    void Start()
    {
        offset = transform.position - Player.position;
            //ī�޶�� �÷��̾��� ���� ����!!
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * speed * Time.deltaTime;
        }

        

        if(Input.GetKeyDown(KeyCode.Space))
        { //�����̽��� ���� �� rg ��� ���� �� ��. 

            //rb.AddForce(����, ��� ���� �ٲ���)
            rb.AddForce(new Vector3(0, 1, 0) * 5f, ForceMode.Impulse);
            
                //Impulse = ���� ��Ƽ� �ѹ��� �ش�.
        }

            
            View.transform.position = Vector3.Lerp(View.transform.position,
                transform.position - new Vector3(0,0,5) , //�������� ��ġ�ϱ� 
                3f * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision) //Collision�� ó�� �ε��� ������Ʈ�� �� �ִ�.
    {
        //�갡 COIN�� ����
        if(collision.transform.tag == "COIN")
        {
            Destroy(collision.gameObject); 
        }
    }
    private void OnCollisionStay(Collision collision)
    {

    }

}
