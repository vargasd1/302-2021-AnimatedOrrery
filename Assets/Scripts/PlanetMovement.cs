using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetMovement : MonoBehaviour
{

    public Transform target;

    public float radius = 2;
    private float age = 0;
    public float speed = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        age += Time.deltaTime;

        Vector3 offset = AnimMath.revolve(radius, age, speed);

        transform.position = target.position + offset;

    }
}
