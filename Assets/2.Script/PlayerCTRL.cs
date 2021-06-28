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
        if (Input.GetKeyDown(KeyCode.Space) && isJump == false) //물리 점프 하려면
        {
            //자기한테 붙어있는 RIGIDBODY를 불러 올 수 있다.  GetComponent<컴포넌트>
            GetComponent<Rigidbody>().AddForce(Vector3.up * 10f, ForceMode.Impulse);
          
            isJump = true;

        }
    }

    private void OnCollisionEnter(Collision collision) //누군가와 부딪혔을 때 
    {
        //Floor에 태그를 추가해서 바닥에 별명을 만들어주자. 
        //
        if (collision.transform.tag == "FLOOR")
        {
            isJump = false;
        }

    }

}
