using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Gestiona el salto del personaje*/
public class PlayerJump : Player, ICollisionExit
{
    [SerializeField] private float jumpForce ;
    /*Indica si el personaje está en la plataforma*/
    private bool isGrounded;
    /*Referencia al componente Rigidbody2D del personaje*/
    private Rigidbody2D rb;
    /*Referencia al colisionador del personaje*/
    private CapsuleCollider2D capsuleCollider2D;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        capsuleCollider2D = GetComponent<CapsuleCollider2D>();
    }

    void Update()
    {
        /*Se llama a la funcion Jump si el personaje esta en una plataforma y si se presiona el boton de salto*/
        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }

    public override void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
    }

    /*Permite saltar al personaje*/
    public void Jump()
    {
        /*Aplica una fuerza hacia arriba en el Rigidbody2D sin deltaTime*/
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }
}