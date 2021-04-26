using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{

    // Start is called before the first frame update
    [SerializeField] float rotationSpeed = 100f;
    public Rigidbody rb;  
    public Rigidbody rb2;
    public Rigidbody rb3; 
    public GameObject male;
    public GameObject female;
    public GameObject huesos;
    //public GameObject AnteBrazos;
    public void left(){   
            rb = male.GetComponent <Rigidbody>();
            rb2 = female.GetComponent <Rigidbody>();
            rb3 = huesos.GetComponent <Rigidbody>(); 
            float x = -rotationSpeed * Time.fixedDeltaTime;
            //float y = Input.GetAxis("Mouse Y") * rotationSpeed * Time.fixedDeltaTime;

            rb.AddTorque(Vector3.down*x);
            rb2.AddTorque(Vector3.down*x);
            rb3.AddTorque(Vector3.down*x);
            //rb.AddTorque(Vector3.right*y);
            //var rotationmale = male.transform.rotation.eulerAngles;
            //AnteBrazos.transform.rotation = Quaternion.Euler(0,rotationmale.y,0);
    }
    public void right(){    
        rb = male.GetComponent <Rigidbody>();
        rb2 = female.GetComponent <Rigidbody>();
        rb3 = huesos.GetComponent <Rigidbody>();
        float x = rotationSpeed * Time.fixedDeltaTime;
        //float y = Input.GetAxis("Mouse Y") * rotationSpeed * Time.fixedDeltaTime;

        rb.AddTorque(Vector3.down*x);
        rb2.AddTorque(Vector3.down*x);
        rb3.AddTorque(Vector3.down*x);
        //rb.AddTorque(Vector3.right*y);
    }
}