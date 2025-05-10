using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControlDialogos : MonoBehaviour
{
    private Queue<string> colaDialogos = new Queue<string>();
    Textos texto;
    public GameObject cartel;
    public GameObject personajeDialogo;
    public GameObject imagenHUD;
    public CanvasGroup miCanvas;
    public GameObject personaje;
    public GameObject botones;
    public GameObject alertas;
    Movement movement;
    [SerializeField] TextMeshProUGUI textoPantalla;

    public void ActivarCartel(Textos textoObjeto)
    {
        movement = personaje.GetComponent<Movement>();
        movement.mover = false;
        texto = textoObjeto;
        personajeDialogo.SetActive(true);
        cartel.SetActive(true);
        imagenHUD.SetActive(false);
        botones.SetActive(false);
        alertas.SetActive(false);
        colaDialogos.Clear();
        foreach (string textoGuardar in texto.arrayTextos)
        {
            colaDialogos.Enqueue(textoGuardar);
        }
        SiguienteFrase();
    }

    public void SiguienteFrase()
    {
        if (colaDialogos.Count == 0)
        {
            cartel.SetActive(false);
            personajeDialogo.SetActive(false);
            imagenHUD.SetActive(true);
            botones.SetActive(true);
            alertas.SetActive(true);
            movement.mover = true;
            return;
        }

        string fraseActual = colaDialogos.Dequeue();
        textoPantalla.text = fraseActual;
        StartCoroutine(MostrarCaracteres(fraseActual));
    }

    IEnumerator MostrarCaracteres (string textoAMostrar)
    {
        miCanvas.blocksRaycasts = false;
        textoPantalla.text = "";
        foreach (char caracter in textoAMostrar.ToCharArray())
        {
            textoPantalla.text += caracter;
            yield return new WaitForSeconds(0.02f);
        }
        miCanvas.blocksRaycasts = true;
    }
}

