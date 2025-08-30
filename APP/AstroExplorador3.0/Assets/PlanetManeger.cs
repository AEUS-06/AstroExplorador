using UnityEngine;
using TMPro;  // Para TextMeshPro

public class PlanetManager : MonoBehaviour
{
    public static PlanetManager Instance;  // Instancia estática de PlanetManager

    public GameObject[] planets;  // Los planetas en el contenedor central
    public TextMeshProUGUI planetNameText;  // Para mostrar el nombre del planeta en la interfaz
    public Transform planetModelsContainer;  // Contenedor de los planetas en el centro

    private int selectedPlanetIndex = 0;  // Índice del planeta seleccionado

    void Awake()
    {
        // Asegúrate de que solo haya una instancia de PlanetManager
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);  // No destruir este objeto al cambiar de escena
        }
        else
        {
            Destroy(gameObject);  // Destruir el objeto si ya existe una instancia
        }
    }

    public void SelectPlanet(int index)
    {
        // Apagar todos los planetas primero
        foreach (Transform child in planetModelsContainer)
        {
            child.gameObject.SetActive(false);
        }

        // Activar el planeta seleccionado
        if (index >= 0 && index < planets.Length)
        {
            GameObject selectedPlanet = planets[index];
            selectedPlanet.SetActive(true);
            planetNameText.text = selectedPlanet.name;
            selectedPlanetIndex = index;
        }
        else
        {
            Debug.LogError("Índice fuera de rango.");
        }
    }
}
