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
        time.fillAmount -= 0.05f * Time.deltaTime;// 조금씩 감소
                                                 // 0.5 게이지가 되면 재시작 하라 -> 종료되었다는 버튼 추가하면 good
    }
}
