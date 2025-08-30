using UnityEngine;

public class ShowObjectOnButton : MonoBehaviour
{
    public GameObject objectToActivate; // Referencia al objeto 3D

    // Método para mostrar el objeto
    public void ActivateObject()
    {
        if (objectToActivate != null)
        {
            objectToActivate.SetActive(true);
        }
    }
}
