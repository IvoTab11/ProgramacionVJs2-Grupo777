using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Esta interfaz se utiliza para manejar colisiones entre un objeto del mapa  y el jugador.*/
public interface ICollisionHandler
{

    /*Este metodo que debe implementarse en las clases que utilicen esta interfaz.
       Se ejecuta cuando ocurre una colision entre el jugador y otro objeto del mapa (por ej: plataformas u obstaculos).*/
    void HandleCollision(Player player);
}