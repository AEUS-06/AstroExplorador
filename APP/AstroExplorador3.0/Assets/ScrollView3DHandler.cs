using UnityEngine;

public class ScrollView3DHandler : MonoBehaviour
{
    public Camera renderCamera; // Cámara que enfocará los modelos 3D
    public float modelScale = 1.0f; // Escala de los modelos
    public Vector3 cameraOffset = new Vector3(0, 0, -10); // Desplazamiento de la cámara para enfocar los modelos

    void Start()
    {
        // Asegúrate de que la cámara está configurada
        if (renderCamera == null)
        {
            Debug.LogError("¡No hay cámara asignada al script! Por favor, asigna una cámara.");
            return;
        }

        // Ajusta la posición y escala de los modelos hijos
        foreach (Transform child in transform)
        {
            // Asegúrate de que cada hijo sea visible y tenga el tamaño adecuado
            child.localScale = Vector3.one * modelScale;
            child.gameObject.SetActive(true);
        }

        // Ajusta la posición de la cámara para que enfoque los modelos
        renderCamera.transform.position = transform.position + cameraOffset;
        renderCamera.transform.LookAt(transform.position);
    }
}
