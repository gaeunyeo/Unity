using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //씬을 추가해주겠다. 선언
using UnityEngine.Video; //vidio play 변수를 만들려면 -> 나 비디오 쓰겠다.

public class IntroMgr : MonoBehaviour
{
    // Start is called before the first frame update

    public VideoPlayer vp; //변수에 비디오플레이어를 담는다.
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() //주기적으로 확인한다. 
    {
        //비디오가 재생중인지 아닌지 확인하기
        if (vp.isPlaying==false && vp.isPrepared) //비디오 플레이 isPlaying가 false라면? && 로딩이 다 되었는지 체크된다면
        {
            NextLoby(); //NetxtLoby (LOBY) 씬으로 이동해라.
        }
        

    }

    //씬 이동 전용 함수를 추가해보자
    //Intro 에서 Loby로 이동 -> NextLoby 라는 이름을 만들자

    public void NextLoby()
    {
        SceneManager.LoadScene("LOBY");
    }
}
