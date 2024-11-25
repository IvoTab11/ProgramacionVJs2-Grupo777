using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Gestiona los movimientos horizontales del personaje.
public class PlayerMovement : Player
{
    /* Representa la velocidad de movimiento.*/
    [SerializeField] private float movementSpeed ;
    /* Representa el valor de mirar a la derecha.*/
    private bool isFacingRight = true;
    /* Referencia al componente Rigidbody2D del personaje.*/
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        /*Se obtiene la entrada de movimiento horizontal*/
        float movementX = Input.GetAxis("Horizontal");
        /* Multiplica la entrada por la velocidad de movimiento y deltaTime*/
        Move(movementX * movementSpeed * Time.deltaTime);

        /*El personaje gira si se mueve a la izquierda*/
        if (movementX < 0 && isFacingRight)
        {
            Flip();
        }
        /* El personaje gira si se mueve a la derecha*/
        else if (movementX > 0 && !isFacingRight)
        {
            Flip();
        }
    }

    public void Move(float velocityX)
    {
        /*Se establece la velocidad en el Rigidbody2D, aplicando deltaTime solo una vez en Update*/
        rb.velocity = new Vector2(velocityX, rb.velocity.y);
    }

    private void Flip()
    {
        /* Cambia la escala en el eje X para voltear al personaje*/
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        isFacingRight = !isFacingRight;
    }

   /* public override void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Objetivo"))
        {
            enabled = false;
            FindObjectOfType<GameManager>().LevelComplete();
        }
        else if (collision.gameObject.CompareTag("Obstaculo"))
        {
            enabled = false;
            FindObjectOfType<GameManager>().LevelFailed();
        }
    }*/
}