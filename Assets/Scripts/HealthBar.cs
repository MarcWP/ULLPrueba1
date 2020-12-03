using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;

    //Ajustes de vida máxima para el slider
    public void setMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }
    //Función para invocación del slider
    public void setHealth(int health)
    {
        slider.value = health;
    }
}

