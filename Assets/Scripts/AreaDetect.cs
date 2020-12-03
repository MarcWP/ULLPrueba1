using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaDetect : MonoBehaviour
{

    //Timer para gestión eventos que solo deben ocurrir cada x segundos
    float Timer;
    void Update()
    {
        if (Timer > 0)
        {
            Timer -= Time.deltaTime;
        }
    }

    //Si estamos cerca de un ememigo recibimos daño cada x tiempo, si es un gato recuperamos poder
    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.tag=="player")
        {
            if (gameObject.tag == "enemigo")
            {
                if (Timer <= 0)
                {
                    EventManager.current.takeHit();
                    Timer = 0.1f;
                }
            }
            else
            {
                if (Timer <= 0)
                {
                    EventManager.current.addPower();
                    Timer = 0.1f;
                }
            }
        }
        
    }
}
