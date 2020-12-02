using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mojon : MonoBehaviour
{

    //Al pasar por encima del mojon lo recogemos
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="player")
        {
            EventManager.current.pickUp();
            gameObject.SetActive(false);
        }
    }
}
