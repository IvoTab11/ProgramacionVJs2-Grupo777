using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCollisionHandler : MonoBehaviour, IBarrelCollisionHandler
{
    public void HandleCollision(Barrel barrel, Collision2D collision)
    {
        Physics2D.IgnoreLayerCollision(
            LayerMask.NameToLayer("Barriles"),
            LayerMask.NameToLayer("Fuegos"),
            true
        );
    }
}

