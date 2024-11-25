using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBarrelCollisionHandler
{
    void HandleCollision(FirtsBarrel firtsBarrel, Collision2D collision);
}
