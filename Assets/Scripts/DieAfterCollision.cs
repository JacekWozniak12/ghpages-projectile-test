using System.Collections;
using UnityEngine;

public class DieAfterCollision : MonoBehaviour
{
    public float Seconds = 10f;

    private void OnCollisionEnter(Collision other)
    {
        StopAllCoroutines();
        Destroy(gameObject);
    }
}