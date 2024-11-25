using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherBarrel : MonoBehaviour
{
    private float posicionY = -5.0f;

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

    void Update()
    {
        EliminarBarril();
    }

    private void EliminarBarril()
    {
        if (transform.position.y <= posicionY)
        {
            gameObject.SetActive(false); // Desactiva el barril si cae demasiado
        }
    }
}