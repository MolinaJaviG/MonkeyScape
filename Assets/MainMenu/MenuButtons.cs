using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    private GameObject gameManager;
    void Start()
    {
        gameManager = GameObject.Find("LogicaJuego");
    }

    public void IniciarPartida()
    {
        SceneManager.LoadScene("Level1");
    }
    public void CargarPartida()
    { 
    
    }
    public void Ajustes()
    {
        SceneManager.LoadScene("Ajustes");
    }
    public void Creditos() 
    {
        SceneManager.LoadScene("Creditos");
    }
    public void Salir()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
