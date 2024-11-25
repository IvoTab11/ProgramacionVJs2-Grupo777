using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBarrelCollisionHandler
{
    void HandleCollision(Barrel barrel, Collision2D collision);
}
