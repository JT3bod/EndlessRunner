using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerScript : MonoBehaviour {
    public Slider sliderInstance;
    void Start()
    {
        sliderInstance.minValue = 0;
        sliderInstance.maxValue = 100;
        sliderInstance.wholeNumbers = false;
        sliderInstance.value = 0;
    }
    void Update()
    {
        if (sliderInstance.value < 100f)
        { sliderInstance.value += 1f; }
        if (Input.GetKey(KeyCode.X))
        {
            if (sliderInstance.value == 100)
            {
                sliderInstance.value = 0;
            }
        }
    }
   public void OnValueChanged(float value)
    {
        
    }
}