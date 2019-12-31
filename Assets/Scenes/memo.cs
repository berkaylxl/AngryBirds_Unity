using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class memo : MonoBehaviour
{
    Rigidbody2D rbody;
    public float speed;

    void Start()
    {
        rbody = GetComponent<Rigidbody2D>(); 
   
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
            rbody.velocity = Vector2.up * speed;
    }
}
