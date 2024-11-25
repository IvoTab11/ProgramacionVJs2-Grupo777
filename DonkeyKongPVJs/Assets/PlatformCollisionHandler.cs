using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformCollisionHandler : MonoBehaviour, IBarrelCollisionHandler
{
    [SerializeField] private float forceMultiplier = 1f;

    public void HandleCollision(FirtsBarrel firtsBarrel, Collision2D collision)
    {
        Rigidbody2D rb = firtsBarrel.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.AddForce(collision.transform.right * forceMultiplier, ForceMode2D.Impulse);
        }
    }
}
