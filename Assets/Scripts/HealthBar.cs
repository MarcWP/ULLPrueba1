using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;

    //ajustes de vida máxima para el slider
    public void setMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }
    //función para invocación del slider
    public void setHealth(int health)
    {
        slider.value = health;
    }
}

