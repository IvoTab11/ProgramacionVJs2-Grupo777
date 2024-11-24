using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour, ICollectible
{
    [SerializeField] private int scoreValue = 100; // Valor de la moneda

    public void Collect(Player player)
    {
        Debug.Log("Moneda recogida, puntos: " + scoreValue);
        FindObjectOfType<GameManager>().AddScore(scoreValue);
        Destroy(gameObject); // Destruye la moneda al recogerla
    }
}
