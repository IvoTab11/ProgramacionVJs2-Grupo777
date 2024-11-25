using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Gestiona el comportamiento de los barriles que se desplazan por las plataformas.
public class FirtsBarrel : Barrel
{
    private Rigidbody2D rb;
    [SerializeField] private float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Buscar manejadores de colisiones en el objeto colisionado
        IBarrelCollisionHandler handler = collision.gameObject.GetComponent<IBarrelCollisionHandler>();
        if (handler != null)
        {
            handler.HandleCollision(this, collision);
        }
    }

}

