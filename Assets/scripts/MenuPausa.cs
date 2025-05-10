using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPausa : MonoBehaviour
{

    public GameObject pauseMenuUI;
    public GameObject quitarPausa;
    public GameObject botonCierre;
    public GameObject pantallaTutorial;
    private bool isPaused = false;

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

    public void Exit()
    {
        Debug.Log("Saliendo...");
        Application.Quit();
    }
}
