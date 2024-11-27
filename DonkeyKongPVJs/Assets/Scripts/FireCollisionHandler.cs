using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Esta clase maneja las colisiones entre el primer tipo de barril (FirtsBarrel) y los fuegos.*/
public class FireCollisionHandler : MonoBehaviour, IBarrelCollisionHandler
{
    /*Se implementa el manejo de colisiones para los barriles y los fuegos.*/
    public void HandleCollision(FirtsBarrel firtsBarrel, Collision2D collision)
    {
        // Ignora las colisiones entre la capa de barriles y la capa de fuegos.
        Physics2D.IgnoreLayerCollision(
            LayerMask.NameToLayer("Barriles"), // Capa de los barriles
            LayerMask.NameToLayer("Fuegos"),  // Capa de los fuegos
            true                              // Se indica que las colisiones deben ser ignoradas
        );
    }
}