using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader2 : MonoBehaviour
{
    // Método para cargar la escena de AR
    public void LoadUIScene()
    {
        // Cambia "NombreDeTuEscenaAR" por el nombre exacto de la escena que quieres cargar
        SceneManager.LoadScene("IU astromos");
    }
}
