using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour
{
    float Timer;

    void Update()
    {
        if (Timer > 0)
        {
            Timer -= Time.deltaTime;
        }
    }

    //Si hay coplisión quitamos vida
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (Timer <= 0)
        {
            if (collision.gameObject.tag == "player")
            {
                EventManager.current.contact();
                Timer = 1f;
            }
        }
    }
}
