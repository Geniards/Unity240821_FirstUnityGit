using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpper : MonoBehaviour
{
    public float jumpPower;
    public Rigidbody rigid;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rigid.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        }
    }
}
