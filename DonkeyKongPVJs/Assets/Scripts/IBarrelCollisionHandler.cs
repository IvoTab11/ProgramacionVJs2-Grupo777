using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Interfaz para manejar colisiones específicas de los barriles.*/
public interface IBarrelCollisionHandler
{
    /* Este metodo se utiliza para gestionar colisiones con el primer tipo de barril.*/
    void HandleCollision(FirtsBarrel firtsBarrel, Collision2D collision);
}