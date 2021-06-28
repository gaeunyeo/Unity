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
		//���콺 ���� ��ư Ŭ���ϸ�
		if (Input.GetMouseButtonDown(0))
		{
			//Ŭ���� ȭ�� ��ǥ�� - ������ǥ�� ��ȯ ( ������ , ���� )
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			RaycastHit hit;//������ , ���� , �浹üũ , �� ���� ( float or Mathf.Infinity (������) )
			if (Physics.Raycast(ray.origin, ray.direction, out hit, Mathf.Infinity))
			{
				//Debug.Log("hit");
				Debug.Log(hit.point); //��ġ�� ���
									  //Debug.Log(hit.point.x); //x������
									  //Debug.Log(hit.point.y); //y������
									  //Debug.Log(hit.point.z); //z������

				Instantiate(Cube, hit.point, Quaternion.identity);
			}
		}

		//���콺 ���� ��ư Ŭ���ϸ�
		if (Input.GetMouseButtonDown(1))
		{
			//Ŭ���� ȭ�� ��ǥ�� - ������ǥ�� ��ȯ ( ������ , ���� )
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			RaycastHit hit;//������ , ���� , �浹üũ , �� ���� ( float or Mathf.Infinity (������) )
			if (Physics.Raycast(ray.origin, ray.direction, out hit, Mathf.Infinity))
			{
				//Debug.Log("hit");
				Debug.Log(hit.point); //��ġ�� ���
									  //Debug.Log(hit.point.x); //x������
									  //Debug.Log(hit.point.y); //y������
									  //Debug.Log(hit.point.z); //z������

				if (hit.transform.tag == "Mon") //�±� �̸��� "Mon"�� hit ����϶��� 
				{

					Destroy(hit.transform.gameObject); //�ı��ϱ� 
					//Destroy(hit.collider.gameObject);

				}
				//10�� ������ �ִٰ� ������� �Ϸ���??


			}
		}
	}
}
