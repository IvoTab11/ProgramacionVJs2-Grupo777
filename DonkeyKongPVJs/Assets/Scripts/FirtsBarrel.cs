using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Esta clase gestiona el comportamiento de los barriles que se desplazan por las plataformas.*/
public class FirtsBarrel : Barrel
{
    /* Esta variable hace referencia al componente Rigidbody2D del barril.*/
    private Rigidbody2D rb;

    /* Esta variable representa la velocidad de movimiento del barril, configurable desde el Inspector.*/
    [SerializeField] private float speed;

    /* Este metodo llamado al inicio para inicializar referencias y configuraciones.*/
    void Start()
    {
        // Obtiene el componente Rigidbody2D asociado al barril.
        rb = GetComponent<Rigidbody2D>();
    }

    /* Este metodo llamado cuando el barril entra en colisión con otro objeto.*/
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Busca un manejador de colisiones que implemente la interfaz IBarrelCollisionHandler.
        IBarrelCollisionHandler handler = collision.gameObject.GetComponent<IBarrelCollisionHandler>();
        if (handler != null)
        {
            // Si el objeto tiene un manejador, delega la lógica de la colisión en el.
            handler.HandleCollision(this, collision);
        }
    }
}
