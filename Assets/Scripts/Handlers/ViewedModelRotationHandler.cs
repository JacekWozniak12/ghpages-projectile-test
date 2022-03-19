using UnityEngine;
using UnityEngine.EventSystems;

public class ViewedModelRotationHandler : MonoBehaviour
{
    public float Sensivity = 5f;

    public void RotateXY(PointerEventData pointerEventData)
    {
        Vector3 angles = transform.eulerAngles;
        transform.Rotate(
            pointerEventData.delta.y * Sensivity * Time.deltaTime,
            -pointerEventData.delta.x * Sensivity * Time.deltaTime,
            0, Space.World);
    }

    public void RotateX(PointerEventData pointerEventData)
    {
        Vector3 angles = transform.eulerAngles;
        transform.Rotate(
            pointerEventData.delta.y * Sensivity * Time.deltaTime,
            0,
            0, Space.World);
    }

    public void RotateY(PointerEventData pointerEventData)
    {
        Vector3 angles = transform.eulerAngles;
        transform.Rotate(
            0,
            -pointerEventData.delta.x * Sensivity * Time.deltaTime,
            0, Space.World);
    }
}
