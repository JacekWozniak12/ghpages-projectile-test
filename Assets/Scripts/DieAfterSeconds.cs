using System.Collections;
using UnityEngine;

public class DieAfterSeconds : MonoBehaviour
{
    public float Seconds = 10f;

    private void OnEnable()
    {
        StartCoroutine(WaitAndDie());
    }

    private IEnumerator WaitAndDie()
    {
        yield return new WaitForSeconds(10);
        Destroy(this.gameObject);
    }
}