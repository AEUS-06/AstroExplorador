using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Método para cargar la escena de AR
    public void LoadARScene()
    {
        // Cambia "NombreDeTuEscenaAR" por el nombre exacto de la escena que quieres cargar
        SceneManager.LoadScene("planetasra");
    }
}
