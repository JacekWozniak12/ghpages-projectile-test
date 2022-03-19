using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(RectTransform))]
public class UIDragController : MonoBehaviour, IDragHandler
{
    public UnityEvent<PointerEventData> DragEvent;

    public void OnDrag(PointerEventData eventData)
    {
        DragEvent?.Invoke(eventData);
    }
}
