using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAlerta : MonoBehaviour
{
    public GameObject alerta;
    public GameObject personaje;
    Movement movement;

    private void OnTriggerStay(Collider other)
    {
        movement = personaje.GetComponent<Movement>();
        if (other.gameObject.tag == "Player" && movement.mover)
        {
            alerta.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        alerta.SetActive(false);
    }
}
