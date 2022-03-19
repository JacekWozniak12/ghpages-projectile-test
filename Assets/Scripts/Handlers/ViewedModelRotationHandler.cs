using UnityEngine;
using UnityEngine.EventSystems;

public class ViewedModelRotationHandler : MonoBehaviour
{
    public float Sensivity = 25f;

    public void SetSensitivity(float t)
    {
        Sensivity = Mathf.Lerp(25, 500, t);
    }

    public void RotateY(PointerEventData pointerEventData)
    {
        Vector3 angles = transform.eulerAngles;
        transform.Rotate(
            0,
            -pointerEventData.delta.x * Sensivity * Time.deltaTime,
            0, Space.World);
    }
    public void RotateXY(PointerEventData pointerEventData)
    {
        Vector3 angles = transform.eulerAngles;
        transform.Rotate(
            pointerEventData.delta.y * Sensivity * Time.deltaTime,
            -pointerEventData.delta.x * Sensivity * Time.deltaTime,
            0, Space.World);
    }
    public void RotateX(PointerEventData pointerEventData) => RotateX(pointerEventData.delta.y);
    public void RotateX(float x)
    {
        Vector3 angles = transform.eulerAngles;
        transform.Rotate(
            x * Sensivity * Time.deltaTime,
            0,
            0, Space.World);
    }
    public void RotateXSelf(float x)
    {
        Vector3 angles = transform.eulerAngles;
        transform.Rotate(
            x * Sensivity * Time.deltaTime,
            0,
            0, Space.Self);
    }
}
