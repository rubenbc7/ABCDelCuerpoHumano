using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seleccionCuerpo : MonoBehaviour
{
    [SerializeField] private string cabeza = "Cabeza";
    [SerializeField] public GameObject txt_cabeza;
    [SerializeField] private string ojo = "Ojo";
    [SerializeField] public GameObject txt_ojos;
    [SerializeField] private string oido = "Oido";
    [SerializeField] public GameObject txt_oidos;
    [SerializeField] private string nariz = "Nariz";
    [SerializeField] public GameObject txt_nariz;
    [SerializeField] private string boca = "Boca";
    [SerializeField] public GameObject txt_boca;
    [SerializeField] private string tronco = "Tronco";
    [SerializeField] public GameObject txt_tronco;
    [SerializeField] private string abdomen = "Abdomen";
    [SerializeField] public GameObject txt_abdomen;
    [SerializeField] private string estomago = "Estomago";
    [SerializeField] public GameObject txt_estomago;
    [SerializeField] private string espalda = "Espalda";
    [SerializeField] public GameObject txt_espalda;
    [SerializeField] private string brazo = "Brazo";
    [SerializeField] public GameObject txt_brazo;
    [SerializeField] private string hombro = "Hombro";
    [SerializeField] public GameObject txt_hombro;
    [SerializeField] private string codo = "Codo";
    [SerializeField] public GameObject txt_codo;
    [SerializeField] private string muneca = "Muneca";
    [SerializeField] public GameObject txt_muneca;
    [SerializeField] private string antebrazo = "Antebrazo";
    [SerializeField] public GameObject txt_antebrazo;
    [SerializeField] private string mano = "Mano";
    [SerializeField] public GameObject txt_mano;
    [SerializeField] private string dedosMano = "DedoMano";
    [SerializeField] public GameObject txt_dedosMano;
    [SerializeField] private string pierna = "Pierna";
    [SerializeField] public GameObject txt_pierna;
    [SerializeField] private string rodilla = "Rodilla";
    [SerializeField] public GameObject txt_rodilla;
    [SerializeField] private string tobillo = "Tobillo";
    [SerializeField] public GameObject txt_tobillo;
    [SerializeField] private string pie = "Pie";
    [SerializeField] public GameObject txt_pie;
    [SerializeField] private string dedosPie = "DedoPie";
    [SerializeField] public GameObject txt_dedosPie;
    
    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Transform selection = hit.transform;

            //Cabeza
            if (selection.CompareTag(cabeza))
            {
                Renderer selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {
                    txt_cabeza.SetActive(true);
                    txt_ojos.SetActive(false);
                    txt_oidos.SetActive(false);
                    txt_nariz.SetActive(false);
                    txt_boca.SetActive(false);

                    txt_tronco.SetActive(false);
                    txt_abdomen.SetActive(false);
                    txt_estomago.SetActive(false);
                    txt_espalda.SetActive(false);

                    txt_brazo.SetActive(false);
                    txt_hombro.SetActive(false);
                    txt_codo.SetActive(false);
                    txt_muneca.SetActive(false);
                    txt_antebrazo.SetActive(false);
                    txt_mano.SetActive(false);
                    txt_dedosMano.SetActive(false);

                    txt_pierna.SetActive(false);
                    txt_rodilla.SetActive(false);
                    txt_tobillo.SetActive(false);
                    txt_pie.SetActive(false);
                    txt_dedosPie.SetActive(false);
                }
            }
            if (selection.CompareTag(ojo))
            {
                Renderer selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {
                    txt_cabeza.SetActive(false);
                    txt_ojos.SetActive(true);
                    txt_oidos.SetActive(false);
                    txt_nariz.SetActive(false);
                    txt_boca.SetActive(false);

                    txt_tronco.SetActive(false);
                    txt_abdomen.SetActive(false);
                    txt_estomago.SetActive(false);
                    txt_espalda.SetActive(false);

                    txt_brazo.SetActive(false);
                    txt_hombro.SetActive(false);
                    txt_codo.SetActive(false);
                    txt_muneca.SetActive(false);
                    txt_antebrazo.SetActive(false);
                    txt_mano.SetActive(false);
                    txt_dedosMano.SetActive(false);

                    txt_pierna.SetActive(false);
                    txt_rodilla.SetActive(false);
                    txt_tobillo.SetActive(false);
                    txt_pie.SetActive(false);
                    txt_dedosPie.SetActive(false);
                }
            }
            if (selection.CompareTag(oido))
            {
                Renderer selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {
                    txt_cabeza.SetActive(false);
                    txt_ojos.SetActive(false);
                    txt_oidos.SetActive(true);
                    txt_nariz.SetActive(false);
                    txt_boca.SetActive(false);

                    txt_tronco.SetActive(false);
                    txt_abdomen.SetActive(false);
                    txt_estomago.SetActive(false);
                    txt_espalda.SetActive(false);

                    txt_brazo.SetActive(false);
                    txt_hombro.SetActive(false);
                    txt_codo.SetActive(false);
                    txt_muneca.SetActive(false);
                    txt_antebrazo.SetActive(false);
                    txt_mano.SetActive(false);
                    txt_dedosMano.SetActive(false);

                    txt_pierna.SetActive(false);
                    txt_rodilla.SetActive(false);
                    txt_tobillo.SetActive(false);
                    txt_pie.SetActive(false);
                    txt_dedosPie.SetActive(false);
                }
            }
            if (selection.CompareTag(nariz))
            {
                Renderer selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {
                    txt_cabeza.SetActive(false);
                    txt_ojos.SetActive(false);
                    txt_oidos.SetActive(false);
                    txt_nariz.SetActive(true);
                    txt_boca.SetActive(false);

                    txt_tronco.SetActive(false);
                    txt_abdomen.SetActive(false);
                    txt_estomago.SetActive(false);
                    txt_espalda.SetActive(false);

                    txt_brazo.SetActive(false);
                    txt_hombro.SetActive(false);
                    txt_codo.SetActive(false);
                    txt_muneca.SetActive(false);
                    txt_antebrazo.SetActive(false);
                    txt_mano.SetActive(false);
                    txt_dedosMano.SetActive(false);

                    txt_pierna.SetActive(false);
                    txt_rodilla.SetActive(false);
                    txt_tobillo.SetActive(false);
                    txt_pie.SetActive(false);
                    txt_dedosPie.SetActive(false);
                }
            }
            if (selection.CompareTag(boca))
            {
                Renderer selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {
                    txt_cabeza.SetActive(false);
                    txt_ojos.SetActive(false);
                    txt_oidos.SetActive(false);
                    txt_nariz.SetActive(false);
                    txt_boca.SetActive(true);

                    txt_tronco.SetActive(false);
                    txt_abdomen.SetActive(false);
                    txt_estomago.SetActive(false);
                    txt_espalda.SetActive(false);

                    txt_brazo.SetActive(false);
                    txt_hombro.SetActive(false);
                    txt_codo.SetActive(false);
                    txt_muneca.SetActive(false);
                    txt_antebrazo.SetActive(false);
                    txt_mano.SetActive(false);
                    txt_dedosMano.SetActive(false);

                    txt_pierna.SetActive(false);
                    txt_rodilla.SetActive(false);
                    txt_tobillo.SetActive(false);
                    txt_pie.SetActive(false);
                    txt_dedosPie.SetActive(false);
                }
            }

            //Tronco
            if (selection.CompareTag(tronco))
            {
                Renderer selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {
                    txt_cabeza.SetActive(false);
                    txt_ojos.SetActive(false);
                    txt_oidos.SetActive(false);
                    txt_nariz.SetActive(false);
                    txt_boca.SetActive(false);

                    txt_tronco.SetActive(true);
                    txt_abdomen.SetActive(false);
                    txt_estomago.SetActive(false);
                    txt_espalda.SetActive(false);

                    txt_brazo.SetActive(false);
                    txt_hombro.SetActive(false);
                    txt_codo.SetActive(false);
                    txt_muneca.SetActive(false);
                    txt_antebrazo.SetActive(false);
                    txt_mano.SetActive(false);
                    txt_dedosMano.SetActive(false);

                    txt_pierna.SetActive(false);
                    txt_rodilla.SetActive(false);
                    txt_tobillo.SetActive(false);
                    txt_pie.SetActive(false);
                    txt_dedosPie.SetActive(false);
                }
            }
            if (selection.CompareTag(abdomen))
            {
                Renderer selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {
                    txt_cabeza.SetActive(false);
                    txt_ojos.SetActive(false);
                    txt_oidos.SetActive(false);
                    txt_nariz.SetActive(false);
                    txt_boca.SetActive(false);

                    txt_tronco.SetActive(false);
                    txt_abdomen.SetActive(true);
                    txt_estomago.SetActive(false);
                    txt_espalda.SetActive(false);

                    txt_brazo.SetActive(false);
                    txt_hombro.SetActive(false);
                    txt_codo.SetActive(false);
                    txt_muneca.SetActive(false);
                    txt_antebrazo.SetActive(false);
                    txt_mano.SetActive(false);
                    txt_dedosMano.SetActive(false);

                    txt_pierna.SetActive(false);
                    txt_rodilla.SetActive(false);
                    txt_tobillo.SetActive(false);
                    txt_pie.SetActive(false);
                    txt_dedosPie.SetActive(false);
                }
            }
            if (selection.CompareTag(estomago))
            {
                Renderer selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {
                    txt_cabeza.SetActive(false);
                    txt_ojos.SetActive(false);
                    txt_oidos.SetActive(false);
                    txt_nariz.SetActive(false);
                    txt_boca.SetActive(false);

                    txt_tronco.SetActive(false);
                    txt_abdomen.SetActive(false);
                    txt_estomago.SetActive(true);
                    txt_espalda.SetActive(false);

                    txt_brazo.SetActive(false);
                    txt_hombro.SetActive(false);
                    txt_codo.SetActive(false);
                    txt_muneca.SetActive(false);
                    txt_antebrazo.SetActive(false);
                    txt_mano.SetActive(false);
                    txt_dedosMano.SetActive(false);

                    txt_pierna.SetActive(false);
                    txt_rodilla.SetActive(false);
                    txt_tobillo.SetActive(false);
                    txt_pie.SetActive(false);
                    txt_dedosPie.SetActive(false);
                }
            }
            if (selection.CompareTag(espalda))
            {
                Renderer selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {
                    txt_cabeza.SetActive(false);
                    txt_ojos.SetActive(false);
                    txt_oidos.SetActive(false);
                    txt_nariz.SetActive(false);
                    txt_boca.SetActive(false);

                    txt_tronco.SetActive(false);
                    txt_abdomen.SetActive(false);
                    txt_estomago.SetActive(false);
                    txt_espalda.SetActive(true);

                    txt_brazo.SetActive(false);
                    txt_hombro.SetActive(false);
                    txt_codo.SetActive(false);
                    txt_muneca.SetActive(false);
                    txt_antebrazo.SetActive(false);
                    txt_mano.SetActive(false);
                    txt_dedosMano.SetActive(false);

                    txt_pierna.SetActive(false);
                    txt_rodilla.SetActive(false);
                    txt_tobillo.SetActive(false);
                    txt_pie.SetActive(false);
                    txt_dedosPie.SetActive(false);
                }
            }

            //Brazos
            if (selection.CompareTag(brazo))
            {
                Renderer selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {
                    txt_cabeza.SetActive(false);
                    txt_ojos.SetActive(false);
                    txt_oidos.SetActive(false);
                    txt_nariz.SetActive(false);
                    txt_boca.SetActive(false);

                    txt_tronco.SetActive(false);
                    txt_abdomen.SetActive(false);
                    txt_estomago.SetActive(false);
                    txt_espalda.SetActive(false);

                    txt_brazo.SetActive(true);
                    txt_hombro.SetActive(false);
                    txt_codo.SetActive(false);
                    txt_muneca.SetActive(false);
                    txt_antebrazo.SetActive(false);
                    txt_mano.SetActive(false);
                    txt_dedosMano.SetActive(false);

                    txt_pierna.SetActive(false);
                    txt_rodilla.SetActive(false);
                    txt_tobillo.SetActive(false);
                    txt_pie.SetActive(false);
                    txt_dedosPie.SetActive(false);
                }
            }
            if (selection.CompareTag(hombro))
            {
                Renderer selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {
                    txt_cabeza.SetActive(false);
                    txt_ojos.SetActive(false);
                    txt_oidos.SetActive(false);
                    txt_nariz.SetActive(false);
                    txt_boca.SetActive(false);

                    txt_tronco.SetActive(false);
                    txt_abdomen.SetActive(false);
                    txt_estomago.SetActive(false);
                    txt_espalda.SetActive(false);

                    txt_brazo.SetActive(false);
                    txt_hombro.SetActive(true);
                    txt_codo.SetActive(false);
                    txt_muneca.SetActive(false);
                    txt_antebrazo.SetActive(false);
                    txt_mano.SetActive(false);
                    txt_dedosMano.SetActive(false);

                    txt_pierna.SetActive(false);
                    txt_rodilla.SetActive(false);
                    txt_tobillo.SetActive(false);
                    txt_pie.SetActive(false);
                    txt_dedosPie.SetActive(false);
                }
            }
            if (selection.CompareTag(codo))
            {
                Renderer selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {
                    txt_cabeza.SetActive(false);
                    txt_ojos.SetActive(false);
                    txt_oidos.SetActive(false);
                    txt_nariz.SetActive(false);
                    txt_boca.SetActive(false);

                    txt_tronco.SetActive(false);
                    txt_abdomen.SetActive(false);
                    txt_estomago.SetActive(false);
                    txt_espalda.SetActive(false);

                    txt_brazo.SetActive(false);
                    txt_hombro.SetActive(false);
                    txt_codo.SetActive(true);
                    txt_muneca.SetActive(false);
                    txt_antebrazo.SetActive(false);
                    txt_mano.SetActive(false);
                    txt_dedosMano.SetActive(false);

                    txt_pierna.SetActive(false);
                    txt_rodilla.SetActive(false);
                    txt_tobillo.SetActive(false);
                    txt_pie.SetActive(false);
                    txt_dedosPie.SetActive(false);
                }
            }
            if (selection.CompareTag(muneca))
            {
                Renderer selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {
                    txt_cabeza.SetActive(false);
                    txt_ojos.SetActive(false);
                    txt_oidos.SetActive(false);
                    txt_nariz.SetActive(false);
                    txt_boca.SetActive(false);

                    txt_tronco.SetActive(false);
                    txt_abdomen.SetActive(false);
                    txt_estomago.SetActive(false);
                    txt_espalda.SetActive(false);

                    txt_brazo.SetActive(false);
                    txt_hombro.SetActive(false);
                    txt_codo.SetActive(false);
                    txt_muneca.SetActive(true);
                    txt_antebrazo.SetActive(false);
                    txt_mano.SetActive(false);
                    txt_dedosMano.SetActive(false);

                    txt_pierna.SetActive(false);
                    txt_rodilla.SetActive(false);
                    txt_tobillo.SetActive(false);
                    txt_pie.SetActive(false);
                    txt_dedosPie.SetActive(false);
                }
            }
            if (selection.CompareTag(antebrazo))
            {
                Renderer selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {
                    txt_cabeza.SetActive(false);
                    txt_ojos.SetActive(false);
                    txt_oidos.SetActive(false);
                    txt_nariz.SetActive(false);
                    txt_boca.SetActive(false);

                    txt_tronco.SetActive(false);
                    txt_abdomen.SetActive(false);
                    txt_estomago.SetActive(false);
                    txt_espalda.SetActive(false);

                    txt_brazo.SetActive(false);
                    txt_hombro.SetActive(false);
                    txt_codo.SetActive(false);
                    txt_muneca.SetActive(false);
                    txt_antebrazo.SetActive(true);
                    txt_mano.SetActive(false);
                    txt_dedosMano.SetActive(false);

                    txt_pierna.SetActive(false);
                    txt_rodilla.SetActive(false);
                    txt_tobillo.SetActive(false);
                    txt_pie.SetActive(false);
                    txt_dedosPie.SetActive(false);
                }
            }
            if (selection.CompareTag(mano))
            {
                Renderer selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {
                    txt_cabeza.SetActive(false);
                    txt_ojos.SetActive(false);
                    txt_oidos.SetActive(false);
                    txt_nariz.SetActive(false);
                    txt_boca.SetActive(false);

                    txt_tronco.SetActive(false);
                    txt_abdomen.SetActive(false);
                    txt_estomago.SetActive(false);
                    txt_espalda.SetActive(false);

                    txt_brazo.SetActive(false);
                    txt_hombro.SetActive(false);
                    txt_codo.SetActive(false);
                    txt_muneca.SetActive(false);
                    txt_antebrazo.SetActive(false);
                    txt_mano.SetActive(true);
                    txt_dedosMano.SetActive(false);

                    txt_pierna.SetActive(false);
                    txt_rodilla.SetActive(false);
                    txt_tobillo.SetActive(false);
                    txt_pie.SetActive(false);
                    txt_dedosPie.SetActive(false);
                }
            }
            if (selection.CompareTag(dedosMano))
            {
                Renderer selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {
                    txt_cabeza.SetActive(false);
                    txt_ojos.SetActive(false);
                    txt_oidos.SetActive(false);
                    txt_nariz.SetActive(false);
                    txt_boca.SetActive(false);

                    txt_tronco.SetActive(false);
                    txt_abdomen.SetActive(false);
                    txt_estomago.SetActive(false);
                    txt_espalda.SetActive(false);

                    txt_brazo.SetActive(false);
                    txt_hombro.SetActive(false);
                    txt_codo.SetActive(false);
                    txt_muneca.SetActive(false);
                    txt_antebrazo.SetActive(false);
                    txt_mano.SetActive(false);
                    txt_dedosMano.SetActive(true);

                    txt_pierna.SetActive(false);
                    txt_rodilla.SetActive(false);
                    txt_tobillo.SetActive(false);
                    txt_pie.SetActive(false);
                    txt_dedosPie.SetActive(false);
                }
            }

            //Piernas
            if (selection.CompareTag(pierna))
            {
                Renderer selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {
                    txt_cabeza.SetActive(false);
                    txt_ojos.SetActive(false);
                    txt_oidos.SetActive(false);
                    txt_nariz.SetActive(false);
                    txt_boca.SetActive(false);

                    txt_tronco.SetActive(false);
                    txt_abdomen.SetActive(false);
                    txt_estomago.SetActive(false);
                    txt_espalda.SetActive(false);

                    txt_brazo.SetActive(false);
                    txt_hombro.SetActive(false);
                    txt_codo.SetActive(false);
                    txt_muneca.SetActive(false);
                    txt_antebrazo.SetActive(false);
                    txt_mano.SetActive(false);
                    txt_dedosMano.SetActive(false);

                    txt_pierna.SetActive(true);
                    txt_rodilla.SetActive(false);
                    txt_tobillo.SetActive(false);
                    txt_pie.SetActive(false);
                    txt_dedosPie.SetActive(false);
                }
            }

            if (selection.CompareTag(rodilla))
            {
                Renderer selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {
                    txt_cabeza.SetActive(false);
                    txt_ojos.SetActive(false);
                    txt_oidos.SetActive(false);
                    txt_nariz.SetActive(false);
                    txt_boca.SetActive(false);

                    txt_tronco.SetActive(false);
                    txt_abdomen.SetActive(false);
                    txt_estomago.SetActive(false);
                    txt_espalda.SetActive(false);

                    txt_brazo.SetActive(false);
                    txt_hombro.SetActive(false);
                    txt_codo.SetActive(false);
                    txt_muneca.SetActive(false);
                    txt_antebrazo.SetActive(false);
                    txt_mano.SetActive(false);
                    txt_dedosMano.SetActive(false);

                    txt_pierna.SetActive(false);
                    txt_rodilla.SetActive(true);
                    txt_tobillo.SetActive(false);
                    txt_pie.SetActive(false);
                    txt_dedosPie.SetActive(false);
                }
            }

            if (selection.CompareTag(tobillo))
            {
                Renderer selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {
                    txt_cabeza.SetActive(false);
                    txt_ojos.SetActive(false);
                    txt_oidos.SetActive(false);
                    txt_nariz.SetActive(false);
                    txt_boca.SetActive(false);

                    txt_tronco.SetActive(false);
                    txt_abdomen.SetActive(false);
                    txt_estomago.SetActive(false);
                    txt_espalda.SetActive(false);

                    txt_brazo.SetActive(false);
                    txt_hombro.SetActive(false);
                    txt_codo.SetActive(false);
                    txt_muneca.SetActive(false);
                    txt_antebrazo.SetActive(false);
                    txt_mano.SetActive(false);
                    txt_dedosMano.SetActive(false);

                    txt_pierna.SetActive(false);
                    txt_rodilla.SetActive(false);
                    txt_tobillo.SetActive(true);
                    txt_pie.SetActive(false);
                    txt_dedosPie.SetActive(false);
                }
            }

            if (selection.CompareTag(pie))
            {
                Renderer selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {
                    txt_cabeza.SetActive(false);
                    txt_ojos.SetActive(false);
                    txt_oidos.SetActive(false);
                    txt_nariz.SetActive(false);
                    txt_boca.SetActive(false);

                    txt_tronco.SetActive(false);
                    txt_abdomen.SetActive(false);
                    txt_estomago.SetActive(false);
                    txt_espalda.SetActive(false);

                    txt_brazo.SetActive(false);
                    txt_hombro.SetActive(false);
                    txt_codo.SetActive(false);
                    txt_muneca.SetActive(false);
                    txt_antebrazo.SetActive(false);
                    txt_mano.SetActive(false);
                    txt_dedosMano.SetActive(false);

                    txt_pierna.SetActive(false);
                    txt_rodilla.SetActive(false);
                    txt_tobillo.SetActive(false);
                    txt_pie.SetActive(true);
                    txt_dedosPie.SetActive(false);
                }
            }

            if (selection.CompareTag(dedosPie))
            {
                Renderer selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {
                    txt_cabeza.SetActive(false);
                    txt_ojos.SetActive(false);
                    txt_oidos.SetActive(false);
                    txt_nariz.SetActive(false);
                    txt_boca.SetActive(false);

                    txt_tronco.SetActive(false);
                    txt_abdomen.SetActive(false);
                    txt_estomago.SetActive(false);
                    txt_espalda.SetActive(false);

                    txt_brazo.SetActive(false);
                    txt_hombro.SetActive(false);
                    txt_codo.SetActive(false);
                    txt_muneca.SetActive(false);
                    txt_antebrazo.SetActive(false);
                    txt_mano.SetActive(false);
                    txt_dedosMano.SetActive(false);

                    txt_pierna.SetActive(false);
                    txt_rodilla.SetActive(false);
                    txt_tobillo.SetActive(false);
                    txt_pie.SetActive(false);
                    txt_dedosPie.SetActive(true);
                }
            }
        }
    }
}
