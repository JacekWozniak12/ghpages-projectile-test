using UnityEngine;
using UnityEngine.EventSystems;

public class ZoomHandler : MonoBehaviour
{
    public float Sensivity = 25f;

    public void SetSensitivity(float t)
    {
        Sensivity = Mathf.Lerp(25, 500, t);
    }

    public void Zoom(PointerEventData pointerEventData)
    {
        transform.position +=
            transform.forward * Sensivity *
            pointerEventData.scrollDelta.y * Time.deltaTime;
    }
}
