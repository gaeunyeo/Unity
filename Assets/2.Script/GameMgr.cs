using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMgr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void NextEnding() // Intro���� Game ���� �̵�
    {
        SceneManager.LoadScene("Ending");
    }
    //ex)
    //void OnMouseDown()
    //{
    //    SceneMaganger.LoadScene("LOBY"); //������ ���� LOBY������ �̵��Ѵ�.
    //}
}