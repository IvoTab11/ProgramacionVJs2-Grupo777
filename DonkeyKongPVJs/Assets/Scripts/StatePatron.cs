using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum PlayerControllerState
{
    Idle,
    Walk,
    Jump,
    Climb
}

public class StatePatron : MonoBehaviour
{
    private PlayerControllerState state;

    private void Update()
    {
        GetInput();

        switch (state)
        {
            case PlayerControllerState.Idle:
                Idle();
                break;
            case PlayerControllerState.Walk:
                Walk();
                break;
            case PlayerControllerState.Jump:
                Jump();
                break;
            case PlayerControllerState.Climb:
                Climb();
                break;
        }
    }

    private void GetInput()
    {
 
        if (Input.GetKey(KeyCode.A))
        {
            state = PlayerControllerState.Walk;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            state = PlayerControllerState.Walk;
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            state = PlayerControllerState.Jump;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            state = PlayerControllerState.Climb;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            state = PlayerControllerState.Climb;
        }
        else
        {
            state = PlayerControllerState.Idle;
        }
    }


    private void Walk()
    {
        // Lógica para caminar
        Debug.Log("Caminando");
    }

    private void Idle()
    {
        // Lógica para estar inactivo
        Debug.Log("Inactivo");
    }

    private void Jump()
    {
        // Lógica para saltar
        Debug.Log("Saltando");
    }

    private void Climb()
    {
        // Lógica para escalar
        Debug.Log("Escalando");
    }
}


