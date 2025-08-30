using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using System.Collections.Generic;

public class AnchorPlacement : MonoBehaviour
{
    public ARRaycastManager raycastManager; // Referencia al ARRaycastManager
    public GameObject objectToPlace;        // El objeto 3D que queremos anclar

    private ARAnchor anchor;               // El anclaje que vamos a crear

    void Update()
    {
        if (Input.touchCount > 0)  // Detecta si el usuario toca la pantalla
        {
            Touch touch = Input.GetTouch(0);  // Obtiene el primer toque

            if (touch.phase == TouchPhase.Began)  // Si el toque acaba de empezar
            {
                Vector2 touchPosition = touch.position;

                // Realizamos un raycast desde la posición del toque
                List<ARRaycastHit> hits = new List<ARRaycastHit>();
                raycastManager.Raycast(touchPosition, hits, TrackableType.Planes);

                if (hits.Count > 0)  // Si se detecta una superficie
                {
                    ARRaycastHit hit = hits[0]; // Toma el primer hit (superficie detectada)

                    // Crear un nuevo ARAnchor en la posición del raycast
                    Pose hitPose = hit.pose;
                    
                    // Crear un anchor en la posición detectada
                    anchor = new GameObject("ARAnchor").AddComponent<ARAnchor>();
                    anchor.transform.position = hitPose.position;
                    anchor.transform.rotation = hitPose.rotation;

                    // Coloca el objeto en la posición del anchor
                    objectToPlace.transform.position = anchor.transform.position;
                    objectToPlace.transform.rotation = anchor.transform.rotation;

                    // Coloca el objeto como hijo del anchor
                    objectToPlace.transform.SetParent(anchor.transform);
                }
            }
        }
    }
}
