using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCreat : MonoBehaviour
{
	// Start is called before the first frame update
	public GameObject Cube;
	
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		//마우스 왼쪽 버튼 클릭하면
		if (Input.GetMouseButtonDown(0))
		{
			//클릭한 화면 좌표를 - 레이좌표로 변환 ( 시작점 , 방향 )
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			RaycastHit hit;//시작점 , 방향 , 충돌체크 , 선 길이 ( float or Mathf.Infinity (무제한) )
			if (Physics.Raycast(ray.origin, ray.direction, out hit, Mathf.Infinity))
			{
				//Debug.Log("hit");
				Debug.Log(hit.point); //위치값 출력
									  //Debug.Log(hit.point.x); //x값접근
									  //Debug.Log(hit.point.y); //y값접근
									  //Debug.Log(hit.point.z); //z값접근

				Instantiate(Cube, hit.point, Quaternion.identity);
			}
		}

		//마우스 왼쪽 버튼 클릭하면
		if (Input.GetMouseButtonDown(1))
		{
			//클릭한 화면 좌표를 - 레이좌표로 변환 ( 시작점 , 방향 )
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			RaycastHit hit;//시작점 , 방향 , 충돌체크 , 선 길이 ( float or Mathf.Infinity (무제한) )
			if (Physics.Raycast(ray.origin, ray.direction, out hit, Mathf.Infinity))
			{
				//Debug.Log("hit");
				Debug.Log(hit.point); //위치값 출력
									  //Debug.Log(hit.point.x); //x값접근
									  //Debug.Log(hit.point.y); //y값접근
									  //Debug.Log(hit.point.z); //z값접근

				if (hit.transform.tag == "Mon") //태그 이름이 "Mon"인 hit 대상일때만 
				{

					Destroy(hit.transform.gameObject); //파괴하기 
					//Destroy(hit.collider.gameObject);

				}
				//10초 딜레이 있다가 사라지게 하려면??


			}
		}
	}
}
