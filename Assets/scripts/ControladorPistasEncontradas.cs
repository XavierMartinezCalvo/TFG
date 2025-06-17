using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPistasEncontradas : MonoBehaviour
{
    public GameObject pista1;
    public GameObject pista2;
    public GameObject pista3;
    public GameObject pista4;
    public GameObject pista5;

    public GameObject panelPistas;
    public GameObject quitarPausa;

    public GameObject botonCierre;

    ObjetoInteractable objeto1;
    ObjetoInteractable objeto2;
    ObjetoInteractable objeto3;
    ObjetoInteractable objeto4;
    ObjetoInteractable objeto5;

    public bool pista1vista = false;
    public bool pista2vista = false;
    public bool pista3vista = false;
    public bool pista4vista = false;
    public bool pista5vista = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        objeto1 = pista1.GetComponent<ObjetoInteractable>();
        pista1vista = objeto1.encontrada;
        objeto2 = pista2.GetComponent<ObjetoInteractable>();
        pista2vista = objeto2.encontrada;
        objeto3 = pista3.GetComponent<ObjetoInteractable>();
        pista3vista = objeto3.encontrada;
        objeto4 = pista4.GetComponent<ObjetoInteractable>();
        pista4vista = objeto4.encontrada;
        objeto5 = pista5.GetComponent<ObjetoInteractable>();
        pista5vista = objeto5.encontrada;
    }

    public void TextoPista1()
    {
        quitarPausa.SetActive(true);
        botonCierre.SetActive(false);
        panelPistas.SetActive(false);
        Time.timeScale = 1f;
        objeto1.Pista();
    }

    public void TextoPista2()
    {
        quitarPausa.SetActive(true);
        botonCierre.SetActive(false);
        panelPistas.SetActive(false);
        Time.timeScale = 1f;
        objeto2.Pista();
    }

    public void TextoPista3()
    {
        quitarPausa.SetActive(true);
        botonCierre.SetActive(false);
        panelPistas.SetActive(false);
        Time.timeScale = 1f;
        objeto3.Pista();
    }

    public void TextoPista4()
    {
        quitarPausa.SetActive(true);
        botonCierre.SetActive(false);
        panelPistas.SetActive(false);
        Time.timeScale = 1f;
        objeto4.Pista();
    }

    public void TextoPista5()
    {
        quitarPausa.SetActive(true);
        botonCierre.SetActive(false);
        panelPistas.SetActive(false);
        Time.timeScale = 1f;
        objeto5.Pista();
    }
}
