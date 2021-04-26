using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Miembros : MonoBehaviour
{
    public GameObject male;
    public GameObject female;
    public GameObject huesos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
            var rotationarms = transform.rotation.eulerAngles;
            if(male.activeInHierarchy == true){
                var rotationmale = male.transform.rotation.eulerAngles;
                transform.rotation = Quaternion.Euler(rotationarms.x,rotationmale.y + 180,rotationarms.z);
            }
            if(female.activeInHierarchy == true){
                var rotationfemale = female.transform.rotation.eulerAngles;
                transform.rotation = Quaternion.Euler(rotationarms.x,rotationfemale.y + 180,rotationarms.z);
            }

    }
}
