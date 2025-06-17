using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{

    public GameObject pauseMenuUI;
    public GameObject quitarPausa;
    public GameObject botonCierre;
    public GameObject pantallaTutorial;
    public GameObject pantallaPistas;
    public GameObject botonesPistas;
    private bool isPaused = false;

    public GameObject pista1;
    public GameObject pista2;
    public GameObject pista3;
    public GameObject pista4;
    public GameObject pista5;

    public GameObject evento;
    ControladorPistasEncontradas cPistas;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        quitarPausa.SetActive(true);
        pauseMenuUI.SetActive(false);
        botonCierre.SetActive(false);
        pantallaTutorial.SetActive(false);
        pantallaPistas.SetActive(false);
        botonesPistas.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void Pause()
    {
        quitarPausa.SetActive(false);
        pauseMenuUI.SetActive(true);
        botonCierre.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void Tutorial()
    {
        quitarPausa.SetActive(false);
        botonCierre.SetActive(true);
        pantallaTutorial.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void Inicio()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }

    public void Pistas()
    {
        quitarPausa.SetActive(false);
        pauseMenuUI.SetActive(false);
        botonCierre.SetActive(true);
        botonesPistas.SetActive(true);
        pantallaPistas.SetActive(true);
        cPistas = evento.GetComponent<ControladorPistasEncontradas>();
        if (cPistas.pista1vista)
        {
            pista1.SetActive(true);
        }
        if (cPistas.pista2vista)
        {
            pista2.SetActive(true);
        }
        if (cPistas.pista3vista)
        {
            pista3.SetActive(true);
        }
        if (cPistas.pista4vista)
        {
            pista4.SetActive(true);
        }
        if (cPistas.pista5vista)
        {
            pista5.SetActive(true);
        }
    }

    public void Exit()
    {
        Debug.Log("Saliendo...");
        Application.Quit();
    }
}
