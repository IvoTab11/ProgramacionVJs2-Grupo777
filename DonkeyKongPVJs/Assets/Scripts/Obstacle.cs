using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Esta clase representa un obstaculo que, al ser tocado por el jugador, termina el nivel con un fallo*/
public class Obstacle : MonoBehaviour, ICollisionHandler
{
    /* Este metodo implementado de la interfaz ICollisionHandler.
       Se ejecuta cuando el jugador colisiona con el obstáculo.*/
    public void HandleCollision(Player player)
    {
        // Muestra un mensaje en la consola indicando que el nivel ha fallado.
        Debug.Log("Nivel fallido.");

        // Encuentra el objeto GameManager en la escena y llama al metodo para manejar el fallo del nivel.
        FindObjectOfType<GameManager>().LevelFailed();
    }
}