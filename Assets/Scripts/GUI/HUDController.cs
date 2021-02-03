using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUDController : MonoBehaviour
{
    public GameObject camRig;
    private OrbitCamControl component;
    public TMP_Text textTimeScale;
    

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

    public void speedSlider(float amt)
    {
        if (amt < 0)
        {
            GameManager.timeSpeed = -amt;
            GameManager.rewind = true;
            textTimeScale.text = System.Math.Round(-GameManager.timeSpeed, 1).ToString();
        }
        else
        {
            GameManager.timeSpeed = amt;
            GameManager.rewind = false;
            textTimeScale.text = System.Math.Round(GameManager.timeSpeed, 1).ToString();
        }
            
    }
    
}
