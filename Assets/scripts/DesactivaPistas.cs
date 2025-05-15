using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesactivaPistas : MonoBehaviour
{
    public GameObject pistaDesactivar;

    ObjetoInteractable objeto;
    Outline outline;
    public GameObject cuadroDialogo;
    ControlDialogos controlador;

    // Start is called before the first frame update
    void Start()
    {
        controlador = cuadroDialogo.GetComponent<ControlDialogos>();
        objeto = pistaDesactivar.GetComponent<ObjetoInteractable>();
        outline = pistaDesactivar.GetComponent<Outline>();
        objeto.enabled = false;
        outline.enabled = false;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && controlador.enDialogo)
        {
            objeto.enabled = false;
            outline.enabled = false;
        }
        else if (other.gameObject.tag == "Player")
        {
            objeto.enabled = true;
            outline.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        objeto.enabled = false;
        outline.enabled = false;
    }
}
