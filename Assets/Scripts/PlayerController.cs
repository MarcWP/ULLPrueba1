using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpSpeed;
    public bool grounded;
    private Rigidbody2D rigidbody2d;
    private SpriteRenderer spriteRend;

    public GameObject enemigo;

    //Inicializamos las variables relevantes al movimiento
    private void Start()
    {
        spriteRend = gameObject.GetComponent<SpriteRenderer>();
        grounded = true;
        rigidbody2d = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        //Dependiendo de la tecla pulsada nos moveremos a los lados o saltaremos

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            spriteRend.flipX = true;

        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            spriteRend.flipX = false;

        }

        //Comprobación de salto en tierra
        if (grounded)
        {
            if (Input.GetKey(KeyCode.W))
            {
                //GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpSpeed);
                rigidbody2d.velocity = Vector2.up * jumpSpeed;
                grounded = false;
            }
        }
    }
}
