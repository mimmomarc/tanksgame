using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    // Start is called before the first frame update

    public Slider slider;
    public Image imgHealthBar;
    public Gradient gradient;
   


    public void setHealth(int value)
    {
        slider.value = value;

    }

    public void setMaxHealth(int value)
    {
        slider.maxValue = value;
        slider.value = value;
        imgHealthBar.color = gradient.Evaluate(1f);
    }

    public void decrementHealth(int value)
    {
        slider.value -= value;
        imgHealthBar.color = gradient.Evaluate(slider.normalizedValue);

        Debug.Log(slider.normalizedValue);


    }

    

}
