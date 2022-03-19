using System.Collections;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public float FireDelay;
    public float Force;

    [Range(0, 1)]
    public float Dispersion = 1;

    [SerializeField]
    Transform[] firePositions;

    [SerializeField]
    GameObject projectile;

    bool ableToFire = true;

    [SerializeField]
    ForceMode forceMode;

    public void Fire()
    {
        if (ableToFire)
        {
            StartCoroutine(HandleFiringProcess());
        }
    }

    public IEnumerator HandleFiringProcess()
    {
        ableToFire = false;
        foreach (Transform transform in firePositions)
        {
            yield return new WaitForSeconds(FireDelay);
            GameObject p = Instantiate(
                projectile, transform.position + transform.forward, transform.rotation);

            p.GetComponent<Rigidbody>().AddForce(
                (transform.forward * Force) + (transform.right * Random.Range(-1.0f, 1f) * Dispersion), forceMode);

            p.AddComponent<DieAfterSeconds>();
        }
        ableToFire = true;
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
    }
}
