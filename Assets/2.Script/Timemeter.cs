using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timemeter : MonoBehaviour
{
    // Start is called before the first frame update

    public Image time;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time.fillAmount -= 0.05f * Time.deltaTime;// ���ݾ� ����
                                                 // 0.5 �������� �Ǹ� ����� �϶� -> ����Ǿ��ٴ� ��ư �߰��ϸ� good
    }
}
