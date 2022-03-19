using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastleRefresher : MonoBehaviour
{
    [SerializeField]
    GameObject PrefabToSpawn;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            for (int i = transform.childCount; i > 0; i--)
            {
                Destroy(transform.GetChild(i - 1).gameObject);
                GameObject prefabToSpawn = Instantiate(PrefabToSpawn, this.transform);
            }
        }
    }
}
