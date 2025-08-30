using UnityEngine;

public class TestClick : MonoBehaviour
{
    private void OnMouseDown()
    {
        Debug.Log("Hiciste clic en: " + gameObject.name);
    }
}
