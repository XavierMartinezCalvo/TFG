using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoInteractable : MonoBehaviour
{
    public Textos textos;
    public GameObject cuadroDialogo;
    public GameObject alertaCuadro;
    ControlDialogos controlador;

    void Awake()
    {
        controlador = cuadroDialogo.GetComponent<ControlDialogos>();
    }

    private void OnMouseDown()
    {
        if (controlador != null)
        {
            controlador.ActivarCartel(textos);
        }
    }

    public void EntraAlerta()
    {
        alertaCuadro.SetActive(false);
        if (controlador != null)
        {
            controlador.ActivarCartel(textos);
        }
    }

    public void Exclamacion()
    {
        if (controlador != null)
        {
            controlador.ActivarPreguntas(textos);
        }
    }
}
