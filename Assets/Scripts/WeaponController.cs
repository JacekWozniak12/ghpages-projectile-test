using System.Collections;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    [SerializeField]
    Transform[] firePositions;

    [SerializeField]
    GameObject projectile;

    bool ableToFire = true;

    [SerializeField]
    float fireDelay;

    [SerializeField]
    float force;

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
            yield return new WaitForSeconds(fireDelay);
            GameObject p = Instantiate(projectile, transform.position + transform.forward, transform.rotation);
            p.GetComponent<Rigidbody>().AddForce(
                transform.forward * force, forceMode);
                p.AddComponent<DieAfterSeconds>();
        }
        ableToFire = true;
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
    }
}
