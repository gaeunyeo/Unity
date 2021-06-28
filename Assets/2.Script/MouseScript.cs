using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseScript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject player; //�÷��̾ �޾ƿ� �� �ְ� ���� �����.
    public Vector3 pos; //hit.point�� ����

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //���� ���콺 
        {

            Debug.Log("���� Ŭ��");

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;//������ , ���� , �浹üũ , �� ���� ( float or Mathf.Infinity (������) )
            if (Physics.Raycast(ray.origin, ray.direction, out hit, Mathf.Infinity))
            {
                //Debug.Log("hit");
                //Debug.Log(hit.point); //��ġ�� ���
                //Debug.Log(hit.point.x); //x������
                //Debug.Log(hit.point.y); //y������
                //Debug.Log(hit.point.z); //z������
                
                pos = hit.point; // hit point �� �� �ȿ����� �θ� �� �ִ�.. 
                //pos = hit.point + new Vector3(0, 1, 0); �ٸ� ��� 
                player.transform.LookAt(hit.point); //�� ��(����) ���� �ٶ󺸶�
                //�̶� y ���� �� �� ����. �����־�� ��
            }
        }

        
        player.transform.position = Vector3.MoveTowards(player.transform.position, pos, 10f * Time.deltaTime);

    }    
    //��ǥ �������� õõ�� �̵�
    //��Ʈ ����Ʈ�� ���� ��Ƽ� ��ǥ��ġ�� �ֱ�.
}
