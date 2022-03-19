using UnityEngine;
using UnityEngine.EventSystems;

public class ZoomHandler : MonoBehaviour
{
    public float Sensivity = 5f;

    public void Zoom(PointerEventData pointerEventData)
    {
        transform.position += 
            transform.forward * Sensivity * 
            pointerEventData.scrollDelta.y * Time.deltaTime;
    }
}
