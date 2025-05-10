using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesactivaPistas : MonoBehaviour
{
    public GameObject pistaDesactivar;

    ObjetoInteractable objeto;
    Outline outline;


    // Start is called before the first frame update
    void Start()
    {
        objeto = pistaDesactivar.GetComponent<ObjetoInteractable>();
        outline = pistaDesactivar.GetComponent<Outline>();
        objeto.enabled = false;
        outline.enabled = false;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
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
