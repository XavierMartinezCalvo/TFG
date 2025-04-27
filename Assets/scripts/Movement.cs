using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float velocidad;
    float movimientoHorizontal;
    float movimientoVertical;

    // Start is called before the first frame update
    void Start()
    {
        velocidad = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        movimientoHorizontal = Input.GetAxis("Horizontal");
        movimientoVertical = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movimientoHorizontal, 0, movimientoVertical);
        transform.Translate(movimiento * velocidad * Time.deltaTime);
    }
}
