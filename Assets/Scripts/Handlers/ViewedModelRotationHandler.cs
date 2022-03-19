using UnityEngine;
using UnityEngine.EventSystems;

public class ViewedModelRotationHandler : MonoBehaviour
{
    public float Sensivity = 5f;
    Vector3 defaultRotation;

    [SerializeField]
    Vector3 endRotation = new Vector3(30, 0, 0);

    public void Start()
    {
        defaultRotation = transform.localRotation.eulerAngles;
        endRotation = defaultRotation + endRotation;
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

    public void RotateXLerp(float x)
    {
        Vector3 v3 = Vector3.Lerp(defaultRotation, endRotation, x);
        transform.localRotation = Quaternion.Euler(v3);
    }

    public void RotateXSelf(float x)
    {
        Vector3 angles = transform.eulerAngles;
        transform.Rotate(
            x * Sensivity * Time.deltaTime,
            0,
            0, Space.Self);
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
