using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDController : MonoBehaviour
{
    public GameObject camRig;
    private OrbitCamControl component; 

    // Start is called before the first frame update
    void Start()
    {
        component = camRig.GetComponent<OrbitCamControl>();
    }

    public void focusStar()
    {
        component.planetValue = 0;
        component.doOnce = true;
    }

    public void focusEos()
    {
        component.planetValue = 1;
        component.doOnce = true;
    }

    public void focusTalum()
    {
        component.planetValue = 2;
        component.doOnce = true;
    }

    public void focusDuat()
    {
        component.planetValue = 3;
        component.doOnce = true;
    }

    public void focusCanto()
    {
        component.planetValue = 4;
        component.doOnce = true;
    }

    public void focusRasuna()
    {
        component.planetValue = 5;
        component.doOnce = true;
    }


}
