using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetMovement : MonoBehaviour
{

    public Transform target;

    public float radius = 2;
    private float age = 0;
    public float speed = 1;
    private float rotY; 


    private void Start()
    {
       // age = Random.Range(0, 10);
    }

    // Update is called once per frame
    void Update()
    {
        age += Time.deltaTime;

        Vector3 offset = AnimMath.revolve(radius, age, speed);

        transform.position = target.position + offset;

        rotY += Time.deltaTime * speed;

        transform.rotation = Quaternion.Euler(0, rotY, 0);

    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(target.position, radius);
    }
}
