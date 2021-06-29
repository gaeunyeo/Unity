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
    public void NextEnding() // Intro에서 Game 으로 이동
    {
        SceneManager.LoadScene("Ending");
    }
    //ex)
    //void OnMouseDown()
    //{
    //    SceneMaganger.LoadScene("LOBY"); //누르는 순간 LOBY씬으로 이동한다.
    //}
}