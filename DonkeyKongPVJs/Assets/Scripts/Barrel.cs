using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Barrel : MonoBehaviour
{
    protected float posicionY = -5.0f; // Altura mínima para eliminar el barril

    void Update()
    {
        EliminarBarril(); // Método común para verificar si el barril debe desactivarse
    }

    protected void EliminarBarril()
    {
        if (transform.position.y <= posicionY)
        {
            gameObject.SetActive(false); // Desactiva el objeto
        }
    }

}
