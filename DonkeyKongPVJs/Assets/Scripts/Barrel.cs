using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Esta clase abstracta que define el comportamiento comun de los barriles en el juego.*/
public abstract class Barrel : MonoBehaviour
{
    /* Esta variable representa la altura mínima a la que se elimina (desactiva) el barril.*/
    protected float posicionY = -5.0f;

    /* Este metodo llamado en cada frame para verificar el estado del barril.*/
    void Update()
    {
        EliminarBarril();        // Llama al metodo para verificar si el barril debe desactivarse.

    }

    /* Este metodo protegido que desactiva el barril si su posición en el eje Y es menor o igual al limite establecido.*/
    protected void EliminarBarril()
    {
        if (transform.position.y <= posicionY)
        {
            // Desactiva el objeto en lugar de destruirlo, para reutilizarlo más adelante si es necesario.
            gameObject.SetActive(false);
        }
    }
}