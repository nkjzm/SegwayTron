using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    void Start()
    {
        Launch();
    }

    public void Launch()
    {
        var target = FindObjectOfType<Foot>().transform;
        var pos = Random.insideUnitSphere;
        pos.y = 0;
        pos *= 5;
        var diff = target.position - pos;
        transform.position = pos - diff.normalized;
        transform.LookAt(target);
    }

    void Update()
    {
        transform.position += Time.deltaTime * transform.forward;
        if (transform.position.magnitude > 10)
        {
            Destroy(gameObject);
        }
    }
}
