using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoInteractable : MonoBehaviour
{
    public Textos textos;
    public GameObject cuadroDialogo;
    ControlDialogos controlador;

    void Start()
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
}
