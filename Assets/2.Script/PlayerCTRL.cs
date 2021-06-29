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
        if (Input.GetKeyDown(KeyCode.Space) && isJump == false) //물리 점프 하려면
        {
            //자기한테 붙어있는 RIGIDBODY를 불러 올 수 있다.  GetComponent<컴포넌트>
            GetComponent<Rigidbody>().AddForce(Vector3.up * 5f, ForceMode.Impulse);

            isJump = true;

        }
    }

    private void OnCollisionEnter(Collision collision) //누군가와 부딪혔을 때 
    {
       // Floor에 태그를 추가해서 바닥에 별명을 만들어주자. 


        if (collision.transform.tag == "FLOOR")
        {
            isJump = false;
        }
        if (collision.transform.tag == "SPACEGARBAGE") //쓰레기 부딪-> 카운트 업, 디스트로이
        {
            cnt++;
            GarbageCount.text = cnt.ToString();

            Destroy(collision.gameObject);

            Mission.text = "우주 쓰레기를 수거하셨습니다.";

            GET.Play();
        }
        if (collision.transform.tag == "OBSTACLE") //장애물을 부딪혔다면 달러 숫자 상승?
        {
            cnt++;
            int cnt1 = cnt * 100;
            ObastacleCount.text= cnt1.ToString();  

            Mission.text = "빚이 생김";
            
            Destroy(collision.gameObject);

            WARNING.Play();
        }

       
    }

    
}
