using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambiarFondo : MonoBehaviour
{
    public GameObject blank;
    public GameObject blank1;
    public GameObject espacio;
    public GameObject espacio1;
    public GameObject rocasAgua;
    public GameObject rocasAgua1;
    public GameObject sailoor;
    public GameObject sailoor1;
    public GameObject vaper;
    public GameObject vaper1;

    int valor = 0;

    public void changeFondo()
    {
        valor++;
        if(valor > 4)
        {
            valor = 0;
        }
        if(valor == 0)
        {
            blank.SetActive(true);
            blank1.SetActive(true);
            espacio.SetActive(false);
            espacio1.SetActive(false);
            rocasAgua.SetActive(false);
            rocasAgua1.SetActive(false);
            sailoor.SetActive(false);
            sailoor1.SetActive(false);
            vaper.SetActive(false);
            vaper1.SetActive(false);
        }
        if(valor == 1)
        {
            blank.SetActive(false);
            blank1.SetActive(false);
            espacio.SetActive(true);
            espacio1.SetActive(true);
            rocasAgua.SetActive(false);
            rocasAgua1.SetActive(false);
            sailoor.SetActive(false);
            sailoor1.SetActive(false);
            vaper.SetActive(false);
            vaper1.SetActive(false);
        }
        if(valor == 2)
        {
            blank.SetActive(false);
            blank1.SetActive(false);
            espacio.SetActive(false);
            espacio1.SetActive(false);
            rocasAgua.SetActive(true);
            rocasAgua1.SetActive(true);
            sailoor.SetActive(false);
            sailoor1.SetActive(false);
            vaper.SetActive(false);
            vaper1.SetActive(false);
        }
        if(valor == 3)
        {
            blank.SetActive(false);
            blank1.SetActive(false);
            espacio.SetActive(false);
            espacio1.SetActive(false);
            rocasAgua.SetActive(false);
            rocasAgua1.SetActive(false);
            sailoor.SetActive(true);
            sailoor1.SetActive(true);
            vaper.SetActive(false);
            vaper1.SetActive(false);
        }
        if(valor == 4)
        {
            blank.SetActive(false);
            blank1.SetActive(false);
            espacio.SetActive(false);
            espacio1.SetActive(false);
            rocasAgua.SetActive(false);
            rocasAgua1.SetActive(false);
            sailoor.SetActive(false);
            sailoor1.SetActive(false);
            vaper.SetActive(true);
            vaper1.SetActive(true);
        }
    }
}
