using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Calling Awake Function");
    }
    void Start()
    {
        Debug.Log("My First Script Start Function");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("My First Script Update Function");

        if (Input.GetKeyDown(KeyCode.W) || Input.GetMouseButtonDown(0))
        {
            Debug.Log("W key get down");
        }


        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("W key is pressed");
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            Debug.Log("W key is released");
        }
    }

    private void LateUpdate()
    {
        Debug.Log("Calling Late Update Function");
    }
}
