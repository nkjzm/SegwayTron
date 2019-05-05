using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileGenerator : MonoBehaviour
{
    [SerializeField]
    GameObject Prefab;
    IEnumerator Launch()
    {
        yield return new WaitForSeconds(15f);
        while (true)
        {
            yield return new WaitForSeconds(1.5f);
            Instantiate(Prefab);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(Launch());
        }
    }
}
