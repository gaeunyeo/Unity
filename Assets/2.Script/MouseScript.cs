using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseScript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject player; //플레이어를 받아올 수 있게 변수 만들기.
    public Vector3 pos; //hit.point의 변수

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //왼쪽 마우스 
        {

            Debug.Log("왼쪽 클릭");

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;//시작점 , 방향 , 충돌체크 , 선 길이 ( float or Mathf.Infinity (무제한) )
            if (Physics.Raycast(ray.origin, ray.direction, out hit, Mathf.Infinity))
            {
                //Debug.Log("hit");
                //Debug.Log(hit.point); //위치값 출력
                //Debug.Log(hit.point.x); //x값접근
                //Debug.Log(hit.point.y); //y값접근
                //Debug.Log(hit.point.z); //z값접근
                
                pos = hit.point; // hit point 가 이 안에서만 부를 수 있다.. 
                //pos = hit.point + new Vector3(0, 1, 0); 다른 방법 
                player.transform.LookAt(hit.point); //그 쪽(방향) 으로 바라보라
                //이때 y 축이 쏠릴 수 있음. 맞춰주어야 함
            }
        }

        
        player.transform.position = Vector3.MoveTowards(player.transform.position, pos, 10f * Time.deltaTime);

    }    
    //목표 지점으로 천천히 이동
    //히트 포인트를 따로 담아서 목표위치에 넣기.
}
