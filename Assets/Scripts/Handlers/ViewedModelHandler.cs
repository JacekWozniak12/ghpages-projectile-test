using System.Diagnostics;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class ViewedModelHandler : MonoBehaviour
{
    public float Sensivity = 5f;

    public void SetModel(GameObject gameObject = null)
    {
        for (int i = transform.childCount; i > 0; i--)
        {
            Destroy(transform.GetChild(i - 1).gameObject);
        }

        if (gameObject != null)
        {
            GameObject init = Instantiate(gameObject);
            transform.SetParent(init.transform, false);
        }
    }

    public void Rotate(PointerEventData pointerEventData)
    {
        Vector3 angles = transform.eulerAngles;
        transform.Rotate(
            pointerEventData.delta.y * Sensivity * Time.deltaTime, 
            -pointerEventData.delta.x * Sensivity * Time.deltaTime, 
            0, Space.World);
    }
}
