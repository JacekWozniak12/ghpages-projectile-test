using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.Events;

public class UIScrollController : MonoBehaviour, IScrollHandler
{
    public UnityEvent<PointerEventData> ScrollEvent;

    public void OnScroll(PointerEventData eventData)
    {
        ScrollEvent?.Invoke(eventData);
    }
}
