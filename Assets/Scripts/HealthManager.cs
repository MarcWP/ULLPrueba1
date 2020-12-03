using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int TotalHealth = 100;
    public int updatedHealth;
    public HealthBar healthbar;

    void Start()
    {
        updatedHealth = TotalHealth;
        EventManager.current.onTakeHit += substractHealth;
        EventManager.current.onAddPower += addHealth;
    }
    //Quitamos un punto de vida al permanecer cerca de un enemigo
    private void substractHealth()
    {
        updatedHealth -= 1;
        healthbar.setHealth(updatedHealth);
        if (updatedHealth==0)
        {
            updatedHealth = 100;
            healthbar.setHealth(updatedHealth);
            EventManager.current.contact();
        }
    }
    //Recuperamos un punto de vida al permanecer cerca del gato
    private void addHealth()
    {
        updatedHealth += 1;
        healthbar.setHealth(updatedHealth);

    }


}
