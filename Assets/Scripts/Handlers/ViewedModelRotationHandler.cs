using UnityEngine;
using UnityEngine.EventSystems;

public class ViewedModelRotationHandler : MonoBehaviour
{
    public float Sensitivity = 25f;
    public void SetSensitivity(float t) => Sensitivity = Mathf.Lerp(25, 500, t);

    public void RotateY(PointerEventData pointerEventData)
    {
        Vector3 angles = transform.eulerAngles;
        transform.Rotate(
            0,
            -pointerEventData.delta.x * Sensitivity * Time.deltaTime,
            0, Space.World);
    }
    
    public void RotateXY(PointerEventData pointerEventData)
    {
        Vector3 angles = transform.eulerAngles;
        transform.Rotate(
            pointerEventData.delta.y * Sensitivity * Time.deltaTime,
            -pointerEventData.delta.x * Sensitivity * Time.deltaTime,
            0, Space.World);
    }
    
    public void RotateX(PointerEventData pointerEventData) => RotateX(pointerEventData.delta.y);
    
    public void RotateX(float x)
    {
        Vector3 angles = transform.eulerAngles;
        transform.Rotate(
            x * Sensitivity * Time.deltaTime,
            0,
            0, Space.World);
    }

    public void RotateXSelf(float x)
    {
        Vector3 angles = transform.eulerAngles;
        transform.Rotate(
            x * Sensitivity * Time.deltaTime,
            0,
            0, Space.Self);
    }
}
