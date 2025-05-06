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
    public CanvasGroup miCanvas;
    [SerializeField] TextMeshProUGUI textoPantalla;

    public void ActivarCartel(Textos textoObjeto)
    {
        texto = textoObjeto;
        personajeDialogo.SetActive(true);
        cartel.SetActive(true);
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

