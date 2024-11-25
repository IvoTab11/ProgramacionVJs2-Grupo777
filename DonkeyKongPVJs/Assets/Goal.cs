using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Esta clase representa el objetivo o meta que el jugador debe alcanzar para completar un nivel.*/
public class Goal : MonoBehaviour, ICollisionHandler
{
    /* Este metodo implementado de la interfaz ICollisionHandler.
       Se ejecuta cuando el jugador colisiona con la meta.*/
    public void HandleCollision(Player player)
    {
        // Muestra un mensaje en la consola indicando que el nivel ha sido completado.
        Debug.Log("Nivel completado.");

        // Encuentra el objeto GameManager en la escena y llama al metodo para completar el nivel.
        FindObjectOfType<GameManager>().LevelComplete();
    }
}