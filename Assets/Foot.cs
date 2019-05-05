using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foot : MonoBehaviour
{
    [SerializeField]
    Transform Tracker;
    [SerializeField]
    GameObject Effect;
    void Start()
    {

    }

    void Update()
    {
        var pos = Tracker.position;
        pos.y = 0;
        transform.position = pos;
        transform.eulerAngles = new Vector3(0, Tracker.eulerAngles.y, 0);
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if (other.name.Contains("Missile"))
        {
            Instantiate(Effect);
            Effect.transform.position = transform.position;
        }
    }
}
