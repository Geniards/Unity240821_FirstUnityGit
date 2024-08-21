using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    public Vector3 obj;

    private void Start()
    {
        int iNum = 1;
        float fNum = 0.0f;
    }


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
            transform.position += obj;

        if(Input.GetKeyDown(KeyCode.D))
            transform.localPosition += obj;
    }
}
