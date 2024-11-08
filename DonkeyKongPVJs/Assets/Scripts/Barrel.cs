using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Gestiona el comportamiento de los barriles que se desplazan por las plataformas.
public class Barrel : MonoBehaviour
{
    //Referencia al componente Rigidbody2D del barril.
    private Rigidbody2D rb;
    [SerializeField] private float speed=1f;
    private float posicionY=-5.5f;

    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }

    // OnCollisionEnter2D() maneja las colisiones con otros objetos.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Comprueba si la colisión es con objetos de diferentes capas.
        if(collision.gameObject.layer == LayerMask.NameToLayer("Plataformas")){
        //Aplica un impulso al movimiento del barril hacia la derecha si colisiona con una plataforma.
         rb.AddForce(collision.transform.right * speed, ForceMode2D.Impulse);
        }
        if(collision.gameObject.layer == LayerMask.NameToLayer("Fuegos")){
        // Ignora la colisión entre la capa "Barriles" y la capa "Fuegos".
         Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Barriles"), LayerMask.NameToLayer("Fuegos"), true);
        }
        if(collision.gameObject.layer == LayerMask.NameToLayer("Barriles2")){
        // Ignora la colisión entre la capa "Barriles" y la capa "Barriles2".
         Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Barriles"), LayerMask.NameToLayer("Barriles2"), true);
        }
        if(collision.gameObject.layer == LayerMask.NameToLayer("Monedas")){
        // Ignora la colisión entre la capa "Barriles" y la capa "Barriles2".
         Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Barriles"), LayerMask.NameToLayer("Monedas"), true);
        }
    }

    void Update(){
        EliminarBarril();
    }

    private void EliminarBarril(){
        //Comprueba si la posición en el eje Y del barril es menor a -5.5.
        if(this.transform.position.y<=posicionY){
            //Destruye el gameObject.
            //Destroy(this.gameObject);
            this.gameObject.SetActive(false);
        }
    }
}
