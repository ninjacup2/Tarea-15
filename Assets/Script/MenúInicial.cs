using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorDeEscenas : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Salir()
    {
        Debug.Log("Saliendo del Videojuego");
        Application.Quit();
    }
}

