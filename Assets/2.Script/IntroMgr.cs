using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //���� �߰����ְڴ�. ����
using UnityEngine.Video; //vidio play ������ ������� -> �� ���� ���ڴ�.

public class IntroMgr : MonoBehaviour
{
    // Start is called before the first frame update

    public VideoPlayer vp; //������ �����÷��̾ ��´�.
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() //�ֱ������� Ȯ���Ѵ�. 
    {
        //������ ��������� �ƴ��� Ȯ���ϱ�
        if (vp.isPlaying==false && vp.isPrepared) //���� �÷��� isPlaying�� false���? && �ε��� �� �Ǿ����� üũ�ȴٸ�
        {
            NextLoby(); //NetxtLoby (LOBY) ������ �̵��ض�.
        }
        

    }

    //�� �̵� ���� �Լ��� �߰��غ���
    //Intro ���� Loby�� �̵� -> NextLoby ��� �̸��� ������

    public void NextLoby()
    {
        SceneManager.LoadScene("LOBY");
    }
}
