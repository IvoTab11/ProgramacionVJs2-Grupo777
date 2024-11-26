using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Esta clase maneja las colisiones entre el primer tipo de barril (FirtsBarrel) y las plataformas.*/
public class PlatformCollisionHandler : MonoBehaviour, IBarrelCollisionHandler
{
    /* Esta variable representa el multiplicador para la fuerza aplicada al barril al colisionar con una plataforma.*/
    [SerializeField] private float forceMultiplier = 1f;

    /* Implementa el manejo de colisiones para los barriles y las plataformas.*/
 
    public void HandleCollision(FirtsBarrel firtsBarrel, Collision2D collision)
    {
        // Se obtiene el componente Rigidbody2D del barril para aplicar fuerza.
        Rigidbody2D rb = firtsBarrel.GetComponent<Rigidbody2D>();
        if (rb != null) // Se comprueba que el Rigidbody2D existe.
        {
           
            rb.AddForce( // Se aplica una fuerza al barril en la direccion derecha de la plataforma con un multiplicador.
                collision.transform.right * forceMultiplier, // Dirección de la fuerza
                ForceMode2D.Impulse                         
            );
        }
    }
}