using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour, ICollisionHandler
{
    public void HandleCollision(Player player)
    {
        Debug.Log("Nivel completado.");
        FindObjectOfType<GameManager>().LevelFailed();
    }
}