using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

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

    [SerializeField]
    TMP_InputField firedelayInputField;

    [SerializeField]
    TMP_InputField forceInputField;

    [SerializeField]
    Scrollbar dispersionField;

    public void SetFireDelay(string value) => FireDelay = float.Parse(value);
    public void SetForce(string value) => Force = float.Parse(value);
    public void SetDispersion(float value) => Dispersion = value;

    private void Start()
    {
        firedelayInputField.text = "" + FireDelay;
        forceInputField.text = "" + Force;
        dispersionField.value = Dispersion;
    }


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
                (transform.forward + (transform.right * Random.Range(-1.0f, 1f) * Dispersion)) * Force, forceMode);

            p.transform.rotation = transform.rotation;

            p.AddComponent<DieAfterSeconds>();
        }
        ableToFire = true;
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
    }
}
