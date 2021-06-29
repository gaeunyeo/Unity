using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCamera : MonoBehaviour
{
    // Start is called before the first frame update


    public Transform Cube;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 ze = Vector3.zero;
        transform.position = Vector3.MoveTowards(transform.position, Cube.position, 10f * Time.deltaTime);
    }
}
