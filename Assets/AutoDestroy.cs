using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroy : MonoBehaviour
{

    // Use this for initialization
    IEnumerator Start()
    {
        yield return new WaitForSeconds(4f);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
