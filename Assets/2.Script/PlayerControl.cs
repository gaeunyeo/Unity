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
            //카메라와 플레이어의 사이 길이!!
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
        { //스페이스를 누를 때 rg 라는 힘을 줄 것. 

            //rb.AddForce(방향, 어떻게 힘을 줄꺼야)
            rb.AddForce(new Vector3(0, 1, 0) * 5f, ForceMode.Impulse);
            
                //Impulse = 힘을 모아서 한번에 준다.
        }

            
            View.transform.position = Vector3.Lerp(View.transform.position,
                transform.position - new Vector3(0,0,5) , //도착지가 겹치니까 
                3f * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision) //Collision에 처음 부딛힌 오브젝트가 들어가 있다.
    {
        //얘가 COIN을 삭제
        if(collision.transform.tag == "COIN")
        {
            Destroy(collision.gameObject); 
        }
    }
    private void OnCollisionStay(Collision collision)
    {

    }

}
