using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Gestiona el comportamiento de los barriles que se desplazan por las plataformas.
public class Barrel : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float speed = 1f;
    private float posicionY = -5.5f;

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

    void Update()
    {
        EliminarBarril();
    }

    private void EliminarBarril()
    {
        if (this.transform.position.y <= posicionY)
        {
            this.gameObject.SetActive(false);
        }
    }
}

