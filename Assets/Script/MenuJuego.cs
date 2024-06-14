using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuJuego : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }
    public void InciarJuego()
    {
        SceneManager.LoadScene("SampleScene"); // Cambia  escena de juego inial
    }
    public void Volver()
    {
        SceneManager.LoadScene("Menu"); // Cambia  escena de juego inial
    }
    public void vermenu()
    {
        SceneManager.LoadScene("Menu"); // Cambia  escena de juego inial
    }
    public void Instrucciones()
    {
        SceneManager.LoadScene("Instrucciones"); // Cambia "InstructionsScene" al nombre de tu escena de instrucciones
    }

    public void Salir()
    {
        Application.Quit(); // Salir del juego 
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
