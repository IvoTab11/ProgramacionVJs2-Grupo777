using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Esta claseManeja las colisiones entre el primer tipo de barril (FirtsBarrel) y las monedas. */
public class CoinCollisionHandler : MonoBehaviour, IBarrelCollisionHandler
{
    /* Implementa el manejo de colisiones para los barriles y monedas.*/
    public void HandleCollision(FirtsBarrel firtsBarrel, Collision2D collision)
    {
        // Ignora las colisiones entre la capa de barriles y la capa de monedas.
        Physics2D.IgnoreLayerCollision(
            LayerMask.NameToLayer("Barriles"), // Capa de los barriles
            LayerMask.NameToLayer("Monedas"),  // Capa de las monedas
            true                               // Se indica que las colisiones deben ser ignoradas
        );
    }
}

