using UnityEngine;

public class PlanetButton : MonoBehaviour
{
    public int planetIndex;  // El índice del planeta para identificar cuál es el seleccionado

    // Este método se llama cuando el planeta es clickeado
    private void OnMouseDown()
    {
        PlanetManager.Instance.SelectPlanet(planetIndex);
    }
}
