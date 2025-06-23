using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{

    public GameObject pantallaAjustes;
    public AudioSource fuenteSonido;

    public void NewGame()
    {
        fuenteSonido.Play();
        SceneManager.LoadScene("EscenaPrincipal");
    }

    public void Exit()
    {
        fuenteSonido.Play();
        Debug.Log("Saliendo...");
        Application.Quit();
    }
}
