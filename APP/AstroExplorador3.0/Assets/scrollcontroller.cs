using UnityEngine;

public class ScrollBounds : MonoBehaviour
{
    public RectTransform content; // Referencia al Content
    public RectTransform viewport; // Referencia al Viewport

    void LateUpdate()
    {
        // Obtén la posición actual del Content
        Vector3 contentPosition = content.localPosition;

        // Calcula los límites del Viewport y Content
        float viewportWidth = viewport.rect.width;
        float viewportHeight = viewport.rect.height;
        float contentWidth = content.rect.width;
        float contentHeight = content.rect.height;

        // Calcula límites en base a la diferencia de tamaños
        float minX = Mathf.Min(0, (viewportWidth - contentWidth) / 2);
        float maxX = Mathf.Max(0, (contentWidth - viewportWidth) / 2);
        float minY = Mathf.Min(0, (viewportHeight - contentHeight) / 2);
        float maxY = Mathf.Max(0, (contentHeight - viewportHeight) / 2);

        // Restringe el movimiento del Content dentro de los límites
        contentPosition.x = Mathf.Clamp(contentPosition.x, -maxX, minX);
        contentPosition.y = Mathf.Clamp(contentPosition.y, -maxY, minY);

        // Aplica la posición corregida
        content.localPosition = contentPosition;
    }
}
