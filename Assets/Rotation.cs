﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float rotationSpeed = 100f;
    bool dragging = false;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent <Rigidbody>();
    }

    // Update is called once per frame
   /* void OnMouseDrag(){
        dragging = true;
        Debug.Log("Detecta mouse ");
    }*/
    void Update()
    {
        if(Input.GetMouseButtonUp(0)){
            dragging = false;
        }
        else if(Input.GetMouseButtonDown(0)){
            dragging = true;
            Debug.Log("Detecta mouse ");
        }
    }
    void FixedUpdate(){
        if(dragging){
            float x = Input.GetAxis("Mouse X") * rotationSpeed * Time.fixedDeltaTime;
            //float y = Input.GetAxis("Mouse Y") * rotationSpeed * Time.fixedDeltaTime;

            rb.AddTorque(Vector3.down*x);
            //rb.AddTorque(Vector3.right*y);
        }
    }
}
