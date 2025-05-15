using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ControlDialogos : MonoBehaviour
{
    private Queue<string> colaDialogos = new Queue<string>();
    Textos texto;
    public GameObject cartel;
    Button botonCartel;
    public GameObject personajeDialogo;
    public GameObject personajePreguntas;
    public GameObject imagenHUD;
    public CanvasGroup miCanvas;
    public GameObject personaje;
    public GameObject botones;
    public GameObject alertas;
    public GameObject respuestas1;
    public GameObject respuestas2;
    public GameObject respuestas3;
    public GameObject respuestas4;
    public GameObject respuestas5;
    public GameObject fondoNegro;
    bool enPreguntas = false;
    bool respuestasCorrectas = false;
    public bool enDialogo = false;
    string fraseActual;
    int numPregunta;
    Movement movement;
    [SerializeField] TextMeshProUGUI textoPantalla;

    public void ActivarCartel(Textos textoObjeto)
    {
        movement = personaje.GetComponent<Movement>();
        movement.mover = false;
        enPreguntas = false;
        enDialogo = true;
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

    public void ActivarPreguntas(Textos textoObjeto)
    {
        botonCartel = cartel.GetComponent<Button>();
        botonCartel.enabled = false;
        numPregunta = 1;
        enPreguntas = true;
        enDialogo = true;
        movement = personaje.GetComponent<Movement>();
        movement.mover = false;
        texto = textoObjeto;
        respuestas1.SetActive(true);
        personajePreguntas.SetActive(true);
        fondoNegro.SetActive(true);
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
            personajePreguntas.SetActive(false);
            fondoNegro.SetActive(false);
            imagenHUD.SetActive(true);
            botones.SetActive(true);
            alertas.SetActive(true);
            movement.mover = true;
            enDialogo = false;
            return;
        }
        else if (enPreguntas)
        {
            //Debug.Log("El estado respuestas: " + respuestasCorrectas);
            switch (numPregunta)
            {
                case 1:
                    respuestas1.SetActive(true);
                    fraseActual = colaDialogos.Dequeue();
                    textoPantalla.text = fraseActual;
                    numPregunta++;
                    StartCoroutine(MostrarCaracteres(fraseActual));
                    break;
                case 2:
                    //activar preguntas 2
                    respuestas2.SetActive(true);
                    //desactivar preguntas 1
                    respuestas1.SetActive(false);
                    numPregunta++;
                    fraseActual = colaDialogos.Dequeue();
                    textoPantalla.text = fraseActual;
                    StartCoroutine(MostrarCaracteres(fraseActual));
                    break;
                case 3:
                    //activar preguntas 3
                    respuestas3.SetActive(true);
                    //desactivar preguntas 2
                    respuestas2.SetActive(false);
                    numPregunta++;
                    fraseActual = colaDialogos.Dequeue();
                    textoPantalla.text = fraseActual;
                    StartCoroutine(MostrarCaracteres(fraseActual));
                    break;
                case 4:
                    //activar preguntas 4
                    respuestas4.SetActive(true);
                    //desactivar preguntas 3
                    respuestas3.SetActive(false);
                    numPregunta++;
                    fraseActual = colaDialogos.Dequeue();
                    textoPantalla.text = fraseActual;
                    StartCoroutine(MostrarCaracteres(fraseActual));
                    break;
                case 5:
                    //activar preguntas 5
                    respuestas5.SetActive(true);
                    //desactivar preguntas 4
                    respuestas4.SetActive(false);
                    numPregunta++;
                    fraseActual = colaDialogos.Dequeue();
                    textoPantalla.text = fraseActual;
                    StartCoroutine(MostrarCaracteres(fraseActual));
                    break;
                case 6:
                    botonCartel.enabled = true;
                    respuestas5.SetActive(false);
                    enPreguntas = false;
                    if (respuestasCorrectas)
                    {
                        //Debug.Log("Todas las respuestas son corectas");
                        fraseActual = colaDialogos.Dequeue();
                        colaDialogos.Dequeue();
                        textoPantalla.text = fraseActual;
                        StartCoroutine(MostrarCaracteres(fraseActual));
                    }
                    else
                    {
                        colaDialogos.Dequeue();
                        fraseActual = colaDialogos.Dequeue();
                        textoPantalla.text = fraseActual;
                        StartCoroutine(MostrarCaracteres(fraseActual));
                    }
                    break;
            }
        }
        else
        {
            fraseActual = colaDialogos.Dequeue();
            textoPantalla.text = fraseActual;
            StartCoroutine(MostrarCaracteres(fraseActual));
        }
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

    public void respuestaCorrecta()
    {
        //Debug.Log("Respuesta Correcta");
        //Debug.Log("El numero de preguntas es" + numPregunta);
        if (numPregunta > 2)
        {
            if (respuestasCorrectas)
            {
                //Debug.Log("Se mantiene el true");
                SiguienteFrase();
            }
            else
            {
                SiguienteFrase();
            }
        }
        else if (numPregunta == 2)
        {
            //Debug.Log("Se puso en true");
            respuestasCorrectas = true;
            SiguienteFrase();
        }
    }

    public void respuestaIncorrecta()
    {
        respuestasCorrectas = false;
        SiguienteFrase();
    }

}

