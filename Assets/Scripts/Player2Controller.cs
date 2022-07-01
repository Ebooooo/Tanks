using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    public float RotateSpeed = 3f;
    public float MoveSpeed = 0.5f;



    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0f,0f,0.1f);
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0f,0f,-0.1f);
        }
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0,MoveSpeed,0) * Time.deltaTime);
        }

    }
}
