using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Esta clase que gestiona el comportamiento del segundo tipo de barril.*/
public class SecondBarrel : Barrel
{
    /* Este metodo que se ejecuta al iniciar el barril.*/
    void Start()
    {
        // Configura las colisiones específicas para este barril al inicio.
        ConfigurarColisiones();
    }

    /* Este metodo se utiliza para configurar las colisiones del barril con otras capas.*/
    private void ConfigurarColisiones()
    {
        // Se obtiene el indice de la capa "Barriles2".
        int barrelLayer = LayerMask.NameToLayer("Barriles2");

        // Se obtiene el indice de la capa "Personaje".
        int playerLayer = LayerMask.NameToLayer("Personaje");

        // Ignora las colisiones con todas las capas excepto la del "Personaje".
        for (int i = 0; i < 32; i++) 
        {
            if (i != playerLayer) // Si la capa no es la del "Personaje".
            {
                // Ignora las colisiones entre la capa del barril y la capa actual del bucle.
                Physics2D.IgnoreLayerCollision(barrelLayer, i, true);
            }
        }
    }
}