using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float velocidad;
    float movimientoHorizontal;
    float movimientoVertical;
    public bool mover = true;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        velocidad = 7f;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (mover)
        {
            movimientoHorizontal = Input.GetAxis("Horizontal");
            movimientoVertical = Input.GetAxis("Vertical");
            if (Input.GetKeyDown(KeyCode.A))
            {
                animator.SetBool("moverIz", true);
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                animator.SetBool("moverD", true);
            }
            else if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S))
            {
                animator.SetBool("moverD", true);
            }
            else if (!Input.anyKey)
            {
                animator.SetBool("moverD", false);
                animator.SetBool("moverIz", false);
            }

            Vector3 movimiento = new Vector3(movimientoHorizontal, 0, movimientoVertical);
            transform.Translate(movimiento * velocidad * Time.deltaTime);
        }
        
    }
}
