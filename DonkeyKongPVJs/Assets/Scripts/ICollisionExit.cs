using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICollisionExit
{
    // Método que las clases que implementen la interfaz deben definir
    void OnCollisionExit2D(Collision2D collision);
}

