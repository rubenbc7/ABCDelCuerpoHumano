using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Info : MonoBehaviour
{
    public GameObject Huesos;
    public GameObject Male;
    public GameObject Female;
    public GameObject Izquierda;
    public GameObject Derecha;
    public GameObject i;
    public GameObject COCO;
    public GameObject txt;
    public GameObject X;

    public void menuON(){
        Huesos.SetActive(false);
        Male.SetActive(false);
        Female.SetActive(false);
        Izquierda.SetActive(false);
        Derecha.SetActive(false);
        i.SetActive(false);
        COCO.SetActive(true);
        txt.SetActive(false);
        X.SetActive(true);
    }

        public void menuOFF(){
        Huesos.SetActive(true);
        Male.SetActive(true);
        Female.SetActive(true);
        Izquierda.SetActive(true);
        Derecha.SetActive(true);
        i.SetActive(true);
        COCO.SetActive(false);
        txt.SetActive(true);
        X.SetActive(false);
    }

}
