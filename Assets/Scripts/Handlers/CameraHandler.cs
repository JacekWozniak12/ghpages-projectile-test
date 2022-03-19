using UnityEngine;
using UnityEngine.EventSystems;

public class CameraHandler : MonoBehaviour
{
    public float Sensivity = 25f;

    public void Move(PointerEventData pointerEventData)
    {
        transform.Translate(
            Vector3.forward *
            pointerEventData.scrollDelta.y *
            Time.deltaTime * Sensivity, 
            Space.Self
            );
    }
}
