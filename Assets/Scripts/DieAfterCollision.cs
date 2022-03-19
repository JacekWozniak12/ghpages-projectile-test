using UnityEngine;

public class DieAfterCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        StopAllCoroutines();
        Destroy(gameObject);
    }
}