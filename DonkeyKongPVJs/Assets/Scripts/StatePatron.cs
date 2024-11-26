using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Define los estados posibles del jugador.
public enum PlayerControllerState
{
    Idle, // Inactivo.
    Walk, // Ccaminando.
    Jump, // Saltando.
    Climb // Escalando.
}

/* Implementa el patrón State para gestionar los estados del jugador*/
public class StatePatron : MonoBehaviour
{
    // Variable que almacena el estado actual del jugador
    private PlayerControllerState state;

    
    private void Update()
    {
        // Obtiene la entrada del jugador y actualiza el estado.
        GetInput();

        // Cambia el comportamiento según el estado actual del jugador.
        switch (state)
        {
            case PlayerControllerState.Idle:
                // Ejecuta la lógica del estado Idle.
                Idle();
                break;
            case PlayerControllerState.Walk:
                // Ejecuta la lógica del estado Walk.
                Walk();
                break;
            case PlayerControllerState.Jump:
                // Ejecuta la lógica del estado Jump.
                Jump();
                break;
            case PlayerControllerState.Climb:
                // Ejecuta la lógica del estado Climb.
                Climb();
                break;
        }
    }

    /* Método que captura la entrada del jugador y asigna el estado correspondiente*/
    private void GetInput()
    {
        if (Input.GetKey(KeyCode.A))
        {
            // Cambia el estado a "Walk" si se presiona la tecla A.
            state = PlayerControllerState.Walk;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            // Cambia el estado a "Walk" si se presiona la tecla D.
            state = PlayerControllerState.Walk;
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            // Cambia el estado a "Jump" si se presiona la barra espaciadora.
            state = PlayerControllerState.Jump;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            // Cambia el estado a "Climb" si se presiona la tecla W.
            state = PlayerControllerState.Climb;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            // Cambia el estado a "Climb" si se presiona la tecla S.
            state = PlayerControllerState.Climb;
        }
        else
        {
            // Cambia el estado a "Idle" si no se detecta ninguna entrada.
            state = PlayerControllerState.Idle;
        }
    }

  /*Método que ejecuta la lógica del estado Walk.*/
    private void Walk()
    {
        Debug.Log("Caminando");
    }

    /*Método que ejecuta la lógica del estado Idle.*/
    private void Idle()
    {
        Debug.Log("Inactivo");
    }

    /* Método que ejecuta la lógica del estado Jump.*/
    private void Jump()
    {
        Debug.Log("Saltando");
    }

    /* Método que ejecuta la lógica del estado Climb.*/
    private void Climb()
    {
        Debug.Log("Escalando");
    }
}

