using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTruth : MonoBehaviour
{

    //Comprobación del estado de contacto con el suelo, tue en contacto y false en el aire
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Suelo")
        {
            GetComponentInParent<PlayerController>().grounded = true;
        }
    }



    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Suelo")
        {
            GetComponentInParent<PlayerController>().grounded = false;
        }
    }
}
