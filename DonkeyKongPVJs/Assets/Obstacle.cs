using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour, ICollisionHandler
{
    public void HandleCollision(Player player)
    {
        Debug.Log("Nivel fallido.");
        FindObjectOfType<GameManager>().LevelFailed();
    }
}
