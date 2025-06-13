using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{

    public GameObject pantallaAjustes;

    public void NewGame()
    {
        SceneManager.LoadScene("EscenaPrincipal");
    }

    public void Exit()
    {
        Debug.Log("Saliendo...");
        Application.Quit();
    }
}
