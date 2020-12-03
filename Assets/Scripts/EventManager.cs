using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{

    public static EventManager current;

    private void Awake()
    {
        current = this;
    }
    //Aqui empiezan los eventos

        //evento de daño
    public event Action onTakeHit;

    public void takeHit()
    {
        if (onTakeHit != null)
        {
            onTakeHit();
        }
    }
    //Evento para recuperar puntos
    public event Action onAddPower;

    public void addPower()
    {
        if (onAddPower != null)
        {
            onAddPower();
        }
    }

    //Evento recogida mojon
    public event Action onPickUp;

    public void pickUp()
    {
        if (onPickUp != null)
        {
            onPickUp();
        }
    }

    //Evento en caso de muerte
    public event Action onDeath;

    public void death()
    {
        if (onDeath != null)
        {
            onDeath();
        }
    }


    //Evento en caso de contacto con enemigo
    public event Action onContact;

    public void contact()
    {
        if (onContact != null)
        {
            onContact();
        }
    }
}
