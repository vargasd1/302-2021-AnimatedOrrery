using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitCamControl : MonoBehaviour
{
    
    float pitch = 0;
    float targetPitch = 0;
    float yaw = 0;
    float targetYaw = 0;
    float zoomDis = 10;
    float targetZoomDis = 10;

    public float mouseSensitivityX = 1;
    public float mouseSensitivityY = 1;
    public float mouseScrollMultiplier = 5;

    public GameObject Star;
    public GameObject Planet1;
    public GameObject Planet2;
    public GameObject Planet3;
    public GameObject Planet4;
    public GameObject Planet5;
    private Vector3 target;

    public int planetValue = 0;
    public bool doOnce = true; 


    private Camera cam; 
   
    void Start()
    {
        cam = GetComponentInChildren<Camera>();
    }

    
    void Update()
    {
        goToPlanet();

        transform.position = AnimMath.Slide(transform.position, target, .05f);


        if (Input.GetButton("Fire2"))
        {
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");

            targetYaw += mouseX * mouseSensitivityX;
            targetPitch += mouseY * mouseSensitivityY;
        }

        float scroll = Input.GetAxisRaw("Mouse ScrollWheel");
        targetZoomDis += scroll * mouseScrollMultiplier;
        targetZoomDis = Mathf.Clamp(targetZoomDis, 2.5f, 15f);

        zoomDis = AnimMath.Slide(zoomDis, targetZoomDis, .05f);

        cam.transform.localPosition = new Vector3(0, 0, -zoomDis);

        targetPitch = Mathf.Clamp(targetPitch, -89, 89);

        pitch = AnimMath.Slide(pitch, targetPitch, .05f);
        yaw = AnimMath.Slide(yaw, targetYaw, .05f);

        transform.rotation = Quaternion.Euler(pitch, yaw, 0);
    }

    void goToPlanet()
    {
        if(planetValue == 0)
        {
            target = Star.transform.position;
            if (doOnce)
            {
                targetZoomDis = 15;
                doOnce = false;
            }
        }
        else if(planetValue == 1)
        {
            target = Planet1.transform.position;
            if (doOnce)
            {
                targetZoomDis = 5;
                doOnce = false;
            }
        }
        else if(planetValue == 2)
        {
            target = Planet2.transform.position;
            if (doOnce)
            {
                targetZoomDis = 5;
                doOnce = false;
            }
        }
        else if(planetValue == 3)
        {
            target = Planet3.transform.position;
            if (doOnce)
            {
                targetZoomDis = 5;
                doOnce = false;
            }
        }
        else if(planetValue == 4)
        {
            target = Planet4.transform.position;
            if (doOnce)
            {
                targetZoomDis = 5;
                doOnce = false;
            }
        }
        else if(planetValue == 5)
        {
            target = Planet5.transform.position;
            if (doOnce)
            {
                targetZoomDis = 5;
                doOnce = false;
            }
        }
    }
}
