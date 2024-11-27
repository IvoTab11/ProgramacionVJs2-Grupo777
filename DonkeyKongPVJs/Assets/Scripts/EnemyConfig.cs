using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyConfig", menuName = "Config/EnemyConfig")]
public class EnemyConfig : ScriptableObject
{
    public float velocidad = 2.0f;
    public float distanciaMaxima = 10f;
    public float spawnInterval = 2f;
    public int poolSize = 5;
 //   public float posicionYLimite = -5.5f; // Límite para desactivar objetos
}