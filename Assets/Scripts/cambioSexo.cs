using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambioSexo : MonoBehaviour
{
    public GameObject male;
    public GameObject female;

    public void changeMale()
    {
        male.SetActive(true);
        female.SetActive(false);
    }

    public void changeFemale()
    {
        //femalePosition.Rotate(0.0f, 0.0f, 0.0f);
        male.SetActive(false);
        female.SetActive(true);
    }
}
