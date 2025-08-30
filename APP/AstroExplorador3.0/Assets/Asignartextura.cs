using UnityEngine;

[RequireComponent(typeof(Camera))]
public class AssignRenderTexture : MonoBehaviour
{
    public RenderTexture renderTexture;

    void Start()
    {
        if (renderTexture != null)
        {
            Camera cam = GetComponent<Camera>();
            cam.targetTexture = renderTexture;
        }
    }
}
