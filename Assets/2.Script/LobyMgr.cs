using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //씬 추가 

public class LobyMgr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown) //어떤 키가 들어오면
        {
            //씬 전환 
            SceneManager.LoadScene("GAME");
        }
    }
}
