using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondBarrel : Barrel
{

    void Start()
    {
        // Configura las colisiones al iniciar el barril
        ConfigurarColisiones();
    }

    private void ConfigurarColisiones()
    {
        int barrelLayer = LayerMask.NameToLayer("Barriles2");
        int playerLayer = LayerMask.NameToLayer("Personaje");

        // Ignorar colisiones con todas las capas excepto la del Player
        for (int i = 0; i < 32; i++) // Unity soporta hasta 32 capas
        {
            if (i != playerLayer) // Mantener colisiones solo con el Player
            {
                Physics2D.IgnoreLayerCollision(barrelLayer, i, true);
            }
        }
    }
}