using UnityEngine;

public class Vector3RotationLerpHandler : MonoBehaviour
{
    [SerializeField]
    Vector3 endRotation = new Vector3(30, 0, 0);

    [SerializeField]
    Vector3 startRotation = new Vector3(0, 0, 0);

    void Start()
    {
        startRotation += transform.localRotation.eulerAngles;
        endRotation += transform.localRotation.eulerAngles;
    }

    public void Lerp(float t)
    {
        Vector3 v3 = Vector3.Lerp(startRotation, endRotation, t);
        transform.localRotation = Quaternion.Euler(v3);
    }
}